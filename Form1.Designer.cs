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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button7 = new System.Windows.Forms.Button();
            this.btnEqule = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(127, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate Any thing here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(265, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numbers/Convret....";
            // 
            // txtShowResult
            // 
            this.txtShowResult.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtShowResult.Location = new System.Drawing.Point(54, 19);
            this.txtShowResult.Multiline = true;
            this.txtShowResult.Name = "txtShowResult";
            this.txtShowResult.ReadOnly = true;
            this.txtShowResult.Size = new System.Drawing.Size(527, 73);
            this.txtShowResult.TabIndex = 25;
            // 
            // gpControls
            // 
            this.gpControls.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.gpControls.Controls.Add(this.button7);
            this.gpControls.Controls.Add(this.btnEqule);
            this.gpControls.Controls.Add(this.btnComa);
            this.gpControls.Controls.Add(this.btn0);
            this.gpControls.Controls.Add(this.btn2);
            this.gpControls.Controls.Add(this.btn1);
            this.gpControls.Location = new System.Drawing.Point(0, 100);
            this.gpControls.Name = "gpControls";
            this.gpControls.Size = new System.Drawing.Size(625, 519);
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
            this.btn3.TabIndex = 18;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnClear.Location = new System.Drawing.Point(474, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 43);
            this.btnClear.TabIndex = 16;
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
            this.rbDiv.Location = new System.Drawing.Point(546, 120);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(36, 28);
            this.rbDiv.TabIndex = 15;
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
            this.rbMult.Location = new System.Drawing.Point(481, 120);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(40, 28);
            this.rbMult.TabIndex = 14;
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
            this.rbSub.Location = new System.Drawing.Point(546, 181);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(35, 28);
            this.rbSub.TabIndex = 13;
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
            this.rbSum.Location = new System.Drawing.Point(481, 181);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(43, 28);
            this.rbSum.TabIndex = 12;
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
            this.btn6.TabIndex = 11;
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
            this.btn5.TabIndex = 10;
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
            this.btn4.TabIndex = 9;
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
            this.btn9.TabIndex = 8;
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
            this.btn8.TabIndex = 7;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cyan;
            this.button7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button7.Location = new System.Drawing.Point(54, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 43);
            this.button7.TabIndex = 6;
            this.button7.Tag = "7";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEqule
            // 
            this.btnEqule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEqule.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEqule.Location = new System.Drawing.Point(348, 327);
            this.btnEqule.Name = "btnEqule";
            this.btnEqule.Size = new System.Drawing.Size(113, 43);
            this.btnEqule.TabIndex = 5;
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
            this.btnComa.TabIndex = 4;
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
            this.btn0.TabIndex = 3;
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
            this.btn2.TabIndex = 1;
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
            this.btn1.TabIndex = 0;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 621);
            this.Controls.Add(this.gpControls);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpControls.ResumeLayout(false);
            this.gpControls.PerformLayout();
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnEqule;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn3;
    }
}

