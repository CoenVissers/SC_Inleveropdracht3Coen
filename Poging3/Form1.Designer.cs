namespace Poging3
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
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudLhsl = new System.Windows.Forms.NumericUpDown();
            this.nudShsl = new System.Windows.Forms.NumericUpDown();
            this.nudHhsl = new System.Windows.Forms.NumericUpDown();
            this.trbLhsl = new System.Windows.Forms.TrackBar();
            this.trbShsl = new System.Windows.Forms.TrackBar();
            this.trbHhsl = new System.Windows.Forms.TrackBar();
            this.nudVhsv = new System.Windows.Forms.NumericUpDown();
            this.nudShsv = new System.Windows.Forms.NumericUpDown();
            this.nudHhsv = new System.Windows.Forms.NumericUpDown();
            this.trbVhsv = new System.Windows.Forms.TrackBar();
            this.trbShsv = new System.Windows.Forms.TrackBar();
            this.trbHhsv = new System.Windows.Forms.TrackBar();
            this.pnlColorBox = new System.Windows.Forms.Panel();
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblHSV = new System.Windows.Forms.Label();
            this.lblHSL = new System.Windows.Forms.Label();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblHhsl = new System.Windows.Forms.Label();
            this.lblShsl = new System.Windows.Forms.Label();
            this.lblLhsl = new System.Windows.Forms.Label();
            this.lblVhsv = new System.Windows.Forms.Label();
            this.lblShsv = new System.Windows.Forms.Label();
            this.lblHhsv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLhsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHhsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLhsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHhsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVhsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHhsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVhsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHhsv)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(70, 58);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(410, 56);
            this.trbRed.TabIndex = 0;
            this.trbRed.TickFrequency = 15;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            this.trbRed.ValueChanged += new System.EventHandler(this.UpdateFromRGB);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(70, 120);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(410, 56);
            this.trbGreen.TabIndex = 1;
            this.trbGreen.TickFrequency = 15;
            this.trbGreen.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trbGreen.ValueChanged += new System.EventHandler(this.UpdateFromRGB);
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(70, 182);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(410, 56);
            this.trbBlue.TabIndex = 2;
            this.trbBlue.TickFrequency = 15;
            this.trbBlue.ValueChanged += new System.EventHandler(this.UpdateFromRGB);
            // 
            // nudRed
            // 
            this.nudRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRed.Location = new System.Drawing.Point(498, 58);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(68, 34);
            this.nudRed.TabIndex = 3;
            this.nudRed.ValueChanged += new System.EventHandler(this.UpDownToTrackbar);
            // 
            // nudGreen
            // 
            this.nudGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGreen.Location = new System.Drawing.Point(498, 120);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(68, 34);
            this.nudGreen.TabIndex = 4;
            this.nudGreen.ValueChanged += new System.EventHandler(this.UpDownToTrackbar);
            // 
            // nudBlue
            // 
            this.nudBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBlue.Location = new System.Drawing.Point(498, 182);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(68, 34);
            this.nudBlue.TabIndex = 5;
            this.nudBlue.ValueChanged += new System.EventHandler(this.UpDownToTrackbar);
            // 
            // nudLhsl
            // 
            this.nudLhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLhsl.Location = new System.Drawing.Point(498, 424);
            this.nudLhsl.Name = "nudLhsl";
            this.nudLhsl.Size = new System.Drawing.Size(68, 34);
            this.nudLhsl.TabIndex = 11;
            this.nudLhsl.ValueChanged += new System.EventHandler(this.UpDownToTrack);
            // 
            // nudShsl
            // 
            this.nudShsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudShsl.Location = new System.Drawing.Point(498, 362);
            this.nudShsl.Name = "nudShsl";
            this.nudShsl.Size = new System.Drawing.Size(68, 34);
            this.nudShsl.TabIndex = 10;
            this.nudShsl.ValueChanged += new System.EventHandler(this.UpDownToTrack);
            // 
            // nudHhsl
            // 
            this.nudHhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHhsl.Location = new System.Drawing.Point(498, 300);
            this.nudHhsl.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudHhsl.Name = "nudHhsl";
            this.nudHhsl.Size = new System.Drawing.Size(68, 34);
            this.nudHhsl.TabIndex = 9;
            this.nudHhsl.ValueChanged += new System.EventHandler(this.UpDownToTrack);
            // 
            // trbLhsl
            // 
            this.trbLhsl.Location = new System.Drawing.Point(70, 424);
            this.trbLhsl.Maximum = 100;
            this.trbLhsl.Name = "trbLhsl";
            this.trbLhsl.Size = new System.Drawing.Size(410, 56);
            this.trbLhsl.TabIndex = 8;
            this.trbLhsl.TickFrequency = 15;
            this.trbLhsl.ValueChanged += new System.EventHandler(this.UpdateFromHSL);
            // 
            // trbShsl
            // 
            this.trbShsl.Location = new System.Drawing.Point(70, 362);
            this.trbShsl.Maximum = 100;
            this.trbShsl.Name = "trbShsl";
            this.trbShsl.Size = new System.Drawing.Size(410, 56);
            this.trbShsl.TabIndex = 7;
            this.trbShsl.TickFrequency = 15;
            this.trbShsl.ValueChanged += new System.EventHandler(this.UpdateFromHSL);
            // 
            // trbHhsl
            // 
            this.trbHhsl.Location = new System.Drawing.Point(70, 300);
            this.trbHhsl.Maximum = 360;
            this.trbHhsl.Name = "trbHhsl";
            this.trbHhsl.Size = new System.Drawing.Size(410, 56);
            this.trbHhsl.TabIndex = 6;
            this.trbHhsl.TickFrequency = 45;
            this.trbHhsl.ValueChanged += new System.EventHandler(this.UpdateFromHSL);
            // 
            // nudVhsv
            // 
            this.nudVhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVhsv.Location = new System.Drawing.Point(1125, 182);
            this.nudVhsv.Name = "nudVhsv";
            this.nudVhsv.Size = new System.Drawing.Size(68, 34);
            this.nudVhsv.TabIndex = 17;
            this.nudVhsv.ValueChanged += new System.EventHandler(this.UpDownToTrackbarHSV);
            // 
            // nudShsv
            // 
            this.nudShsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudShsv.Location = new System.Drawing.Point(1125, 120);
            this.nudShsv.Name = "nudShsv";
            this.nudShsv.Size = new System.Drawing.Size(68, 34);
            this.nudShsv.TabIndex = 16;
            this.nudShsv.ValueChanged += new System.EventHandler(this.UpDownToTrackbarHSV);
            // 
            // nudHhsv
            // 
            this.nudHhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHhsv.Location = new System.Drawing.Point(1125, 58);
            this.nudHhsv.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudHhsv.Name = "nudHhsv";
            this.nudHhsv.Size = new System.Drawing.Size(68, 34);
            this.nudHhsv.TabIndex = 15;
            this.nudHhsv.ValueChanged += new System.EventHandler(this.UpDownToTrackbarHSV);
            // 
            // trbVhsv
            // 
            this.trbVhsv.Location = new System.Drawing.Point(697, 182);
            this.trbVhsv.Maximum = 100;
            this.trbVhsv.Name = "trbVhsv";
            this.trbVhsv.Size = new System.Drawing.Size(410, 56);
            this.trbVhsv.TabIndex = 14;
            this.trbVhsv.TickFrequency = 15;
            this.trbVhsv.ValueChanged += new System.EventHandler(this.UpdateFromHSV);
            // 
            // trbShsv
            // 
            this.trbShsv.Location = new System.Drawing.Point(697, 120);
            this.trbShsv.Maximum = 100;
            this.trbShsv.Name = "trbShsv";
            this.trbShsv.Size = new System.Drawing.Size(410, 56);
            this.trbShsv.TabIndex = 13;
            this.trbShsv.TickFrequency = 15;
            this.trbShsv.ValueChanged += new System.EventHandler(this.UpdateFromHSV);
            // 
            // trbHhsv
            // 
            this.trbHhsv.Location = new System.Drawing.Point(697, 58);
            this.trbHhsv.Maximum = 360;
            this.trbHhsv.Name = "trbHhsv";
            this.trbHhsv.Size = new System.Drawing.Size(410, 56);
            this.trbHhsv.TabIndex = 12;
            this.trbHhsv.TickFrequency = 45;
            this.trbHhsv.ValueChanged += new System.EventHandler(this.UpdateFromHSV);
            // 
            // pnlColorBox
            // 
            this.pnlColorBox.BackColor = System.Drawing.Color.Black;
            this.pnlColorBox.Location = new System.Drawing.Point(697, 300);
            this.pnlColorBox.Name = "pnlColorBox";
            this.pnlColorBox.Size = new System.Drawing.Size(496, 158);
            this.pnlColorBox.TabIndex = 18;
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.Location = new System.Drawing.Point(239, 9);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(76, 32);
            this.lblRGB.TabIndex = 19;
            this.lblRGB.Text = "RGB";
            // 
            // lblHSV
            // 
            this.lblHSV.AutoSize = true;
            this.lblHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSV.Location = new System.Drawing.Point(890, 9);
            this.lblHSV.Name = "lblHSV";
            this.lblHSV.Size = new System.Drawing.Size(73, 32);
            this.lblHSV.TabIndex = 20;
            this.lblHSV.Text = "HSV";
            // 
            // lblHSL
            // 
            this.lblHSL.AutoSize = true;
            this.lblHSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSL.Location = new System.Drawing.Point(239, 241);
            this.lblHSL.Name = "lblHSL";
            this.lblHSL.Size = new System.Drawing.Size(70, 32);
            this.lblHSL.TabIndex = 21;
            this.lblHSL.Text = "HSL";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorCode.Location = new System.Drawing.Point(844, 244);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(183, 38);
            this.txtColorCode.TabIndex = 22;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(21, 58);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 29);
            this.lblRed.TabIndex = 23;
            this.lblRed.Text = "R";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(21, 120);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(31, 29);
            this.lblGreen.TabIndex = 24;
            this.lblGreen.Text = "G";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(21, 184);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(29, 29);
            this.lblBlue.TabIndex = 25;
            this.lblBlue.Text = "B";
            // 
            // lblHhsl
            // 
            this.lblHhsl.AutoSize = true;
            this.lblHhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHhsl.Location = new System.Drawing.Point(21, 300);
            this.lblHhsl.Name = "lblHhsl";
            this.lblHhsl.Size = new System.Drawing.Size(30, 29);
            this.lblHhsl.TabIndex = 26;
            this.lblHhsl.Text = "H";
            // 
            // lblShsl
            // 
            this.lblShsl.AutoSize = true;
            this.lblShsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShsl.Location = new System.Drawing.Point(21, 362);
            this.lblShsl.Name = "lblShsl";
            this.lblShsl.Size = new System.Drawing.Size(29, 29);
            this.lblShsl.TabIndex = 27;
            this.lblShsl.Text = "S";
            // 
            // lblLhsl
            // 
            this.lblLhsl.AutoSize = true;
            this.lblLhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLhsl.Location = new System.Drawing.Point(21, 424);
            this.lblLhsl.Name = "lblLhsl";
            this.lblLhsl.Size = new System.Drawing.Size(26, 29);
            this.lblLhsl.TabIndex = 28;
            this.lblLhsl.Text = "L";
            // 
            // lblVhsv
            // 
            this.lblVhsv.AutoSize = true;
            this.lblVhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVhsv.Location = new System.Drawing.Point(651, 182);
            this.lblVhsv.Name = "lblVhsv";
            this.lblVhsv.Size = new System.Drawing.Size(28, 29);
            this.lblVhsv.TabIndex = 29;
            this.lblVhsv.Text = "V";
            // 
            // lblShsv
            // 
            this.lblShsv.AutoSize = true;
            this.lblShsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShsv.Location = new System.Drawing.Point(651, 120);
            this.lblShsv.Name = "lblShsv";
            this.lblShsv.Size = new System.Drawing.Size(29, 29);
            this.lblShsv.TabIndex = 30;
            this.lblShsv.Text = "S";
            // 
            // lblHhsv
            // 
            this.lblHhsv.AutoSize = true;
            this.lblHhsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHhsv.Location = new System.Drawing.Point(651, 58);
            this.lblHhsv.Name = "lblHhsv";
            this.lblHhsv.Size = new System.Drawing.Size(30, 29);
            this.lblHhsv.TabIndex = 31;
            this.lblHhsv.Text = "H";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 532);
            this.Controls.Add(this.lblHhsv);
            this.Controls.Add(this.lblShsv);
            this.Controls.Add(this.lblVhsv);
            this.Controls.Add(this.lblLhsl);
            this.Controls.Add(this.lblShsl);
            this.Controls.Add(this.lblHhsl);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.lblHSL);
            this.Controls.Add(this.lblHSV);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.pnlColorBox);
            this.Controls.Add(this.nudVhsv);
            this.Controls.Add(this.nudShsv);
            this.Controls.Add(this.nudHhsv);
            this.Controls.Add(this.trbVhsv);
            this.Controls.Add(this.trbShsv);
            this.Controls.Add(this.trbHhsv);
            this.Controls.Add(this.nudLhsl);
            this.Controls.Add(this.nudShsl);
            this.Controls.Add(this.nudHhsl);
            this.Controls.Add(this.trbLhsl);
            this.Controls.Add(this.trbShsl);
            this.Controls.Add(this.trbHhsl);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.trbRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLhsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHhsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLhsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHhsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVhsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHhsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbVhsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbShsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHhsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.NumericUpDown nudLhsl;
        private System.Windows.Forms.NumericUpDown nudShsl;
        private System.Windows.Forms.NumericUpDown nudHhsl;
        private System.Windows.Forms.TrackBar trbLhsl;
        private System.Windows.Forms.TrackBar trbShsl;
        private System.Windows.Forms.TrackBar trbHhsl;
        private System.Windows.Forms.NumericUpDown nudVhsv;
        private System.Windows.Forms.NumericUpDown nudShsv;
        private System.Windows.Forms.NumericUpDown nudHhsv;
        private System.Windows.Forms.TrackBar trbVhsv;
        private System.Windows.Forms.TrackBar trbShsv;
        private System.Windows.Forms.TrackBar trbHhsv;
        private System.Windows.Forms.Panel pnlColorBox;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblHSV;
        private System.Windows.Forms.Label lblHSL;
        private System.Windows.Forms.TextBox txtColorCode;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblHhsl;
        private System.Windows.Forms.Label lblShsl;
        private System.Windows.Forms.Label lblLhsl;
        private System.Windows.Forms.Label lblVhsv;
        private System.Windows.Forms.Label lblShsv;
        private System.Windows.Forms.Label lblHhsv;
    }
}

