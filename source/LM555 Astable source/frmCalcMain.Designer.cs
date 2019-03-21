namespace LM555_Freq_Calculator
{
    partial class frmCalcMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcMain));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtR1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbOhmsR1 = new System.Windows.Forms.ComboBox();
			this.cmbOhmsR2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtR2 = new System.Windows.Forms.TextBox();
			this.cmbFarads = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtC1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblHertz = new System.Windows.Forms.Label();
			this.lblMilliseconds = new System.Windows.Forms.Label();
			this.lblPercent = new System.Windows.Forms.Label();
			this.btnCalcFreq = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCalcR = new System.Windows.Forms.Button();
			this.btnCalcC = new System.Windows.Forms.Button();
			this.txtFrequency = new System.Windows.Forms.TextBox();
			this.txtDutyCycle = new System.Windows.Forms.TextBox();
			this.txtPeriod = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(38, 81);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(302, 267);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtR1
			// 
			this.txtR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtR1.Location = new System.Drawing.Point(15, 31);
			this.txtR1.Name = "txtR1";
			this.txtR1.Size = new System.Drawing.Size(58, 23);
			this.txtR1.TabIndex = 1;
			this.txtR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "R1";
			// 
			// cmbOhmsR1
			// 
			this.cmbOhmsR1.FormattingEnabled = true;
			this.cmbOhmsR1.Items.AddRange(new object[] {
            "ohms",
            "kilo ohms",
            "mega ohms"});
			this.cmbOhmsR1.Location = new System.Drawing.Point(79, 33);
			this.cmbOhmsR1.Name = "cmbOhmsR1";
			this.cmbOhmsR1.Size = new System.Drawing.Size(82, 21);
			this.cmbOhmsR1.TabIndex = 3;
			this.cmbOhmsR1.Text = "kilo ohms";
			// 
			// cmbOhmsR2
			// 
			this.cmbOhmsR2.FormattingEnabled = true;
			this.cmbOhmsR2.Items.AddRange(new object[] {
            "ohms",
            "kilo ohms",
            "mega ohms"});
			this.cmbOhmsR2.Location = new System.Drawing.Point(241, 33);
			this.cmbOhmsR2.Name = "cmbOhmsR2";
			this.cmbOhmsR2.Size = new System.Drawing.Size(82, 21);
			this.cmbOhmsR2.TabIndex = 6;
			this.cmbOhmsR2.Text = "kilo ohms";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(189, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "R2";
			// 
			// txtR2
			// 
			this.txtR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtR2.Location = new System.Drawing.Point(177, 31);
			this.txtR2.Name = "txtR2";
			this.txtR2.Size = new System.Drawing.Size(58, 23);
			this.txtR2.TabIndex = 4;
			this.txtR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cmbFarads
			// 
			this.cmbFarads.FormattingEnabled = true;
			this.cmbFarads.Items.AddRange(new object[] {
            "micro farads",
            "nano farads",
            "pico farads"});
			this.cmbFarads.Location = new System.Drawing.Point(407, 33);
			this.cmbFarads.Name = "cmbFarads";
			this.cmbFarads.Size = new System.Drawing.Size(85, 21);
			this.cmbFarads.TabIndex = 9;
			this.cmbFarads.Text = "micro farads";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(361, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "C1";
			// 
			// txtC1
			// 
			this.txtC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtC1.Location = new System.Drawing.Point(343, 31);
			this.txtC1.Name = "txtC1";
			this.txtC1.Size = new System.Drawing.Size(58, 23);
			this.txtC1.TabIndex = 7;
			this.txtC1.Text = "0.1";
			this.txtC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(140, 369);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "Duty Cycle";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(301, 369);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 17);
			this.label5.TabIndex = 14;
			this.label5.Text = "Period";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 369);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Frequency";
			// 
			// lblHertz
			// 
			this.lblHertz.AutoSize = true;
			this.lblHertz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHertz.Location = new System.Drawing.Point(92, 392);
			this.lblHertz.Name = "lblHertz";
			this.lblHertz.Size = new System.Drawing.Size(34, 17);
			this.lblHertz.TabIndex = 18;
			this.lblHertz.Text = "KHz";
			this.toolTip1.SetToolTip(this.lblHertz, "Double Click to change.");
			this.lblHertz.DoubleClick += new System.EventHandler(this.lblHertz_DoubleClick);
			// 
			// lblMilliseconds
			// 
			this.lblMilliseconds.AutoSize = true;
			this.lblMilliseconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMilliseconds.Location = new System.Drawing.Point(368, 392);
			this.lblMilliseconds.Name = "lblMilliseconds";
			this.lblMilliseconds.Size = new System.Drawing.Size(84, 17);
			this.lblMilliseconds.TabIndex = 19;
			this.lblMilliseconds.Text = "Milliseconds";
			this.toolTip1.SetToolTip(this.lblMilliseconds, "Double Click To Change");
			this.lblMilliseconds.DoubleClick += new System.EventHandler(this.lblMilliseconds_DoubleClick);
			// 
			// lblPercent
			// 
			this.lblPercent.AutoSize = true;
			this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPercent.Location = new System.Drawing.Point(219, 392);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new System.Drawing.Size(57, 17);
			this.lblPercent.TabIndex = 20;
			this.lblPercent.Text = "Percent";
			// 
			// btnCalcFreq
			// 
			this.btnCalcFreq.Location = new System.Drawing.Point(389, 130);
			this.btnCalcFreq.Name = "btnCalcFreq";
			this.btnCalcFreq.Size = new System.Drawing.Size(75, 23);
			this.btnCalcFreq.TabIndex = 21;
			this.btnCalcFreq.Text = "Calc Freq";
			this.btnCalcFreq.UseVisualStyleBackColor = true;
			this.btnCalcFreq.Click += new System.EventHandler(this.btnCalcFreq_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(389, 276);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 22;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCalcR
			// 
			this.btnCalcR.Location = new System.Drawing.Point(389, 177);
			this.btnCalcR.Name = "btnCalcR";
			this.btnCalcR.Size = new System.Drawing.Size(75, 23);
			this.btnCalcR.TabIndex = 23;
			this.btnCalcR.Text = "Calc R\'s";
			this.btnCalcR.UseVisualStyleBackColor = true;
			this.btnCalcR.Click += new System.EventHandler(this.btnCalcR_Click);
			// 
			// btnCalcC
			// 
			this.btnCalcC.Location = new System.Drawing.Point(389, 226);
			this.btnCalcC.Name = "btnCalcC";
			this.btnCalcC.Size = new System.Drawing.Size(75, 23);
			this.btnCalcC.TabIndex = 24;
			this.btnCalcC.Text = "Calc C";
			this.btnCalcC.UseVisualStyleBackColor = true;
			this.btnCalcC.Click += new System.EventHandler(this.btnCalcC_Click);
			// 
			// txtFrequency
			// 
			this.txtFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFrequency.Location = new System.Drawing.Point(15, 389);
			this.txtFrequency.Name = "txtFrequency";
			this.txtFrequency.Size = new System.Drawing.Size(72, 23);
			this.txtFrequency.TabIndex = 25;
			this.txtFrequency.Text = "100";
			this.txtFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDutyCycle
			// 
			this.txtDutyCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDutyCycle.Location = new System.Drawing.Point(143, 389);
			this.txtDutyCycle.Name = "txtDutyCycle";
			this.txtDutyCycle.Size = new System.Drawing.Size(70, 23);
			this.txtDutyCycle.TabIndex = 26;
			this.txtDutyCycle.Text = "50.5";
			this.txtDutyCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtPeriod
			// 
			this.txtPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPeriod.Location = new System.Drawing.Point(296, 389);
			this.txtPeriod.Name = "txtPeriod";
			this.txtPeriod.Size = new System.Drawing.Size(66, 23);
			this.txtPeriod.TabIndex = 27;
			this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(205, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(113, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "LM555 Astable MV";
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 5000;
			this.toolTip1.InitialDelay = 250;
			this.toolTip1.ReshowDelay = 100;
			// 
			// frmCalcMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 440);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtPeriod);
			this.Controls.Add(this.txtDutyCycle);
			this.Controls.Add(this.txtFrequency);
			this.Controls.Add(this.btnCalcC);
			this.Controls.Add(this.btnCalcR);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCalcFreq);
			this.Controls.Add(this.lblPercent);
			this.Controls.Add(this.lblMilliseconds);
			this.Controls.Add(this.lblHertz);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cmbFarads);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtC1);
			this.Controls.Add(this.cmbOhmsR2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtR2);
			this.Controls.Add(this.cmbOhmsR1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtR1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmCalcMain";
			this.Text = "LM555 Frequency Calculator";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOhmsR1;
        private System.Windows.Forms.ComboBox cmbOhmsR2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.ComboBox cmbFarads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHertz;
        private System.Windows.Forms.Label lblMilliseconds;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Button btnCalcFreq;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalcR;
        private System.Windows.Forms.Button btnCalcC;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.TextBox txtDutyCycle;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

