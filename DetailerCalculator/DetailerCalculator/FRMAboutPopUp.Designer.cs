namespace DetailerCalculator
{
   partial class FRMAboutPopUp
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAboutPopUp));
         this.DetailerCalculatorLabel = new System.Windows.Forms.Label();
         this.VersionLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // DetailerCalculatorLabel
         // 
         this.DetailerCalculatorLabel.AutoSize = true;
         this.DetailerCalculatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DetailerCalculatorLabel.Location = new System.Drawing.Point(30, 9);
         this.DetailerCalculatorLabel.Name = "DetailerCalculatorLabel";
         this.DetailerCalculatorLabel.Size = new System.Drawing.Size(230, 29);
         this.DetailerCalculatorLabel.TabIndex = 0;
         this.DetailerCalculatorLabel.Text = "Detailer Calculator";
         // 
         // VersionLabel
         // 
         this.VersionLabel.AutoSize = true;
         this.VersionLabel.Location = new System.Drawing.Point(87, 49);
         this.VersionLabel.Name = "VersionLabel";
         this.VersionLabel.Size = new System.Drawing.Size(116, 17);
         this.VersionLabel.TabIndex = 1;
         this.VersionLabel.Text = "Version: 18.0.0.3";
         // 
         // FRMAboutPopUp
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(290, 88);
         this.Controls.Add(this.VersionLabel);
         this.Controls.Add(this.DetailerCalculatorLabel);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "FRMAboutPopUp";
         this.Text = "About Detailer Calculator";
         this.Load += new System.EventHandler(this.AboutFormLoad);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label DetailerCalculatorLabel;
      private System.Windows.Forms.Label VersionLabel;
   }
}