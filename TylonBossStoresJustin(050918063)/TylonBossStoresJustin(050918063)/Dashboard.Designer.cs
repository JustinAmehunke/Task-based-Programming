namespace TylonBossStores
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTsi = new System.Windows.Forms.ComboBox();
            this.cbTst = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbYTs = new System.Windows.Forms.ComboBox();
            this.cbYMs = new System.Windows.Forms.ComboBox();
            this.cbYWs = new System.Windows.Forms.ComboBox();
            this.cbM = new System.Windows.Forms.ComboBox();
            this.cbMst = new System.Windows.Forms.ComboBox();
            this.cbWst = new System.Windows.Forms.ComboBox();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.cbW = new System.Windows.Forms.ComboBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTsiY = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtMaT = new System.Windows.Forms.TextBox();
            this.txtWaT = new System.Windows.Forms.TextBox();
            this.txtAsaT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtMbT = new System.Windows.Forms.TextBox();
            this.txtWbT = new System.Windows.Forms.TextBox();
            this.txtAsbT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtMTa = new System.Windows.Forms.TextBox();
            this.txtWTa = new System.Windows.Forms.TextBox();
            this.txtAsTa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnViewStores = new System.Windows.Forms.Button();
            this.dgV = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dgdV = new System.Windows.Forms.DataGridView();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTimer = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Top Sold Item:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Sales:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Weekly Sales:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Monthly Sales:";
            // 
            // cbTsi
            // 
            this.cbTsi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTsi.FormattingEnabled = true;
            this.cbTsi.Location = new System.Drawing.Point(5, 40);
            this.cbTsi.Name = "cbTsi";
            this.cbTsi.Size = new System.Drawing.Size(97, 27);
            this.cbTsi.TabIndex = 8;
            this.cbTsi.Text = "Select Store";
            this.cbTsi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbTst
            // 
            this.cbTst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTst.FormattingEnabled = true;
            this.cbTst.Items.AddRange(new object[] {
            "All Stores"});
            this.cbTst.Location = new System.Drawing.Point(179, 28);
            this.cbTst.Name = "cbTst";
            this.cbTst.Size = new System.Drawing.Size(218, 27);
            this.cbTst.TabIndex = 9;
            this.cbTst.Text = "Select Store";
            this.cbTst.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbYTs);
            this.panel2.Controls.Add(this.cbYMs);
            this.panel2.Controls.Add(this.cbYWs);
            this.panel2.Controls.Add(this.cbM);
            this.panel2.Controls.Add(this.cbMst);
            this.panel2.Controls.Add(this.cbWst);
            this.panel2.Controls.Add(this.btnMonthly);
            this.panel2.Controls.Add(this.btnWeekly);
            this.panel2.Controls.Add(this.btnAll);
            this.panel2.Controls.Add(this.cbW);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbTst);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 178);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbYTs
            // 
            this.cbYTs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYTs.FormattingEnabled = true;
            this.cbYTs.Items.AddRange(new object[] {
            "2013",
            "2014"});
            this.cbYTs.Location = new System.Drawing.Point(403, 29);
            this.cbYTs.Name = "cbYTs";
            this.cbYTs.Size = new System.Drawing.Size(96, 27);
            this.cbYTs.TabIndex = 20;
            this.cbYTs.Text = "Select Year";
            // 
            // cbYMs
            // 
            this.cbYMs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYMs.FormattingEnabled = true;
            this.cbYMs.Items.AddRange(new object[] {
            "2013",
            "2014"});
            this.cbYMs.Location = new System.Drawing.Point(403, 133);
            this.cbYMs.Name = "cbYMs";
            this.cbYMs.Size = new System.Drawing.Size(96, 27);
            this.cbYMs.TabIndex = 19;
            this.cbYMs.Text = "Select Year";
            // 
            // cbYWs
            // 
            this.cbYWs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYWs.FormattingEnabled = true;
            this.cbYWs.Items.AddRange(new object[] {
            "2013",
            "2014"});
            this.cbYWs.Location = new System.Drawing.Point(403, 81);
            this.cbYWs.Name = "cbYWs";
            this.cbYWs.Size = new System.Drawing.Size(96, 27);
            this.cbYWs.TabIndex = 18;
            this.cbYWs.Text = "Select Year";
            // 
            // cbM
            // 
            this.cbM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbM.FormattingEnabled = true;
            this.cbM.Items.AddRange(new object[] {
            "Month01",
            "Month02",
            "Month03",
            "Month04",
            "Month05",
            "Month06",
            "Month07",
            "Month08",
            "Month09",
            "Month10",
            "Month11",
            "Month12",
            "Month13"});
            this.cbM.Location = new System.Drawing.Point(291, 133);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(106, 27);
            this.cbM.TabIndex = 11;
            this.cbM.Text = "Select Month";
            this.cbM.SelectedIndexChanged += new System.EventHandler(this.cbM_SelectedIndexChanged);
            // 
            // cbMst
            // 
            this.cbMst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMst.FormattingEnabled = true;
            this.cbMst.Items.AddRange(new object[] {
            "All Stores"});
            this.cbMst.Location = new System.Drawing.Point(179, 133);
            this.cbMst.Name = "cbMst";
            this.cbMst.Size = new System.Drawing.Size(106, 27);
            this.cbMst.TabIndex = 17;
            this.cbMst.Text = "Select Store";
            // 
            // cbWst
            // 
            this.cbWst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWst.FormattingEnabled = true;
            this.cbWst.Items.AddRange(new object[] {
            "All Stores"});
            this.cbWst.Location = new System.Drawing.Point(179, 81);
            this.cbWst.Name = "cbWst";
            this.cbWst.Size = new System.Drawing.Size(106, 27);
            this.cbWst.TabIndex = 16;
            this.cbWst.Text = "Select Store";
            // 
            // btnMonthly
            // 
            this.btnMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthly.Location = new System.Drawing.Point(517, 133);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(75, 29);
            this.btnMonthly.TabIndex = 15;
            this.btnMonthly.Text = "Calculate";
            this.btnMonthly.UseVisualStyleBackColor = false;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnWeekly
            // 
            this.btnWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekly.Location = new System.Drawing.Point(517, 81);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(75, 30);
            this.btnWeekly.TabIndex = 14;
            this.btnWeekly.Text = "Calculate";
            this.btnWeekly.UseVisualStyleBackColor = false;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(517, 28);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 29);
            this.btnAll.TabIndex = 13;
            this.btnAll.Text = "Calculate";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbW
            // 
            this.cbW.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbW.FormattingEnabled = true;
            this.cbW.Location = new System.Drawing.Point(291, 82);
            this.cbW.Name = "cbW";
            this.cbW.Size = new System.Drawing.Size(106, 27);
            this.cbW.TabIndex = 10;
            this.cbW.Text = "Select Week";
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(5, 85);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 29);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbTsiY);
            this.panel3.Controls.Add(this.cbTsi);
            this.panel3.Controls.Add(this.btnGet);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 272);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 129);
            this.panel3.TabIndex = 11;
            // 
            // cbTsiY
            // 
            this.cbTsiY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTsiY.FormattingEnabled = true;
            this.cbTsiY.Items.AddRange(new object[] {
            "2013",
            "2014"});
            this.cbTsiY.Location = new System.Drawing.Point(106, 40);
            this.cbTsiY.Name = "cbTsiY";
            this.cbTsiY.Size = new System.Drawing.Size(97, 27);
            this.cbTsiY.TabIndex = 13;
            this.cbTsiY.Text = "Select Year";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(607, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 190);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.panel6.Controls.Add(this.txtMaT);
            this.panel6.Controls.Add(this.txtWaT);
            this.panel6.Controls.Add(this.txtAsaT);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(163, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 184);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txtMaT
            // 
            this.txtMaT.Enabled = false;
            this.txtMaT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaT.Location = new System.Drawing.Point(2, 141);
            this.txtMaT.Multiline = true;
            this.txtMaT.Name = "txtMaT";
            this.txtMaT.Size = new System.Drawing.Size(148, 26);
            this.txtMaT.TabIndex = 24;
            // 
            // txtWaT
            // 
            this.txtWaT.Enabled = false;
            this.txtWaT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWaT.Location = new System.Drawing.Point(2, 89);
            this.txtWaT.Multiline = true;
            this.txtWaT.Name = "txtWaT";
            this.txtWaT.Size = new System.Drawing.Size(148, 26);
            this.txtWaT.TabIndex = 23;
            // 
            // txtAsaT
            // 
            this.txtAsaT.Enabled = false;
            this.txtAsaT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsaT.Location = new System.Drawing.Point(3, 35);
            this.txtAsaT.Multiline = true;
            this.txtAsaT.Name = "txtAsaT";
            this.txtAsaT.Size = new System.Drawing.Size(147, 26);
            this.txtAsaT.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(33, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "After Tax:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.panel5.Controls.Add(this.txtMbT);
            this.panel5.Controls.Add(this.txtWbT);
            this.panel5.Controls.Add(this.txtAsbT);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(154, 184);
            this.panel5.TabIndex = 0;
            // 
            // txtMbT
            // 
            this.txtMbT.Enabled = false;
            this.txtMbT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMbT.Location = new System.Drawing.Point(-3, 142);
            this.txtMbT.Multiline = true;
            this.txtMbT.Name = "txtMbT";
            this.txtMbT.Size = new System.Drawing.Size(154, 26);
            this.txtMbT.TabIndex = 21;
            // 
            // txtWbT
            // 
            this.txtWbT.Enabled = false;
            this.txtWbT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWbT.Location = new System.Drawing.Point(-3, 90);
            this.txtWbT.Multiline = true;
            this.txtWbT.Name = "txtWbT";
            this.txtWbT.Size = new System.Drawing.Size(154, 26);
            this.txtWbT.TabIndex = 20;
            // 
            // txtAsbT
            // 
            this.txtAsbT.Enabled = false;
            this.txtAsbT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsbT.Location = new System.Drawing.Point(0, 34);
            this.txtAsbT.Multiline = true;
            this.txtAsbT.Name = "txtAsbT";
            this.txtAsbT.Size = new System.Drawing.Size(151, 26);
            this.txtAsbT.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(27, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Before Tax:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(939, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = " 17% VAT ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(939, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "1% NHIL";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(934, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "2% Sales Tax";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(934, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Taxe Rates:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(80, 75);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 29);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(11, 110);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(209, 26);
            this.txtPath.TabIndex = 21;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(12, 443);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1201, 204);
            this.panel7.TabIndex = 24;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.panel8.Controls.Add(this.txtMTa);
            this.panel8.Controls.Add(this.txtWTa);
            this.panel8.Controls.Add(this.txtAsTa);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(1049, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(147, 184);
            this.panel8.TabIndex = 14;
            // 
            // txtMTa
            // 
            this.txtMTa.Enabled = false;
            this.txtMTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTa.Location = new System.Drawing.Point(3, 141);
            this.txtMTa.Multiline = true;
            this.txtMTa.Name = "txtMTa";
            this.txtMTa.Size = new System.Drawing.Size(144, 26);
            this.txtMTa.TabIndex = 24;
            // 
            // txtWTa
            // 
            this.txtWTa.Enabled = false;
            this.txtWTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWTa.Location = new System.Drawing.Point(3, 89);
            this.txtWTa.Multiline = true;
            this.txtWTa.Name = "txtWTa";
            this.txtWTa.Size = new System.Drawing.Size(144, 26);
            this.txtWTa.TabIndex = 23;
            // 
            // txtAsTa
            // 
            this.txtAsTa.Enabled = false;
            this.txtAsTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsTa.Location = new System.Drawing.Point(3, 35);
            this.txtAsTa.Multiline = true;
            this.txtAsTa.Name = "txtAsTa";
            this.txtAsTa.Size = new System.Drawing.Size(144, 26);
            this.txtAsTa.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(33, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 25);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tax Amouts:";
            // 
            // btnViewStores
            // 
            this.btnViewStores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(147)))));
            this.btnViewStores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStores.Location = new System.Drawing.Point(57, 155);
            this.btnViewStores.Name = "btnViewStores";
            this.btnViewStores.Size = new System.Drawing.Size(116, 29);
            this.btnViewStores.TabIndex = 25;
            this.btnViewStores.Text = "View  Stores";
            this.btnViewStores.UseVisualStyleBackColor = false;
            this.btnViewStores.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgV
            // 
            this.dgV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV.Location = new System.Drawing.Point(3, 0);
            this.dgV.Name = "dgV";
            this.dgV.Size = new System.Drawing.Size(258, 369);
            this.dgV.TabIndex = 27;
            this.dgV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgV_CellContentClick);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dgdV);
            this.panel9.Controls.Add(this.chartControl);
            this.panel9.Controls.Add(this.dgV);
            this.panel9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel9.Location = new System.Drawing.Point(231, 54);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(995, 372);
            this.panel9.TabIndex = 28;
            // 
            // dgdV
            // 
            this.dgdV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdV.Location = new System.Drawing.Point(3, 0);
            this.dgdV.Name = "dgdV";
            this.dgdV.Size = new System.Drawing.Size(157, 369);
            this.dgdV.TabIndex = 30;
            this.dgdV.Visible = false;
            // 
            // chartControl
            // 
            chartArea1.Name = "ChartArea1";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(287, 3);
            this.chartControl.Name = "chartControl";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartControl.Series.Add(series1);
            this.chartControl.Size = new System.Drawing.Size(703, 364);
            this.chartControl.TabIndex = 29;
            this.chartControl.Text = "chart1";
            title1.Name = "Title1";
            this.chartControl.Titles.Add(title1);
            this.chartControl.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimer.Location = new System.Drawing.Point(804, 424);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(193, 16);
            this.lblTimer.TabIndex = 29;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(50)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1238, 654);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btnViewStores);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.Controls.SetChildIndex(this.txtPath, 0);
            this.Controls.SetChildIndex(this.panel7, 0);
            this.Controls.SetChildIndex(this.btnViewStores, 0);
            this.Controls.SetChildIndex(this.panel9, 0);
            this.Controls.SetChildIndex(this.lblTimer, 0);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTsi;
        private System.Windows.Forms.ComboBox cbTst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbM;
        private System.Windows.Forms.ComboBox cbW;
        private System.Windows.Forms.ComboBox cbMst;
        private System.Windows.Forms.ComboBox cbWst;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtMaT;
        private System.Windows.Forms.TextBox txtWaT;
        private System.Windows.Forms.TextBox txtAsaT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtMbT;
        private System.Windows.Forms.TextBox txtWbT;
        private System.Windows.Forms.TextBox txtAsbT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtMTa;
        private System.Windows.Forms.TextBox txtWTa;
        private System.Windows.Forms.TextBox txtAsTa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnViewStores;
        private System.Windows.Forms.DataGridView dgV;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ComboBox cbYTs;
        private System.Windows.Forms.ComboBox cbYMs;
        private System.Windows.Forms.ComboBox cbYWs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbTsiY;
        private System.Windows.Forms.DataGridView dgdV;
    }
}