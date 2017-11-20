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
    public partial class FRMOverwriteAngle : Form
    {
        public FRMOverwriteAngle()
        {
            InitializeComponent();
        }

        private void BtnAngleOverwriteOK_Click(object sender, EventArgs e)
        {
            if (rboAngle1Overwrite.Checked)
            {
                rboAngle1Overwrite.Text = "Angle 1: " + txtAngleOverwrite.Text;
                
            }

            else if (rboAngle2Overwrite.Checked)
            {
                rboAngle2Overwrite.Text = "Angle 2: " + txtAngleOverwrite.Text;
            }

            else if (rboAngle3Overwrite.Checked)
            {
                rboAngle3Overwrite.Text = "Angle 3: " + txtAngleOverwrite.Text;
            }

            else if (rboAngle4Overwrite.Checked)
            {
                rboAngle4Overwrite.Text = "Angle 4: " + txtAngleOverwrite.Text;
            }

           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FRMDetailerCalculator.Angle1 = rboAngle1Overwrite.Text;
            FRMDetailerCalculator.Angle2 = rboAngle2Overwrite.Text;
            FRMDetailerCalculator.Angle3 = rboAngle3Overwrite.Text;
            FRMDetailerCalculator.Angle4 = rboAngle4Overwrite.Text;


            this.Close();
        }
    }
}
