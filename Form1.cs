using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;


namespace WSZapp
{
    public partial class Form1 : Form
    {
        // prawy przycisk myszy wciœniêty
        bool bMouseDown = false;

        // pozycja wkaŸnika myszy po wciœniêciu prawego przycisku
        Point mousePosDown = Point.Empty;

        // pozycja okna po wciœniêciu prawego przycisku
        Point currentFormLocation = Point.Empty;

        Graphics gDraw;
        // gDraw rysuje po bmp, a pictureBox_chart wyœwietla bmp
        Bitmap bmp;

        // kolor t³a wykresu
        Color backColor = Color.Black;
        // kolor wykresu
        Color chartColor = Color.Blue;
        // kolor osi wspó³rzêdnych
        Color coordColor = Color.White;
        // kolor legendy
        Color legendColor = Color.Red;
        // kolor punktów w regresji liniowej
        Color regPointColor = Color.Green;

        // plik z danymi do regresji liniowej
        String dataFile = "data.txt";

        // kontener do przechowywania wspó³rzêdnych dla regresji liniowej
        class LinearRegrContainer
        {
            public LinearRegrContainer(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int X;
            public int Y;
        }

        // lista punktów regresji liniowej
        List<LinearRegrContainer> linearRegPoints = new List<LinearRegrContainer>();

        // punkt przeciêcia oraz nachylenie w funkcji regresji liniowej
        double linearRegIntercept, linearRegSlope;

        // d³ugoœæ osi Y - do odwracania wykresu wzglêdem osi X
        int YaxisLength;
        // d³ugoœæ osi X - do odwracania wykresu wzglêdem osi Y
        int XaxisLength;

        // zmienne do modyfikacji funkcji sinusa
        double sinusParamA = 1, sinusParamB = 1;
        double sinusParamMin = -5, sinusParamMax = 5;


        // zmienne do modyfikaci potêgi
        double pow = 2;

        // zmienne do modyfikacji funkcji kwadratowej
        double aSquareFunParam = -1.0f, bSquareFunParam = 0.0f, cSquareFunParam = 2.0f;

        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox_chart.Width, pictureBox_chart.Height);

            gDraw = Graphics.FromImage(bmp);
            gDraw.Clear(backColor);
            gDraw.SmoothingMode = SmoothingMode.AntiAlias;

            pictureBox_chart.Image = bmp;

            XaxisLength = pictureBox_chart.Width;
            YaxisLength = pictureBox_chart.Height;

            refreshPictureBox();
        }

        ///////////////////////////////////////////////
        ///
        /// REGRESJA LINIOWA
        /// 
        ///////////////////////////////////////////////


        /// <summary>
        /// Wczytuje dane z pliku
        /// </summary>
        private void btnLinearRegRead_Click(object sender, EventArgs e)
        {
            // czyta wszystkie linie z pliki
            string[] lines = File.ReadAllLines(dataFile);

            linearRegPoints.Clear();
            tbData.Clear();

            foreach (string line in lines)
            {
                // sprawdzenie poprawnoœci danych w ka¿dej linii za pomoc¹ wyra¿enia regularnego
                // ^-?[0-9]{1,3}\,-?[0-9]{1,3}$
                // ^-?\\d{1,3}\\,-?\\d{1,3}$
                Regex rg = new Regex("^\\d{1,3}\\,\\d{1,3}$");

                if (rg.IsMatch(line))
                {
                    // podzia³ danych wzglêdem znaku: ,
                    string[] coord = line.Split(',');
                    int x = Int32.Parse(coord[0]);
                    int y = Int32.Parse(coord[1]);
                    if ((x >= 0 && x <= 500) && (y >= 0 && y <= 500))
                    {
                        linearRegPoints.Add(new LinearRegrContainer(x, y));
                        tbData.AppendText(line + Environment.NewLine);
                    }
                }
            }
        }
        /// <summary>
        /// Zapisuje dane do pliku
        /// </summary>
        private void btnLinearRegrSaveFile_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            for (int i = 0; i < tbData.Lines.Length; i++)
            {
                lines.Add(tbData.Lines[i]);
            }

