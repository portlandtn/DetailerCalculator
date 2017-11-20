namespace DetailerCalculator
{
    partial class FRMTrig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rboAngle4 = new System.Windows.Forms.RadioButton();
            this.rboAngle3 = new System.Windows.Forms.RadioButton();
            this.lblAngles = new System.Windows.Forms.Label();
            this.rboAngle2 = new System.Windows.Forms.RadioButton();
            this.rboAngle1 = new System.Windows.Forms.RadioButton();
            this.lblDetailerCalculator = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rboAngle4);
            this.panel1.Controls.Add(this.rboAngle3);
            this.panel1.Controls.Add(this.lblAngles);
            this.panel1.Controls.Add(this.rboAngle2);
            this.panel1.Controls.Add(this.rboAngle1);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 138);
            this.panel1.TabIndex = 3;
            // 
            // rboAngle4
            // 
            this.rboAngle4.AutoSize = true;
            this.rboAngle4.Location = new System.Drawing.Point(4, 108);
            this.rboAngle4.Name = "rboAngle4";
            this.rboAngle4.Size = new System.Drawing.Size(85, 21);
            this.rboAngle4.TabIndex = 4;
            this.rboAngle4.Text = "Angle 4: ";
            this.rboAngle4.UseVisualStyleBackColor = true;
            // 
            // rboAngle3
            // 
            this.rboAngle3.AutoSize = true;
            this.rboAngle3.Location = new System.Drawing.Point(4, 81);
            this.rboAngle3.Name = "rboAngle3";
            this.rboAngle3.Size = new System.Drawing.Size(85, 21);
            this.rboAngle3.TabIndex = 3;
            this.rboAngle3.Text = "Angle 3: ";
            this.rboAngle3.UseVisualStyleBackColor = true;
            // 
            // lblAngles
            // 
            this.lblAngles.AutoSize = true;
            this.lblAngles.Location = new System.Drawing.Point(4, 4);
            this.lblAngles.Name = "lblAngles";
            this.lblAngles.Size = new System.Drawing.Size(51, 17);
            this.lblAngles.TabIndex = 2;
            this.lblAngles.Text = "Angles";
            // 
            // rboAngle2
            // 
            this.rboAngle2.AutoSize = true;
            this.rboAngle2.Location = new System.Drawing.Point(4, 54);
            this.rboAngle2.Name = "rboAngle2";
            this.rboAngle2.Size = new System.Drawing.Size(85, 21);
            this.rboAngle2.TabIndex = 1;
            this.rboAngle2.Text = "Angle 2: ";
            this.rboAngle2.UseVisualStyleBackColor = true;
            // 
            // rboAngle1
            // 
            this.rboAngle1.AutoSize = true;
            this.rboAngle1.Checked = true;
            this.rboAngle1.Location = new System.Drawing.Point(4, 27);
            this.rboAngle1.Name = "rboAngle1";
            this.rboAngle1.Size = new System.Drawing.Size(85, 21);
            this.rboAngle1.TabIndex = 0;
            this.rboAngle1.TabStop = true;
            this.rboAngle1.Text = "Angle 1: ";
            this.rboAngle1.UseVisualStyleBackColor = true;
            // 
            // lblDetailerCalculator
            // 
            this.lblDetailerCalculator.AutoSize = true;
            this.lblDetailerCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailerCalculator.Location = new System.Drawing.Point(220, 9);
            this.lblDetailerCalculator.Name = "lblDetailerCalculator";
            this.lblDetailerCalculator.Size = new System.Drawing.Size(64, 32);
            this.lblDetailerCalculator.TabIndex = 4;
            this.lblDetailerCalculator.Text = "Trig";
            // 
            // FRMTrig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 448);
            this.Controls.Add(this.lblDetailerCalculator);
            this.Controls.Add(this.panel1);
            this.Name = "FRMTrig";
            this.Text = "Trig";
            this.Load += new System.EventHandler(this.FRMTrig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rboAngle4;
        private System.Windows.Forms.RadioButton rboAngle3;
        private System.Windows.Forms.Label lblAngles;
        private System.Windows.Forms.RadioButton rboAngle2;
        private System.Windows.Forms.RadioButton rboAngle1;
        private System.Windows.Forms.Label lblDetailerCalculator;
    }
}