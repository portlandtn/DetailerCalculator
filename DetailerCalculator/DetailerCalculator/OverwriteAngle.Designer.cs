namespace DetailerCalculator
{
    partial class OverwriteAngle
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
         this.txtAngleOverwrite = new System.Windows.Forms.TextBox();
         this.btnAngleOverwriteOK = new System.Windows.Forms.Button();
         this.CancelButton = new System.Windows.Forms.Button();
         this.panel1 = new System.Windows.Forms.Panel();
         this.rboAngle4Overwrite = new System.Windows.Forms.RadioButton();
         this.rboAngle3Overwrite = new System.Windows.Forms.RadioButton();
         this.lblAngles = new System.Windows.Forms.Label();
         this.rboAngle2Overwrite = new System.Windows.Forms.RadioButton();
         this.rboAngle1Overwrite = new System.Windows.Forms.RadioButton();
         this.btnExit = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // txtAngleOverwrite
         // 
         this.txtAngleOverwrite.Location = new System.Drawing.Point(51, 186);
         this.txtAngleOverwrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.txtAngleOverwrite.Name = "txtAngleOverwrite";
         this.txtAngleOverwrite.Size = new System.Drawing.Size(207, 22);
         this.txtAngleOverwrite.TabIndex = 0;
         // 
         // btnAngleOverwriteOK
         // 
         this.btnAngleOverwriteOK.Location = new System.Drawing.Point(159, 218);
         this.btnAngleOverwriteOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnAngleOverwriteOK.Name = "btnAngleOverwriteOK";
         this.btnAngleOverwriteOK.Size = new System.Drawing.Size(100, 28);
         this.btnAngleOverwriteOK.TabIndex = 1;
         this.btnAngleOverwriteOK.Text = "OK";
         this.btnAngleOverwriteOK.UseVisualStyleBackColor = true;
         this.btnAngleOverwriteOK.Click += new System.EventHandler(this.BtnAngleOverwriteOK_Click);
         // 
         // CancelButton
         // 
         this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.CancelButton.Location = new System.Drawing.Point(51, 218);
         this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.CancelButton.Name = "CancelButton";
         this.CancelButton.Size = new System.Drawing.Size(100, 28);
         this.CancelButton.TabIndex = 2;
         this.CancelButton.Text = "Cancel";
         this.CancelButton.UseVisualStyleBackColor = true;
         this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.rboAngle4Overwrite);
         this.panel1.Controls.Add(this.rboAngle3Overwrite);
         this.panel1.Controls.Add(this.lblAngles);
         this.panel1.Controls.Add(this.rboAngle2Overwrite);
         this.panel1.Controls.Add(this.rboAngle1Overwrite);
         this.panel1.Location = new System.Drawing.Point(51, 42);
         this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(208, 138);
         this.panel1.TabIndex = 3;
         // 
         // rboAngle4Overwrite
         // 
         this.rboAngle4Overwrite.AutoSize = true;
         this.rboAngle4Overwrite.Location = new System.Drawing.Point(4, 108);
         this.rboAngle4Overwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.rboAngle4Overwrite.Name = "rboAngle4Overwrite";
         this.rboAngle4Overwrite.Size = new System.Drawing.Size(85, 21);
         this.rboAngle4Overwrite.TabIndex = 4;
         this.rboAngle4Overwrite.Text = "Angle 4: ";
         this.rboAngle4Overwrite.UseVisualStyleBackColor = true;
         // 
         // rboAngle3Overwrite
         // 
         this.rboAngle3Overwrite.AutoSize = true;
         this.rboAngle3Overwrite.Location = new System.Drawing.Point(4, 81);
         this.rboAngle3Overwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.rboAngle3Overwrite.Name = "rboAngle3Overwrite";
         this.rboAngle3Overwrite.Size = new System.Drawing.Size(85, 21);
         this.rboAngle3Overwrite.TabIndex = 3;
         this.rboAngle3Overwrite.Text = "Angle 3: ";
         this.rboAngle3Overwrite.UseVisualStyleBackColor = true;
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
         // rboAngle2Overwrite
         // 
         this.rboAngle2Overwrite.AutoSize = true;
         this.rboAngle2Overwrite.Location = new System.Drawing.Point(4, 54);
         this.rboAngle2Overwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.rboAngle2Overwrite.Name = "rboAngle2Overwrite";
         this.rboAngle2Overwrite.Size = new System.Drawing.Size(85, 21);
         this.rboAngle2Overwrite.TabIndex = 1;
         this.rboAngle2Overwrite.Text = "Angle 2: ";
         this.rboAngle2Overwrite.UseVisualStyleBackColor = true;
         // 
         // rboAngle1Overwrite
         // 
         this.rboAngle1Overwrite.AutoSize = true;
         this.rboAngle1Overwrite.Checked = true;
         this.rboAngle1Overwrite.Location = new System.Drawing.Point(4, 27);
         this.rboAngle1Overwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.rboAngle1Overwrite.Name = "rboAngle1Overwrite";
         this.rboAngle1Overwrite.Size = new System.Drawing.Size(85, 21);
         this.rboAngle1Overwrite.TabIndex = 0;
         this.rboAngle1Overwrite.TabStop = true;
         this.rboAngle1Overwrite.Text = "Angle 1: ";
         this.rboAngle1Overwrite.UseVisualStyleBackColor = true;
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(51, 255);
         this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(208, 28);
         this.btnExit.TabIndex = 4;
         this.btnExit.Text = "Exit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.Exit_Click);
         // 
         // OverwriteAngle
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.CancelButton;
         this.ClientSize = new System.Drawing.Size(309, 309);
         this.Controls.Add(this.btnExit);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.CancelButton);
         this.Controls.Add(this.btnAngleOverwriteOK);
         this.Controls.Add(this.txtAngleOverwrite);
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "OverwriteAngle";
         this.Text = "Overwrite Angle";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAngleOverwrite;
        private System.Windows.Forms.Button btnAngleOverwriteOK;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rboAngle4Overwrite;
        private System.Windows.Forms.RadioButton rboAngle3Overwrite;
        private System.Windows.Forms.Label lblAngles;
        private System.Windows.Forms.RadioButton rboAngle2Overwrite;
        private System.Windows.Forms.RadioButton rboAngle1Overwrite;
        private System.Windows.Forms.Button btnExit;
    }
}