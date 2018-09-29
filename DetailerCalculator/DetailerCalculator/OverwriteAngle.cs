using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailerCalculator
{
   public partial class OverwriteAngle : Form
   {
      public OverwriteAngle()
      {
         InitializeComponent();
      }

      private void BtnAngleOverwriteOK_Click(object sender, EventArgs e)
      {
         if (rboAngle1Overwrite.Checked)
         {
            rboAngle1Overwrite.Text = "Angle 1: " + txtAngleOverwrite.Text;
            Triangle t1 = new Triangle
            {
               Angle = Convert.ToDouble(txtAngleOverwrite.Text)
            };
         }

         else if (rboAngle2Overwrite.Checked)
         {
            rboAngle2Overwrite.Text = "Angle 2: " + txtAngleOverwrite.Text;
            Triangle t2 = new Triangle
            {
               Angle = Convert.ToDouble(txtAngleOverwrite.Text)
            };
         }

         else if (rboAngle3Overwrite.Checked)
         {
            rboAngle3Overwrite.Text = "Angle 3: " + txtAngleOverwrite.Text;
            Triangle t3 = new Triangle
            {
               Angle = Convert.ToDouble(txtAngleOverwrite.Text)
            };
         }

         else if (rboAngle4Overwrite.Checked)
         {
            rboAngle4Overwrite.Text = "Angle 4: " + txtAngleOverwrite.Text;
            Triangle t4 = new Triangle
            {
               Angle = Convert.ToDouble(txtAngleOverwrite.Text)
            };
         }
      }

      private void Exit_Click(object sender, EventArgs e)
      {
         
         this.Close();
      }

      private void CancelButton_Click(object sender, EventArgs e)
      {
         this.Close();
      }
   }
}
