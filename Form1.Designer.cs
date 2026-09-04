namespace Calculator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtShowResult = new System.Windows.Forms.TextBox();
            this.gpControls = new System.Windows.Forms.GroupBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbMult = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnEqule = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ListLastCalcullations = new System.Windows.Forms.ListView();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.BtnRemoveIndex = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCalculations = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gpControls.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Any thing here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lblTotalCalculations);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(343, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numbers/Convret....";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearAllToolStripMenuItem.Text = "Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtShowResult
            // 
            this.txtShowResult.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtShowResult.Location = new System.Drawing.Point(54, 19);
            this.txtShowResult.Multiline = true;
            this.txtShowResult.Name = "txtShowResult";
            this.txtShowResult.ReadOnly = true;
            this.txtShowResult.Size = new System.Drawing.Size(527, 73);
            this.txtShowResult.TabIndex = 30;
            // 
            // gpControls
            // 
            this.gpControls.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpControls.Controls.Add(this.label5);
            this.gpControls.Controls.Add(this.numericUpDown1);
            this.gpControls.Controls.Add(this.BtnRemoveIndex);
            this.gpControls.Controls.Add(this.panel2);
            this.gpControls.Controls.Add(this.btn3);
            this.gpControls.Controls.Add(this.txtShowResult);
            this.gpControls.Controls.Add(this.btnClear);
            this.gpControls.Controls.Add(this.rbDiv);
            this.gpControls.Controls.Add(this.rbMult);
            this.gpControls.Controls.Add(this.rbSub);
            this.gpControls.Controls.Add(this.rbSum);
            this.gpControls.Controls.Add(this.btn6);
            this.gpControls.Controls.Add(this.btn5);
            this.gpControls.Controls.Add(this.btn4);
            this.gpControls.Controls.Add(this.btn9);
            this.gpControls.Controls.Add(this.btn8);
            this.gpControls.Controls.Add(this.btn7);
            this.gpControls.Controls.Add(this.btnEqule);
            this.gpControls.Controls.Add(this.btnComa);
            this.gpControls.Controls.Add(this.btn0);
            this.gpControls.Controls.Add(this.btn2);
            this.gpControls.Controls.Add(this.btn1);
            this.gpControls.Location = new System.Drawing.Point(0, 100);
            this.gpControls.Name = "gpControls";
            this.gpControls.Size = new System.Drawing.Size(976, 519);
            this.gpControls.TabIndex = 3;
            this.gpControls.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn3.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn3.Location = new System.Drawing.Point(348, 255);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(113, 43);
            this.btn3.TabIndex = 8;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClear.Location = new System.Drawing.Point(474, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 43);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbDiv.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rbDiv.ForeColor = System.Drawing.Color.White;
            this.rbDiv.Location = new System.Drawing.Point(545, 188);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(36, 28);
            this.rbDiv.TabIndex = 32;
            this.rbDiv.TabStop = true;
            this.rbDiv.Tag = "/";
            this.rbDiv.Text = "/";
            this.rbDiv.UseVisualStyleBackColor = false;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMult
            // 
            this.rbMult.AutoSize = true;
            this.rbMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbMult.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rbMult.ForeColor = System.Drawing.Color.White;
            this.rbMult.Location = new System.Drawing.Point(477, 188);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(40, 28);
            this.rbMult.TabIndex = 31;
            this.rbMult.TabStop = true;
            this.rbMult.Tag = "X";
            this.rbMult.Text = "X";
            this.rbMult.UseVisualStyleBackColor = false;
            this.rbMult.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbSub.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rbSub.ForeColor = System.Drawing.Color.White;
            this.rbSub.Location = new System.Drawing.Point(546, 262);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(35, 28);
            this.rbSub.TabIndex = 34;
            this.rbSub.TabStop = true;
            this.rbSub.Tag = "-";
            this.rbSub.Text = "-";
            this.rbSub.UseVisualStyleBackColor = false;
            this.rbSub.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbSum.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rbSum.ForeColor = System.Drawing.Color.White;
            this.rbSum.Location = new System.Drawing.Point(474, 262);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(43, 28);
            this.rbSum.TabIndex = 33;
            this.rbSum.TabStop = true;
            this.rbSum.Tag = "+";
            this.rbSum.Text = "+";
            this.rbSum.UseVisualStyleBackColor = false;
            this.rbSum.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Cyan;
            this.btn6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn6.Location = new System.Drawing.Point(348, 181);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(113, 43);
            this.btn6.TabIndex = 5;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Cyan;
            this.btn5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn5.Location = new System.Drawing.Point(200, 181);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(113, 43);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Cyan;
            this.btn4.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn4.Location = new System.Drawing.Point(54, 181);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(113, 43);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn9.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn9.Location = new System.Drawing.Point(348, 109);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(113, 43);
            this.btn9.TabIndex = 2;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Cyan;
            this.btn8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn8.Location = new System.Drawing.Point(200, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(113, 43);
            this.btn8.TabIndex = 1;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Cyan;
            this.btn7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn7.Location = new System.Drawing.Point(54, 109);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(113, 43);
            this.btn7.TabIndex = 0;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEqule
            // 
            this.btnEqule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEqule.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEqule.Location = new System.Drawing.Point(348, 327);
            this.btnEqule.Name = "btnEqule";
            this.btnEqule.Size = new System.Drawing.Size(113, 43);
            this.btnEqule.TabIndex = 11;
            this.btnEqule.Text = "=";
            this.btnEqule.UseVisualStyleBackColor = false;
            this.btnEqule.Click += new System.EventHandler(this.btnEqule_Click);
            // 
            // btnComa
            // 
            this.btnComa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnComa.Font = new System.Drawing.Font("Tahoma", 17F);
            this.btnComa.Location = new System.Drawing.Point(54, 327);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(113, 43);
            this.btnComa.TabIndex = 9;
            this.btnComa.Tag = ".";
            this.btnComa.Text = ".";
            this.btnComa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComa.UseVisualStyleBackColor = false;
            this.btnComa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn0.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn0.Location = new System.Drawing.Point(200, 327);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(113, 43);
            this.btn0.TabIndex = 10;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn2.Location = new System.Drawing.Point(200, 255);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(113, 43);
            this.btn2.TabIndex = 7;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Cyan;
            this.btn1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btn1.Location = new System.Drawing.Point(54, 255);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 43);
            this.btn1.TabIndex = 6;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnClearHistory);
            this.panel2.Controls.Add(this.ListLastCalcullations);
            this.panel2.Location = new System.Drawing.Point(593, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 506);
            this.panel2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 35F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(669, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 57);
            this.label3.TabIndex = 3;
            this.label3.Text = "History";
            // 
            // ListLastCalcullations
            // 
            this.ListLastCalcullations.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ListLastCalcullations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListLastCalcullations.HideSelection = false;
            this.ListLastCalcullations.Location = new System.Drawing.Point(3, 3);
            this.ListLastCalcullations.Name = "ListLastCalcullations";
            this.ListLastCalcullations.Size = new System.Drawing.Size(371, 448);
            this.ListLastCalcullations.TabIndex = 0;
            this.ListLastCalcullations.UseCompatibleStateImageBehavior = false;
            this.ListLastCalcullations.View = System.Windows.Forms.View.Tile;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearHistory.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClearHistory.Location = new System.Drawing.Point(86, 457);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(205, 43);
            this.btnClearHistory.TabIndex = 14;
            this.btnClearHistory.Tag = "3";
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // BtnRemoveIndex
            // 
            this.BtnRemoveIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRemoveIndex.Font = new System.Drawing.Font("Tahoma", 14F);
            this.BtnRemoveIndex.Location = new System.Drawing.Point(477, 109);
            this.BtnRemoveIndex.Name = "BtnRemoveIndex";
            this.BtnRemoveIndex.Size = new System.Drawing.Size(113, 43);
            this.BtnRemoveIndex.TabIndex = 12;
            this.BtnRemoveIndex.Tag = "6";
            this.BtnRemoveIndex.Text = "X";
            this.BtnRemoveIndex.UseVisualStyleBackColor = false;
            this.BtnRemoveIndex.Click += new System.EventHandler(this.BtnRemoveIndex_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 17F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(835, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total  : ";
            // 
            // lblTotalCalculations
            // 
            this.lblTotalCalculations.AutoSize = true;
            this.lblTotalCalculations.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblTotalCalculations.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalCalculations.Location = new System.Drawing.Point(921, 68);
            this.lblTotalCalculations.Name = "lblTotalCalculations";
            this.lblTotalCalculations.Size = new System.Drawing.Size(30, 33);
            this.lblTotalCalculations.TabIndex = 5;
            this.lblTotalCalculations.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.numericUpDown1.Location = new System.Drawing.Point(200, 399);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(261, 32);
            this.numericUpDown1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(50, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Result Format :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 621);
            this.Controls.Add(this.gpControls);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpControls.ResumeLayout(false);
            this.gpControls.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShowResult;
        private System.Windows.Forms.GroupBox gpControls;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnEqule;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ListLastCalcullations;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button BtnRemoveIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCalculations;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

