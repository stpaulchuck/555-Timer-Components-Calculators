namespace LM555_Monostable
{
    partial class frmCalcMonoMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcMonoMain));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.lblMilliseconds = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPeriod = new System.Windows.Forms.TextBox();
			this.btnCalcC = new System.Windows.Forms.Button();
			this.btnCalcR = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbFarads = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtC1 = new System.Windows.Forms.TextBox();
			this.cmbOhmsR1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtR1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCalcPeriod = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.InitialDelay = 250;
			this.toolTip1.ReshowDelay = 100;
			// 
			// lblMilliseconds
			// 
			this.lblMilliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMilliseconds.Location = new System.Drawing.Point(394, 392);
			this.lblMilliseconds.Name = "lblMilliseconds";
			this.lblMilliseconds.Size = new System.Drawing.Size(76, 15);
			this.lblMilliseconds.TabIndex = 43;
			this.lblMilliseconds.Text = "Milliseconds";
			this.lblMilliseconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.lblMilliseconds, "Double Click to change.");
			this.lblMilliseconds.Click += new System.EventHandler(this.lblMilliseconds_Click);
			this.lblMilliseconds.DoubleClick += new System.EventHandler(this.lblMilliseconds_DoubleClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(139, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 13);
			this.label7.TabIndex = 52;
			this.label7.Text = "LM555 Monostable MV";
			// 
			// txtPeriod
			// 
			this.txtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPeriod.Location = new System.Drawing.Point(392, 368);
			this.txtPeriod.Name = "txtPeriod";
			this.txtPeriod.Size = new System.Drawing.Size(75, 21);
			this.txtPeriod.TabIndex = 51;
			this.txtPeriod.Text = "100";
			this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCalcC
			// 
			this.btnCalcC.Location = new System.Drawing.Point(392, 200);
			this.btnCalcC.Name = "btnCalcC";
			this.btnCalcC.Size = new System.Drawing.Size(75, 23);
			this.btnCalcC.TabIndex = 48;
			this.btnCalcC.Text = "Calc C";
			this.btnCalcC.UseVisualStyleBackColor = true;
			this.btnCalcC.Click += new System.EventHandler(this.btnCalcC_Click);
			// 
			// btnCalcR
			// 
			this.btnCalcR.Location = new System.Drawing.Point(392, 151);
			this.btnCalcR.Name = "btnCalcR";
			this.btnCalcR.Size = new System.Drawing.Size(75, 23);
			this.btnCalcR.TabIndex = 47;
			this.btnCalcR.Text = "Calc R";
			this.btnCalcR.UseVisualStyleBackColor = true;
			this.btnCalcR.Click += new System.EventHandler(this.btnCalcR_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(392, 250);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 46;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(409, 348);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 15);
			this.label5.TabIndex = 40;
			this.label5.Text = "Period";
			// 
			// cmbFarads
			// 
			this.cmbFarads.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbFarads.FormattingEnabled = true;
			this.cmbFarads.Items.AddRange(new object[] {
            "micro farads",
            "nano farads",
            "pico farads"});
			this.cmbFarads.Location = new System.Drawing.Point(269, 368);
			this.cmbFarads.Name = "cmbFarads";
			this.cmbFarads.Size = new System.Drawing.Size(95, 23);
			this.cmbFarads.TabIndex = 38;
			this.cmbFarads.Text = "micro farads";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(223, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 37;
			this.label3.Text = "C1";
			// 
			// txtC1
			// 
			this.txtC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtC1.Location = new System.Drawing.Point(205, 368);
			this.txtC1.Name = "txtC1";
			this.txtC1.Size = new System.Drawing.Size(58, 21);
			this.txtC1.TabIndex = 36;
			this.txtC1.Text = "1";
			this.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbOhmsR1
			// 
			this.cmbOhmsR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOhmsR1.FormattingEnabled = true;
			this.cmbOhmsR1.Items.AddRange(new object[] {
            "ohms",
            "kilo ohms",
            "mega ohms"});
			this.cmbOhmsR1.Location = new System.Drawing.Point(88, 368);
			this.cmbOhmsR1.Name = "cmbOhmsR1";
			this.cmbOhmsR1.Size = new System.Drawing.Size(90, 23);
			this.cmbOhmsR1.TabIndex = 32;
			this.cmbOhmsR1.Text = "kilo ohms";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 348);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(23, 15);
			this.label1.TabIndex = 31;
			this.label1.Text = "R1";
			// 
			// txtR1
			// 
			this.txtR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtR1.Location = new System.Drawing.Point(24, 368);
			this.txtR1.Name = "txtR1";
			this.txtR1.Size = new System.Drawing.Size(58, 21);
			this.txtR1.TabIndex = 30;
			this.txtR1.Text = "1";
			this.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(48, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(302, 267);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 53;
			this.pictureBox1.TabStop = false;
			// 
			// btnCalcPeriod
			// 
			this.btnCalcPeriod.Location = new System.Drawing.Point(392, 100);
			this.btnCalcPeriod.Name = "btnCalcPeriod";
			this.btnCalcPeriod.Size = new System.Drawing.Size(75, 23);
			this.btnCalcPeriod.TabIndex = 54;
			this.btnCalcPeriod.Text = "Calc Period";
			this.btnCalcPeriod.UseVisualStyleBackColor = true;
			this.btnCalcPeriod.Click += new System.EventHandler(this.btnCalcPeriod_Click);
			// 
			// frmCalcMonoMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 443);
			this.Controls.Add(this.btnCalcPeriod);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPeriod);
			this.Controls.Add(this.btnCalcC);
			this.Controls.Add(this.btnCalcR);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblMilliseconds);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmbFarads);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtC1);
			this.Controls.Add(this.cmbOhmsR1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtR1);
			this.Name = "frmCalcMonoMain";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMilliseconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Button btnCalcC;
        private System.Windows.Forms.Button btnCalcR;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFarads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.ComboBox cmbOhmsR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcPeriod;
    }
}

