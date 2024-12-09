namespace Laba5
{
    partial class Form2
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
            this.Scroll_Red = new System.Windows.Forms.HScrollBar();
            this.Scroll_Green = new System.Windows.Forms.HScrollBar();
            this.Scroll_Blue = new System.Windows.Forms.HScrollBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericRed = new System.Windows.Forms.NumericUpDown();
            this.numericGreen = new System.Windows.Forms.NumericUpDown();
            this.numericBlue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // Scroll_Red
            // 
            this.Scroll_Red.LargeChange = 1;
            this.Scroll_Red.Location = new System.Drawing.Point(40, 51);
            this.Scroll_Red.Maximum = 255;
            this.Scroll_Red.Name = "Scroll_Red";
            this.Scroll_Red.Size = new System.Drawing.Size(221, 23);
            this.Scroll_Red.TabIndex = 0;
            this.Scroll_Red.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // Scroll_Green
            // 
            this.Scroll_Green.LargeChange = 1;
            this.Scroll_Green.Location = new System.Drawing.Point(40, 92);
            this.Scroll_Green.Maximum = 255;
            this.Scroll_Green.Name = "Scroll_Green";
            this.Scroll_Green.Size = new System.Drawing.Size(221, 23);
            this.Scroll_Green.TabIndex = 1;
            this.Scroll_Green.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // Scroll_Blue
            // 
            this.Scroll_Blue.LargeChange = 1;
            this.Scroll_Blue.Location = new System.Drawing.Point(40, 129);
            this.Scroll_Blue.Maximum = 255;
            this.Scroll_Blue.Name = "Scroll_Blue";
            this.Scroll_Blue.Size = new System.Drawing.Size(221, 23);
            this.Scroll_Blue.TabIndex = 2;
            this.Scroll_Blue.ValueChanged += new System.EventHandler(this.Scroll_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(377, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // numericRed
            // 
            this.numericRed.Location = new System.Drawing.Point(286, 54);
            this.numericRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericRed.Name = "numericRed";
            this.numericRed.Size = new System.Drawing.Size(47, 20);
            this.numericRed.TabIndex = 4;
            this.numericRed.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // numericGreen
            // 
            this.numericGreen.Location = new System.Drawing.Point(286, 92);
            this.numericGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericGreen.Name = "numericGreen";
            this.numericGreen.Size = new System.Drawing.Size(47, 20);
            this.numericGreen.TabIndex = 5;
            this.numericGreen.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // numericBlue
            // 
            this.numericBlue.Location = new System.Drawing.Point(286, 129);
            this.numericBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericBlue.Name = "numericBlue";
            this.numericBlue.Size = new System.Drawing.Size(47, 20);
            this.numericBlue.TabIndex = 6;
            this.numericBlue.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Other Colors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonOther_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(546, 247);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericBlue);
            this.Controls.Add(this.numericGreen);
            this.Controls.Add(this.numericRed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Scroll_Blue);
            this.Controls.Add(this.Scroll_Green);
            this.Controls.Add(this.Scroll_Red);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar Scroll_Red;
        private System.Windows.Forms.HScrollBar Scroll_Green;
        private System.Windows.Forms.HScrollBar Scroll_Blue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericRed;
        private System.Windows.Forms.NumericUpDown numericGreen;
        private System.Windows.Forms.NumericUpDown numericBlue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}