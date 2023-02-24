namespace Color_Mixer
{
    partial class ColorMixer
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
            this.grbFirstColor = new System.Windows.Forms.GroupBox();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.grbColorTwo = new System.Windows.Forms.GroupBox();
            this.rbYellowTwo = new System.Windows.Forms.RadioButton();
            this.rbBlueTwo = new System.Windows.Forms.RadioButton();
            this.rbRedTwo = new System.Windows.Forms.RadioButton();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbFirstColor.SuspendLayout();
            this.grbColorTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFirstColor
            // 
            this.grbFirstColor.Controls.Add(this.rbYellow);
            this.grbFirstColor.Controls.Add(this.rbBlue);
            this.grbFirstColor.Controls.Add(this.rbRed);
            this.grbFirstColor.Location = new System.Drawing.Point(23, 46);
            this.grbFirstColor.Name = "grbFirstColor";
            this.grbFirstColor.Size = new System.Drawing.Size(172, 100);
            this.grbFirstColor.TabIndex = 0;
            this.grbFirstColor.TabStop = false;
            this.grbFirstColor.Text = "Please Select the First Color";
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(17, 65);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(56, 17);
            this.rbYellow.TabIndex = 2;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(17, 42);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 1;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(17, 19);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // grbColorTwo
            // 
            this.grbColorTwo.Controls.Add(this.rbYellowTwo);
            this.grbColorTwo.Controls.Add(this.rbBlueTwo);
            this.grbColorTwo.Controls.Add(this.rbRedTwo);
            this.grbColorTwo.Location = new System.Drawing.Point(226, 46);
            this.grbColorTwo.Name = "grbColorTwo";
            this.grbColorTwo.Size = new System.Drawing.Size(172, 100);
            this.grbColorTwo.TabIndex = 1;
            this.grbColorTwo.TabStop = false;
            this.grbColorTwo.Text = "Please select the Second Color";
            // 
            // rbYellowTwo
            // 
            this.rbYellowTwo.AutoSize = true;
            this.rbYellowTwo.Location = new System.Drawing.Point(17, 65);
            this.rbYellowTwo.Name = "rbYellowTwo";
            this.rbYellowTwo.Size = new System.Drawing.Size(56, 17);
            this.rbYellowTwo.TabIndex = 3;
            this.rbYellowTwo.TabStop = true;
            this.rbYellowTwo.Text = "Yellow";
            this.rbYellowTwo.UseVisualStyleBackColor = true;
            // 
            // rbBlueTwo
            // 
            this.rbBlueTwo.AutoSize = true;
            this.rbBlueTwo.Location = new System.Drawing.Point(17, 42);
            this.rbBlueTwo.Name = "rbBlueTwo";
            this.rbBlueTwo.Size = new System.Drawing.Size(46, 17);
            this.rbBlueTwo.TabIndex = 2;
            this.rbBlueTwo.TabStop = true;
            this.rbBlueTwo.Text = "Blue";
            this.rbBlueTwo.UseVisualStyleBackColor = true;
            // 
            // rbRedTwo
            // 
            this.rbRedTwo.AutoSize = true;
            this.rbRedTwo.Location = new System.Drawing.Point(17, 19);
            this.rbRedTwo.Name = "rbRedTwo";
            this.rbRedTwo.Size = new System.Drawing.Size(45, 17);
            this.rbRedTwo.TabIndex = 1;
            this.rbRedTwo.TabStop = true;
            this.rbRedTwo.Text = "Red";
            this.rbRedTwo.UseVisualStyleBackColor = true;
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(120, 161);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(75, 23);
            this.btnMix.TabIndex = 2;
            this.btnMix.Text = "Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ColorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 219);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.grbColorTwo);
            this.Controls.Add(this.grbFirstColor);
            this.Name = "ColorMixer";
            this.Text = "Color Mixer";
            this.grbFirstColor.ResumeLayout(false);
            this.grbFirstColor.PerformLayout();
            this.grbColorTwo.ResumeLayout(false);
            this.grbColorTwo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFirstColor;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.GroupBox grbColorTwo;
        private System.Windows.Forms.RadioButton rbYellowTwo;
        private System.Windows.Forms.RadioButton rbBlueTwo;
        private System.Windows.Forms.RadioButton rbRedTwo;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnExit;
    }
}

