using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Reflection;

namespace DetailerCalculator
{
    public partial class FRMDetailerCalculator : Form
    {


        public static string Angle1 = "";
        public static string Angle2 = "";
        public static string Angle3 = "";
        public static string Angle4 = "";

        public FRMDetailerCalculator()
        {
            InitializeComponent();
        }

        //private void Label1_Click(object sender, EventArgs e)
        //{

        //}

        private void FRMDetailerCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnBase2Rise_Click(object sender, EventArgs e)
        {

        }

        private void BtnFt2Dec_Click(object sender, EventArgs e)
        {
            string userEntry = txtNumberEntry.Text;
            double answer = Convert.ToDouble(userEntry);

            double feet = Math.Truncate(answer);
            double inches = answer - feet;
            inches = Math.Truncate(inches * 100);
            double sixteenths = Math.Truncate(inches) - inches;
            sixteenths = sixteenths / 16;

            btnOutput.Text = feet.ToString();
        }

        private void RboAngle1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnOverwriteAngle1_Click(object sender, EventArgs e)
        {
            FRMOverwriteAngle settingsForm = new FRMOverwriteAngle();

            settingsForm.Show();
            
        }

        private void BtnTrig_Click(object sender, EventArgs e)
        {
            Angle1 = rboAngle1.Text;
            Angle2 = rboAngle2.Text;
            Angle3 = rboAngle3.Text;
            Angle4 = rboAngle4.Text;

            FRMTrig trigForm = new FRMTrig();

            trigForm.Show();
        }

    }
}
