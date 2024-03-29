namespace WSZapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox_chart = new PictureBox();
            btnClose = new Button();
            lblDebug = new Label();
            pictureBoxIcon = new PictureBox();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnSinusSymulation = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSinParamB = new Label();
            lblSinParamA = new Label();
            tbSinParamA = new TrackBar();
            tbSinParamB = new TrackBar();
            tabPage2 = new TabPage();
            label8 = new Label();
            label6 = new Label();
            lblPow = new Label();
            tbPow = new TrackBar();
            tabPage3 = new TabPage();
            tbSquareFunParamC = new TrackBar();
            tbSquareFunParamB = new TrackBar();
            lblSquareFunParamC = new Label();
            label9 = new Label();
            lblSquareFunParamB = new Label();
            label7 = new Label();
            lblSquareFunParamA = new Label();
            label5 = new Label();
            label4 = new Label();
            tbSquareFunParamA = new TrackBar();
            tabPage5 = new TabPage();
            btnLinearRegrSaveFile = new Button();
            btnLinearRegRead = new Button();
            btnLinearRegrRandom = new Button();
            btnLinearRegRefresh = new Button();
            tbData = new TextBox();
            tabPage4 = new TabPage();
            label11 = new Label();
            label10 = new Label();
            chGrid = new CheckBox();
            btnLegendColor = new Button();
            btnCoordColor = new Button();
            btnChartColor = new Button();
            btnBackColor = new Button();
            panel2 = new Panel();
            rbtn4 = new RadioButton();
            lblChartSelect = new Label();
            rbtn3 = new RadioButton();
            rbtn2 = new RadioButton();
            rbtn1 = new RadioButton();
            btnSaveChart = new Button();
            saveFileDialog1 = new SaveFileDialog();
            colorDialog1 = new ColorDialog();
            timerSymulation = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSinParamA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSinParamB).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPow).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbSquareFunParamC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSquareFunParamB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSquareFunParamA).BeginInit();
            tabPage5.SuspendLayout();
            tabPage4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_chart
            // 
            pictureBox_chart.Location = new Point(24, 52);
            pictureBox_chart.Name = "pictureBox_chart";
            pictureBox_chart.Size = new Size(1000, 1000);
            pictureBox_chart.TabIndex = 0;
            pictureBox_chart.TabStop = false;
            pictureBox_chart.MouseDown += Form1_MouseDown;
            pictureBox_chart.MouseMove += Form1_MouseMove;
            pictureBox_chart.MouseUp += Form1_MouseUp;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Brown;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.Control;
            btnClose.Location = new Point(1406, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = "Zamknij";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.KeyDown += Form1_KeyDown;
            // 
            // lblDebug
            // 
            lblDebug.AutoSize = true;
            lblDebug.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebug.Location = new Point(605, 5);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(269, 38);
            lblDebug.TabIndex = 2;
            lblDebug.Text = "Wykresy funkcji v1.0";
            lblDebug.MouseDown += Form1_MouseDown;
            lblDebug.MouseMove += Form1_MouseMove;
            lblDebug.MouseUp += Form1_MouseUp;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Image = Properties.Resources.ikona;
            pictureBoxIcon.Location = new Point(27, 6);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(48, 42);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon.TabIndex = 4;
            pictureBoxIcon.TabStop = false;
            pictureBoxIcon.MouseDown += Form1_MouseDown;
            pictureBoxIcon.MouseMove += Form1_MouseMove;
            pictureBoxIcon.MouseUp += Form1_MouseUp;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSaveChart);
            panel1.Location = new Point(1030, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 1000);
            panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(13, 179);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(474, 761);
            tabControl1.TabIndex = 2;
            tabControl1.KeyDown += Form1_KeyDown;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ControlText;
            tabPage1.Controls.Add(btnSinusSymulation);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lblSinParamB);
            tabPage1.Controls.Add(lblSinParamA);
            tabPage1.Controls.Add(tbSinParamA);
            tabPage1.Controls.Add(tbSinParamB);
            tabPage1.ForeColor = SystemColors.Control;
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(466, 720);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sinus";
            // 
            // btnSinusSymulation
            // 
            btnSinusSymulation.BackColor = SystemColors.Highlight;
            btnSinusSymulation.FlatStyle = FlatStyle.Flat;
            btnSinusSymulation.Location = new Point(12, 298);
            btnSinusSymulation.Name = "btnSinusSymulation";
            btnSinusSymulation.Size = new Size(112, 34);
            btnSinusSymulation.TabIndex = 11;
            btnSinusSymulation.Text = "Symulacja";
            btnSinusSymulation.UseVisualStyleBackColor = false;
            btnSinusSymulation.Click += btnSinusSymulation_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(185, 32);
            label3.TabIndex = 10;
            label3.Text = "f(x)=a*sin(x*b)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(27, 25);
            label2.TabIndex = 9;
            label2.Text = "b:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(25, 25);
            label1.TabIndex = 8;
            label1.Text = "a:";
            // 
            // lblSinParamB
            // 
            lblSinParamB.AutoSize = true;
            lblSinParamB.Location = new Point(411, 223);
            lblSinParamB.Name = "lblSinParamB";
            lblSinParamB.Size = new Size(22, 25);
            lblSinParamB.TabIndex = 6;
            lblSinParamB.Text = "1";
            // 
            // lblSinParamA
            // 
            lblSinParamA.AutoSize = true;
            lblSinParamA.Location = new Point(411, 112);
            lblSinParamA.Name = "lblSinParamA";
            lblSinParamA.Size = new Size(22, 25);
            lblSinParamA.TabIndex = 5;
            lblSinParamA.Text = "1";
            // 
            // tbSinParamA
            // 
            tbSinParamA.Location = new Point(3, 112);
            tbSinParamA.Maximum = 50;
            tbSinParamA.Minimum = -50;
            tbSinParamA.Name = "tbSinParamA";
            tbSinParamA.Size = new Size(413, 69);
            tbSinParamA.TabIndex = 2;
            tbSinParamA.TickStyle = TickStyle.TopLeft;
            tbSinParamA.Value = 10;
            tbSinParamA.ValueChanged += tbSinusOffset_ValueChanged;
            // 
            // tbSinParamB
            // 
            tbSinParamB.Location = new Point(6, 223);
            tbSinParamB.Maximum = 50;
            tbSinParamB.Minimum = -50;
            tbSinParamB.Name = "tbSinParamB";
            tbSinParamB.Size = new Size(404, 69);
            tbSinParamB.TabIndex = 3;
            tbSinParamB.TickStyle = TickStyle.TopLeft;
            tbSinParamB.Value = 10;
            tbSinParamB.ValueChanged += tbSinusOffset_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.ControlText;
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(lblPow);
            tabPage2.Controls.Add(tbPow);
            tabPage2.Location = new Point(4, 37);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(466, 720);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Potęga";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 68);
            label8.Name = "label8";
            label8.Size = new Size(25, 25);
            label8.TabIndex = 3;
            label8.Text = "a:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 18);
            label6.Name = "label6";
            label6.Size = new Size(114, 32);
            label6.TabIndex = 2;
            label6.Text = "f(x)=x^a";
            // 
            // lblPow
            // 
            lblPow.AutoSize = true;
            lblPow.Location = new Point(384, 99);
            lblPow.Name = "lblPow";
            lblPow.Size = new Size(22, 25);
            lblPow.TabIndex = 1;
            lblPow.Text = "2";
            // 
            // tbPow
            // 
            tbPow.Location = new Point(12, 99);
            tbPow.Name = "tbPow";
            tbPow.Size = new Size(366, 69);
            tbPow.TabIndex = 0;
            tbPow.TickStyle = TickStyle.TopLeft;
            tbPow.Value = 2;
            tbPow.Scroll += tbPowOffset_Scroll;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = SystemColors.ControlText;
            tabPage3.Controls.Add(tbSquareFunParamC);
            tabPage3.Controls.Add(tbSquareFunParamB);
            tabPage3.Controls.Add(lblSquareFunParamC);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(lblSquareFunParamB);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(lblSquareFunParamA);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(tbSquareFunParamA);
            tabPage3.Location = new Point(4, 37);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(466, 720);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Funkcja kwadratowa";
            // 
            // tbSquareFunParamC
            // 
            tbSquareFunParamC.Location = new Point(12, 342);
            tbSquareFunParamC.Maximum = 5;
            tbSquareFunParamC.Minimum = -5;
            tbSquareFunParamC.Name = "tbSquareFunParamC";
            tbSquareFunParamC.Size = new Size(368, 69);
            tbSquareFunParamC.TabIndex = 9;
            tbSquareFunParamC.Value = 2;
            tbSquareFunParamC.Scroll += tbSquareFun_Scroll;
            // 
            // tbSquareFunParamB
            // 
            tbSquareFunParamB.Location = new Point(12, 232);
            tbSquareFunParamB.Maximum = 5;
            tbSquareFunParamB.Minimum = -5;
            tbSquareFunParamB.Name = "tbSquareFunParamB";
            tbSquareFunParamB.Size = new Size(368, 69);
            tbSquareFunParamB.TabIndex = 8;
            tbSquareFunParamB.Scroll += tbSquareFun_Scroll;
            // 
            // lblSquareFunParamC
            // 
            lblSquareFunParamC.AutoSize = true;
            lblSquareFunParamC.Location = new Point(386, 342);
            lblSquareFunParamC.Name = "lblSquareFunParamC";
            lblSquareFunParamC.Size = new Size(22, 25);
            lblSquareFunParamC.TabIndex = 7;
            lblSquareFunParamC.Text = "2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 304);
            label9.Name = "label9";
            label9.Size = new Size(24, 25);
            label9.TabIndex = 6;
            label9.Text = "c:";
            // 
            // lblSquareFunParamB
            // 
            lblSquareFunParamB.AutoSize = true;
            lblSquareFunParamB.Location = new Point(386, 232);
            lblSquareFunParamB.Name = "lblSquareFunParamB";
            lblSquareFunParamB.Size = new Size(22, 25);
            lblSquareFunParamB.TabIndex = 5;
            lblSquareFunParamB.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 192);
            label7.Name = "label7";
            label7.Size = new Size(27, 25);
            label7.TabIndex = 4;
            label7.Text = "b:";
            // 
            // lblSquareFunParamA
            // 
            lblSquareFunParamA.AutoSize = true;
            lblSquareFunParamA.Location = new Point(386, 106);
            lblSquareFunParamA.Name = "lblSquareFunParamA";
            lblSquareFunParamA.Size = new Size(29, 25);
            lblSquareFunParamA.TabIndex = 3;
            lblSquareFunParamA.Text = "-1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 21);
            label5.Name = "label5";
            label5.Size = new Size(202, 32);
            label5.TabIndex = 2;
            label5.Text = "f(x)=ax^2+bx+c";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 66);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 1;
            label4.Text = "a:";
            // 
            // tbSquareFunParamA
            // 
            tbSquareFunParamA.Location = new Point(12, 106);
            tbSquareFunParamA.Minimum = -10;
            tbSquareFunParamA.Name = "tbSquareFunParamA";
            tbSquareFunParamA.Size = new Size(368, 69);
            tbSquareFunParamA.TabIndex = 0;
            tbSquareFunParamA.Value = -1;
            tbSquareFunParamA.Scroll += tbSquareFun_Scroll;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = SystemColors.ControlText;
            tabPage5.Controls.Add(btnLinearRegrSaveFile);
            tabPage5.Controls.Add(btnLinearRegRead);
            tabPage5.Controls.Add(btnLinearRegrRandom);
            tabPage5.Controls.Add(btnLinearRegRefresh);
            tabPage5.Controls.Add(tbData);
            tabPage5.Location = new Point(4, 37);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(466, 720);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Regresja liniowa";
            // 
            // btnLinearRegrSaveFile
            // 
            btnLinearRegrSaveFile.BackColor = SystemColors.Highlight;
            btnLinearRegrSaveFile.FlatStyle = FlatStyle.Flat;
            btnLinearRegrSaveFile.Location = new Point(263, 86);
            btnLinearRegrSaveFile.Name = "btnLinearRegrSaveFile";
            btnLinearRegrSaveFile.Size = new Size(197, 34);
            btnLinearRegrSaveFile.TabIndex = 4;
            btnLinearRegrSaveFile.Text = "Zapisz dane do pliku";
            btnLinearRegrSaveFile.UseVisualStyleBackColor = false;
            btnLinearRegrSaveFile.Click += btnLinearRegrSaveFile_Click;
            // 
            // btnLinearRegRead
            // 
            btnLinearRegRead.BackColor = SystemColors.Highlight;
            btnLinearRegRead.FlatStyle = FlatStyle.Flat;
            btnLinearRegRead.Location = new Point(263, 6);
            btnLinearRegRead.Name = "btnLinearRegRead";
            btnLinearRegRead.Size = new Size(197, 34);
            btnLinearRegRead.TabIndex = 3;
            btnLinearRegRead.Text = "Czytaj dane z pliku";
            btnLinearRegRead.UseVisualStyleBackColor = false;
            btnLinearRegRead.Click += btnLinearRegRead_Click;
            // 
            // btnLinearRegrRandom
            // 
            btnLinearRegrRandom.BackColor = SystemColors.Highlight;
            btnLinearRegrRandom.FlatStyle = FlatStyle.Flat;
            btnLinearRegrRandom.Location = new Point(263, 126);
            btnLinearRegrRandom.Name = "btnLinearRegrRandom";
            btnLinearRegrRandom.Size = new Size(196, 34);
            btnLinearRegrRandom.TabIndex = 2;
            btnLinearRegrRandom.Text = "Losuj dane";
            btnLinearRegrRandom.UseVisualStyleBackColor = false;
            btnLinearRegrRandom.Click += btnLinearRegrRandom_Click;
            // 
            // btnLinearRegRefresh
            // 
            btnLinearRegRefresh.BackColor = SystemColors.Highlight;
            btnLinearRegRefresh.FlatStyle = FlatStyle.Flat;
            btnLinearRegRefresh.ForeColor = SystemColors.Control;
            btnLinearRegRefresh.Location = new Point(263, 46);
            btnLinearRegRefresh.Name = "btnLinearRegRefresh";
            btnLinearRegRefresh.Size = new Size(197, 34);
            btnLinearRegRefresh.TabIndex = 1;
            btnLinearRegRefresh.Text = "Odśwież wykres";
            btnLinearRegRefresh.UseVisualStyleBackColor = false;
            btnLinearRegRefresh.Click += btnLinearRegRefresh_Click;
            // 
            // tbData
            // 
            tbData.Location = new Point(6, 6);
            tbData.Multiline = true;
            tbData.Name = "tbData";
            tbData.ScrollBars = ScrollBars.Vertical;
            tbData.Size = new Size(247, 708);
            tbData.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = SystemColors.ControlText;
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(chGrid);
            tabPage4.Controls.Add(btnLegendColor);
            tabPage4.Controls.Add(btnCoordColor);
            tabPage4.Controls.Add(btnChartColor);
            tabPage4.Controls.Add(btnBackColor);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(466, 720);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Ustawienia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 328);
            label11.Name = "label11";
            label11.Size = new Size(284, 25);
            label11.TabIndex = 7;
            label11.Text = "Ctrl + S => zapis wykresu do pliku";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 294);
            label10.Name = "label10";
            label10.Size = new Size(175, 25);
            label10.TabIndex = 6;
            label10.Text = "Skróty klawiaturowe:";
            // 
            // chGrid
            // 
            chGrid.AutoSize = true;
            chGrid.Checked = true;
            chGrid.CheckState = CheckState.Checked;
            chGrid.Location = new Point(12, 176);
            chGrid.Name = "chGrid";
            chGrid.Size = new Size(85, 29);
            chGrid.TabIndex = 5;
            chGrid.Text = "Siatka";
            chGrid.UseVisualStyleBackColor = true;
            chGrid.CheckedChanged += chGrid_CheckedChanged;
            // 
            // btnLegendColor
            // 
            btnLegendColor.BackColor = SystemColors.Highlight;
            btnLegendColor.FlatStyle = FlatStyle.Flat;
            btnLegendColor.Location = new Point(12, 136);
            btnLegendColor.Name = "btnLegendColor";
            btnLegendColor.Size = new Size(220, 34);
            btnLegendColor.TabIndex = 3;
            btnLegendColor.Text = "Kolor legendy";
            btnLegendColor.UseVisualStyleBackColor = false;
            btnLegendColor.Click += btnLegendColor_Click;
            // 
            // btnCoordColor
            // 
            btnCoordColor.BackColor = SystemColors.Highlight;
            btnCoordColor.FlatStyle = FlatStyle.Flat;
            btnCoordColor.Location = new Point(12, 96);
            btnCoordColor.Name = "btnCoordColor";
            btnCoordColor.Size = new Size(220, 34);
            btnCoordColor.TabIndex = 2;
            btnCoordColor.Text = "Kolor osi współrzędnych";
            btnCoordColor.UseVisualStyleBackColor = false;
            btnCoordColor.Click += btnCoordColor_Click;
            // 
            // btnChartColor
            // 
            btnChartColor.BackColor = SystemColors.Highlight;
            btnChartColor.FlatStyle = FlatStyle.Flat;
            btnChartColor.Location = new Point(12, 16);
            btnChartColor.Name = "btnChartColor";
            btnChartColor.Size = new Size(220, 34);
            btnChartColor.TabIndex = 1;
            btnChartColor.Text = "Kolor wykresu";
            btnChartColor.UseVisualStyleBackColor = false;
            btnChartColor.Click += btnChartColor_Click;
            // 
            // btnBackColor
            // 
            btnBackColor.BackColor = SystemColors.Highlight;
            btnBackColor.FlatStyle = FlatStyle.Flat;
            btnBackColor.Location = new Point(12, 56);
            btnBackColor.Name = "btnBackColor";
            btnBackColor.Size = new Size(220, 34);
            btnBackColor.TabIndex = 0;
            btnBackColor.Text = "Kolor tła wykresu";
            btnBackColor.UseVisualStyleBackColor = false;
            btnBackColor.Click += btnBackColor_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbtn4);
            panel2.Controls.Add(lblChartSelect);
            panel2.Controls.Add(rbtn3);
            panel2.Controls.Add(rbtn2);
            panel2.Controls.Add(rbtn1);
            panel2.Location = new Point(13, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(474, 170);
            panel2.TabIndex = 1;
            // 
            // rbtn4
            // 
            rbtn4.AutoSize = true;
            rbtn4.Location = new Point(245, 116);
            rbtn4.Name = "rbtn4";
            rbtn4.Size = new Size(163, 29);
            rbtn4.TabIndex = 7;
            rbtn4.TabStop = true;
            rbtn4.Text = "Regresja liniowa";
            rbtn4.UseVisualStyleBackColor = true;
            rbtn4.CheckedChanged += radiobuttons_CheckedChanged;
            // 
            // lblChartSelect
            // 
            lblChartSelect.AutoSize = true;
            lblChartSelect.Location = new Point(16, 11);
            lblChartSelect.Name = "lblChartSelect";
            lblChartSelect.Size = new Size(180, 25);
            lblChartSelect.TabIndex = 6;
            lblChartSelect.Text = "Wybierz typ wykresu:";
            // 
            // rbtn3
            // 
            rbtn3.AutoSize = true;
            rbtn3.Checked = true;
            rbtn3.Location = new Point(245, 11);
            rbtn3.Name = "rbtn3";
            rbtn3.Size = new Size(79, 29);
            rbtn3.TabIndex = 2;
            rbtn3.TabStop = true;
            rbtn3.Text = "Sinus";
            rbtn3.UseVisualStyleBackColor = true;
            rbtn3.CheckedChanged += radiobuttons_CheckedChanged;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Location = new Point(245, 46);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new Size(92, 29);
            rbtn2.TabIndex = 1;
            rbtn2.Text = "Potęga";
            rbtn2.UseVisualStyleBackColor = true;
            rbtn2.CheckedChanged += radiobuttons_CheckedChanged;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Location = new Point(245, 81);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new Size(197, 29);
            rbtn1.TabIndex = 0;
            rbtn1.Text = "Funkcja kwadratowa";
            rbtn1.UseVisualStyleBackColor = true;
            rbtn1.CheckedChanged += radiobuttons_CheckedChanged;
            // 
            // btnSaveChart
            // 
            btnSaveChart.BackColor = SystemColors.Highlight;
            btnSaveChart.FlatStyle = FlatStyle.Flat;
            btnSaveChart.Location = new Point(134, 951);
            btnSaveChart.Name = "btnSaveChart";
            btnSaveChart.Size = new Size(251, 34);
            btnSaveChart.TabIndex = 0;
            btnSaveChart.Text = "Zapisz wykres";
            btnSaveChart.UseVisualStyleBackColor = false;
            btnSaveChart.Click += btnSaveChart_Click;
            btnSaveChart.KeyDown += Form1_KeyDown;
            // 
            // timerSymulation
            // 
            timerSymulation.Interval = 80;
            timerSymulation.Tick += timerSinusSymulation_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(1543, 1076);
            Controls.Add(panel1);
            Controls.Add(pictureBoxIcon);
            Controls.Add(lblDebug);
            Controls.Add(btnClose);
            Controls.Add(pictureBox_chart);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox_chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbSinParamA).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSinParamB).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPow).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbSquareFunParamC).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSquareFunParamB).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSquareFunParamA).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_chart;
        private Button btnClose;
        private Label lblDebug;
        private PictureBox pictureBoxIcon;
        private Panel panel1;
        private Button btnSaveChart;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
        private RadioButton rbtn2;
        private RadioButton rbtn1;
        private Label lblChartSelect;
        private RadioButton rbtn3;
        private TrackBar tbSinParamB;
        private TrackBar tbSinParamA;
        private Label lblSinParamB;
        private Label lblSinParamA;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblPow;
        private TrackBar tbPow;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private TrackBar tbSquareFunParamA;
        private Label lblSquareFunParamA;
        private TrackBar tbSquareFunParamC;
        private TrackBar tbSquareFunParamB;
        private Label lblSquareFunParamC;
        private Label label9;
        private Label lblSquareFunParamB;
        private Label label7;
        private Label label3;
        private TabPage tabPage4;
        private Button btnBackColor;
        private ColorDialog colorDialog1;
        private Button btnChartColor;
        private Button btnCoordColor;
        private Label label6;
        private Label label8;
        private Button btnLegendColor;
        private CheckBox chGrid;
        private TabPage tabPage5;
        private RadioButton rbtn4;
        private TextBox tbData;
        private Label label11;
        private Label label10;
        private Button btnLinearRegRefresh;
        private System.Windows.Forms.Timer timerSymulation;
        private Button btnSinusSymulation;
        private Button btnLinearRegrRandom;
        private Button btnLinearRegRead;
        private Button btnLinearRegrSaveFile;
    }
}