            File.WriteAllLines(dataFile, lines.ToArray());
        }

        /// <summary>
        /// Losuje dane i odœwie¿a wykres
        /// </summary>
        private void btnLinearRegrRandom_Click(object sender, EventArgs e)
        {
            // zeruje listê punktów regresji liniowej
            linearRegPoints.Clear();
            // czyœci pole tekstowe z danymi
            tbData.Clear();

            var rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(501);
                int y = rand.Next(501);
                linearRegPoints.Add(new LinearRegrContainer(x, y));

                tbData.AppendText(x.ToString() + ',' + y.ToString() + Environment.NewLine);
            }

            // wyso³uje klikniêcie przycisku
            btnLinearRegRefresh.PerformClick();
        }

        // Odœwie¿a wykres regresji liniowej
        private void btnLinearRegRefresh_Click(object sender, EventArgs e)
        {
            refreshPictureBox();
        }

        // rysuje wykres regresji liniowej
        private void drawLinearRegression()
        {
            Pen pen1 = new Pen(regPointColor, 7);
            Pen pen2 = new Pen(chartColor, 3);
            int pointRadius = 14;

            // czyta wszystkie linie z pliki
            /*string[] lines = File.ReadAllLines(dataFile);

            linearRegPoints.Clear();
            tbData.Clear();*/

            ///////////////////////////////
            /// rysowanie punktów na wykresie
            /// 
            /*foreach (string line in lines)
            {
                // sprawdzenie poprawnoœci danych w ka¿dej linii za pomoc¹ wyra¿enia regularnego
                // ^-?[0-9]{1,3}\,-?[0-9]{1,3}$
                // ^-?\\d{1,3}\\,-?\\d{1,3}$
                Regex rg = new Regex("^\\d{1,3}\\,\\d{1,3}$");

                if (rg.IsMatch(line))
                {
                    // podzia³ danych wzglêdem znaku: ,
                    string[] coord = line.Split(',');
                    int x = Int32.Parse(coord[0]);
                    int y = Int32.Parse(coord[1]);
                    if ((x >= 0 && x <= 500) && (y >= 0 && y <= 500))
                    {
                        tbData.AppendText(line + Environment.NewLine);
                        linearRegPoints.Add(new LinearRegrContainer(x, y));

                        // "500" offset dla x oraz "odwrócenie" dla y dla danych z zakresu 0-500 do wykresu 0-1000
                        gDraw.DrawEllipse(pen1, linearRegPoints.Last().X + 500 - pointRadius / 2, 500 - linearRegPoints.Last().Y - pointRadius / 2, pointRadius, pointRadius);
                    }
                }
            }*/


            // wyliczenie funkcji regresji liniowej
            int count = linearRegPoints.Count;
            if (count > 0)
            {
                double sumX = 0;
                double sumX2 = 0;
                double sumY = 0;
                double sumXY = 0;

                foreach (LinearRegrContainer item in linearRegPoints)
                {
                    // rysuje punkt na wykresie
                    gDraw.DrawEllipse(pen1, item.X + 500 - pointRadius / 2, 500 - item.Y - pointRadius / 2, pointRadius, pointRadius);

                    var x = item.X;
                    var y = item.Y;
                    sumXY += x * y;
                    sumX += x;
                    sumY += y;
                    sumX2 += x * x;
                }

                double meanX = sumX / count;
                double meanY = sumY / count;
                double ssX = sumX2 - ((sumX * sumX) / count);
                double ssXY = sumXY - ((sumX * sumY) / count);

                // Math.Round zaokr¹glenie do dwóch miejsc po przecinku
                linearRegIntercept = Math.Round((meanY - (ssXY / ssX) * meanX), 2);
                linearRegSlope = Math.Round(ssXY / ssX, 2);


                // rysowanie wykresu regresji liniowej
                double x1 = 0, y1 = squareFun(x1, 0, linearRegSlope, linearRegIntercept);
                double y2;

                for (int x2 = 0; x1 <= 500; x2 += 10)
                {
                    y2 = squareFun(x2, 0, linearRegSlope, linearRegIntercept);

                    // YaxisLength s³u¿y do odwórcenia wykresów wzglêdem osi X
                    // "+500" offset dla danych x,y [0-500] wzglêdem œrodka obszaru roboczego 500,500
                    int x1_ = (int)(x1 + 500);
                    int y1_ = YaxisLength - (int)(y1 + 500);
                    int x2_ = (int)(x2 + 500);
                    int y2_ = YaxisLength - (int)(y2 + 500);

                    gDraw.DrawLine(pen2, x1_, y1_, x2_, y2_);

                    x1 = x2;
                    y1 = y2;
                }
            }
        }




        ///////////////////////////////////////////////
        ///
        /// FUNKCJA KWADRATOWA
        /// 
        ///////////////////////////////////////////////

        /// <summary>
        /// oblicza wynik funkcji kwadratowej
        /// f(x) = ax^2 + bx + c
        /// </summary>
        private double squareFun(double x, double a, double b, double c)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

        /// <summary>
        /// rysuje wykres funkcji kwadratowej
        /// </summary>
        private void drawSquareFun()
        {
            Pen pen = new Pen(chartColor, 3);

            double x1 = -5.1f, y1 = squareFun(x1, aSquareFunParam, bSquareFunParam, cSquareFunParam);
            double y2;

            for (double x2 = -5.0f; x2 <= 5.0f; x2 += 0.1f)
            {
                y2 = squareFun(x2, aSquareFunParam, bSquareFunParam, cSquareFunParam);

                // YaxisLength s³u¿y do odwórcenia wykresów wzglêdem osi X
                // * 100 + 500 => mapowaniu skali -5,5 do skali obszaru roboczego 0,1000
                int x1_ = (int)(x1 * 100 + 500);
                int y1_ = YaxisLength - (int)(y1 * 100 + 500);
                int x2_ = (int)(x2 * 100 + 500);
                int y2_ = YaxisLength - (int)(y2 * 100 + 500);

                gDraw.DrawLine(pen, x1_, y1_, x2_, y2_);

                //Console.Write(x1.ToString() + " " + y1.ToString() + " " + x2.ToString() + " " + y2.ToString() + '\n');
                //Console.Write((x1 * 10 + 500).ToString() + " " + (YaxisLength - (y1 * 10 + 500)).ToString() + " " 
                //    + (x2 * 10 + 500).ToString() + " " + (YaxisLength - (y2 * 10 + 500)).ToString() + '\n');
                //Console.Write(((int)(x1 * 10 + 500)).ToString() + " " + ((int)(YaxisLength - (y1 * 10 + 500))).ToString() + " " 
                //    + ((int)(x2 * 10 + 500)).ToString() + " " + ((int)(YaxisLength - (y2 * 10 + 500))).ToString() + '\n');
                //Console.Write("-----\n");
                x1 = x2;
                y1 = y2;
            }
        }

        /// <summary>
        /// funkcja wywo³ywana przy zmianie parametrów potêgi na trackbarach
        /// </summary>
        private void tbSquareFun_Scroll(object sender, EventArgs e)
        {
            aSquareFunParam = tbSquareFunParamA.Value;
            bSquareFunParam = tbSquareFunParamB.Value;
            cSquareFunParam = tbSquareFunParamC.Value;

            lblSquareFunParamA.Text = aSquareFunParam.ToString();
            lblSquareFunParamB.Text = bSquareFunParam.ToString();
            lblSquareFunParamB.Text = cSquareFunParam.ToString();

            refreshPictureBox();
        }



        ///////////////////////////////////////////////
        ///
        /// FUNKCJA SINUSA
        /// 
        ///////////////////////////////////////////////


        /// <summary>
        /// rysuje wykres sinusa
        /// </summary>
        private void drawSinus()
        {
            Pen pen = new Pen(chartColor, 3);

            double x1 = -5, y1 = sinusParamA * Math.Sin(x1 * sinusParamB);
            double x2, y2;

            //for (int i = 0; i < 2000; i += 1)
            for (x2 = sinusParamMin; x2 < sinusParamMax; x2 += 0.1f)
            {
                y2 = sinusParamA * Math.Sin(x2 * sinusParamB);

                // YaxisLength s³u¿y do odwórcenia wykresów wzglêdem osi X
                // * 100 + 500 => mapowaniu skali -5,5 do skali obszaru roboczego 0,1000
                int x1_ = (int)(x1 * 100 + 500);
                int y1_ = YaxisLength - (int)(y1 * 100 + 500);
                int x2_ = (int)(x2 * 100 + 500);
                int y2_ = YaxisLength - (int)(y2 * 100 + 500);

                gDraw.DrawLine(pen, x1_, y1_, x2_, y2_);
                //Console.Write(x1.ToString() + " " + y1.ToString() + " " + x2.ToString() + " " + y2.ToString() + '\n');
                //Console.Write(x1_.ToString() + " " + y1_.ToString() + " " + x2_.ToString() + " " + y2_.ToString() + '\n');
                //Console.Write("---------\n");
                x1 = x2;
                y1 = y2;
            }
        }

        /// <summary>
        /// funkcja wywo³ywana przy zmianie parametrów sinusa na trackbarach
        /// zarówno przy skrolowaniu jak i rêcznej zmiane wartoœci w kodzie,
        /// patrz symulacja
        /// </summary>
        private void tbSinusOffset_ValueChanged(object sender, EventArgs e)
        {
            // skala na trackbarach od -50 do 50 -> * 0.1f - normalizacja do zakresu -5 do 5
            sinusParamA = Math.Round(tbSinParamA.Value * 0.1f, 1);
            sinusParamB = Math.Round(tbSinParamB.Value * 0.1f, 1);

            lblSinParamA.Text = sinusParamA.ToString();
            lblSinParamB.Text = sinusParamB.ToString();

            refreshPictureBox();
        }

        /// <summary>
        /// timer do sumulacji wykresu sinusa
        /// </summary>
        private void timerSinusSymulation_Tick(object sender, EventArgs e)
        {
            sinusParamA = Math.Round(sinusParamA + 0.1f, 2);

            if (sinusParamA > sinusParamMax)
            {
                timerSymulation.Enabled = false;
                return;
            }
            tbSinParamA.Value = (int)(sinusParamA * 10);


            sinusParamB = Math.Round(sinusParamB + 0.1f, 2);

            if (sinusParamB > sinusParamMax)
            {
                timerSymulation.Enabled = false;
                return;
            }
            tbSinParamB.Value = (int)(sinusParamB * 10);
        }

        /// <summary>
        /// uruchamia symulacjê sinusa
        /// </summary>
        private void btnSinusSymulation_Click(object sender, EventArgs e)
        {
            sinusParamA = sinusParamMin;
            tbSinParamA.Value = (int)(sinusParamA * 10);

            sinusParamB = sinusParamMin;
            tbSinParamB.Value = (int)(sinusParamB * 10);

            timerSymulation.Enabled = true;
        }



        ///////////////////////////////////////////////
        ///
        /// FUNKCJA POTÊGI
        /// 
        ///////////////////////////////////////////////


        /// <summary>
        /// rysuje wykres potêgi
        /// </summary>
        private void drawPow()
        {
            Pen pen = new Pen(chartColor, 3);

            double x1 = -5, y1 = Math.Pow(x1, pow);
            double y2;
            for (double x2 = -5; x2 <= 5; x2 += 0.1f)
            {
                y2 = Math.Pow(x2, pow);

                // YaxisLength s³u¿y do odwórcenia wykresów wzglêdem osi X
                // * 100 + 500 => mapowaniu skali -5,5 do skali obszaru roboczego 0,1000
                int x1_ = (int)(x1 * 100 + 500);
                int y1_ = YaxisLength - (int)(y1 * 100 + 500);
                int x2_ = (int)(x2 * 100 + 500);
                int y2_ = YaxisLength - (int)(y2 * 100 + 500);

                gDraw.DrawLine(pen, x1_, y1_, x2_, y2_);
                //Console.Write(x1.ToString() + " " + y1.ToString() + " " + x2.ToString() + " " + y2.ToString() + '\n');
                x1 = x2;
                y1 = y2;
            }
        }

        /// <summary>
        /// funkcja wywo³ywana przy zmianie parametrów potêgi na trackbarach
        /// </summary>
        private void tbPowOffset_Scroll(object sender, EventArgs e)
        {
            pow = tbPow.Value;

            lblPow.Text = pow.ToString();

            refreshPictureBox();
        }




        ///////////////////////////////////////////////
        ///
        /// FUNKCJE GRAFICZNE
        /// 
        ///////////////////////////////////////////////

        /// <summary>
        /// funkcja rysuje osie wykresu i siatkê
        /// </summary>
        private void drawCoordinates()
        {
            Pen pen = new Pen(coordColor, 3);
            Pen pen2 = new Pen(Color.Gray, 1);
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            // wielkoœæ grotów
            int lenArrowhead = 20;

            // **************************
            // oœ Y
            // **************************
            gDraw.DrawLine(pen, XaxisLength / 2, 0, XaxisLength / 2, YaxisLength);

            // grot
            gDraw.DrawLine(pen, XaxisLength / 2, 0, XaxisLength / 2 - lenArrowhead, 0 + lenArrowhead);
            gDraw.DrawLine(pen, XaxisLength / 2, 0, XaxisLength / 2 + lenArrowhead, 0 + lenArrowhead);

            // podzia³ki i siatka
            int yMin = -5;
            for (int i = YaxisLength; i > 0; i -= 100)
            {
                // siatka
                if (chGrid.Checked)
                    gDraw.DrawLine(pen2, 0, i, XaxisLength, i);

                // oœ
                gDraw.DrawLine(pen, XaxisLength / 2 - 10, i, XaxisLength / 2 + 10, i);
                if (i != YaxisLength / 2)
                    gDraw.DrawString(yMin.ToString(), drawFont, drawBrush, XaxisLength / 2 + 10, i - 15);
                yMin++;
            }


            // **************************
            // oœ X
            // **************************
            gDraw.DrawLine(pen, 0, YaxisLength / 2, YaxisLength, YaxisLength / 2);

            // grot
            gDraw.DrawLine(pen, YaxisLength, YaxisLength / 2, YaxisLength - lenArrowhead, YaxisLength / 2 - lenArrowhead);
            gDraw.DrawLine(pen, YaxisLength, YaxisLength / 2, YaxisLength - lenArrowhead, YaxisLength / 2 + lenArrowhead);

            // podzia³ki i siatka
            int xMin = -5;
            for (int i = 0; i < XaxisLength; i += 100)
            {
                // siatka
                if (chGrid.Checked)
                    gDraw.DrawLine(pen2, i, 0, i, YaxisLength);

                // oœ
                gDraw.DrawLine(pen, i, YaxisLength / 2 - 10, i, YaxisLength / 2 + 10);
                if (i != XaxisLength / 2)
                    gDraw.DrawString(xMin.ToString(), drawFont, drawBrush, i, YaxisLength / 2 + 10);
                xMin++;
            }

        }

        /// <summary>
        /// funkcja rysuje wykres w zale¿noœci od wyboru typu
        /// </summary>
        private void drawChart()
        {
            Pen pen = new Pen(Color.Blue, 3);
            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(legendColor);
            String chartName = "";


            // funkcja kwadratowa
            if (rbtn1.Checked)
            {
                drawSquareFun();
                chartName = String.Format("Funkcja kwadratowa:\nf(x)={0}x^2+{1}x+{2}", aSquareFunParam, bSquareFunParam, cSquareFunParam);
            }
            // potêga
            else if (rbtn2.Checked)
            {
                drawPow();
                chartName = String.Format("Potêga: f(x)=x^{0}", pow);
            }
            // sinus
            else if (rbtn3.Checked)
            {
                drawSinus();
                chartName = String.Format("Sinus: f(x)={0}*sin(x*{1})", sinusParamA, sinusParamB);
            }
            // regresja liniowa
            else if (rbtn4.Checked)
            {
                drawLinearRegression();
                chartName = String.Format("Regresja linowa:\nf(x)={0}x+{1}", linearRegSlope, linearRegIntercept);
            }

            gDraw.DrawString(chartName, drawFont, drawBrush, new Point(0, 0));
        }

        /// <summary>
        /// funkcja wywo³ywana przy wyborze typu wykresu (radio buttons)
        /// </summary>
        private void radiobuttons_CheckedChanged(object sender, EventArgs e)
        {
            // funkcja kwadratowa
            if (sender.Equals(rbtn1) && rbtn1.Checked)
            {
                tabControl1.SelectTab(2);
                refreshPictureBox();
            }
            // potêga
            else if (sender.Equals(rbtn2) && rbtn2.Checked)
            {
                tabControl1.SelectTab(1);
                refreshPictureBox();
            }
            // sinus
            else if (sender.Equals(rbtn3) && rbtn3.Checked)
            {
                tabControl1.SelectTab(0);
                refreshPictureBox();
            }
            // regresja liniowa
            else if (sender.Equals(rbtn4) && rbtn4.Checked)
            {
                tabControl1.SelectTab(3);
                refreshPictureBox();
            }
        }

        /// <summary>
        /// przerysowuje wykres
        /// </summary>
        private void refreshPictureBox()
        {
            gDraw.Clear(backColor);
            drawCoordinates();
            drawChart();
            pictureBox_chart.Refresh();
        }

        /// <summary>
        /// wyjœcie z aplikacji
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// funkcja u¿ywana do przesuwania okna
        /// </summary>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            mousePosDown = Control.MousePosition;
            currentFormLocation = Location;
        }

        /// <summary>
        /// funkcja u¿ywana do przesuwania okna
        /// </summary>
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
            mousePosDown = Point.Empty;
            currentFormLocation = Point.Empty;
        }

        /// <summary>
        /// funkcja u¿ywana do przesuwania okna
        /// </summary>
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                var currentPos = Control.MousePosition;
                var distX = currentPos.X - mousePosDown.X;
                var distY = currentPos.Y - mousePosDown.Y;
                Location = new Point(currentFormLocation.X + distX, currentFormLocation.Y + distY);
            }
        }

        /// <summary>
        /// ustawia kolor t³a wykresu
        /// </summary>
        private void btnBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                backColor = colorDialog1.Color;

                refreshPictureBox();
            }
        }

        /// <summary>
        /// ustawia kolor wykresu
        /// </summary>
        private void btnChartColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                chartColor = colorDialog1.Color;

                refreshPictureBox();
            }
        }

        // ustawia kolor osi
        private void btnCoordColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                coordColor = colorDialog1.Color;

                refreshPictureBox();
            }
        }

        // ustawia kolor legendy
        private void btnLegendColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                legendColor = colorDialog1.Color;

                refreshPictureBox();
            }
        }

        // w³¹cza/wy³¹cza siatkê
        private void chGrid_CheckedChanged(object sender, EventArgs e)
        {
            refreshPictureBox();
        }

        // zapisuje wykres do pliku
        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "wykres.png";
            saveFileDialog1.ShowDialog();

            Bitmap b = new Bitmap(1000, 1000);
            Graphics g = Graphics.FromImage(b);
            g.DrawImage(bmp, 0, 0, 1000, 1000);
            var b2 = b.Clone(new Rectangle(0, 0, 1000, 1000), PixelFormat.Format24bppRgb);

            b2.Save(saveFileDialog1.FileNames[0], ImageFormat.Png);
        }

        // funkcja do zapisu wykresu za pomoc¹ skrótu ctrl+s
        // dodana jest te¿ do kilku innych kontrolek 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSaveChart.PerformClick();
            }
        }
    }
}