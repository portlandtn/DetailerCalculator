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
      
        public static double Angle1 = 0;
        public static double Angle2 = 0;
        public static double Angle3 = 0;
        public static double Angle4 = 0;

        public FRMDetailerCalculator()
        {
            InitializeComponent();
        }

        private void FRMDetailerCalculator_Load(object sender, EventArgs e)
        {

        }

        private void BtnBase2Rise_Click(object sender, EventArgs e)
        {

        }

        private void BtnFt2Dec_Click(object sender, EventArgs e)
        {
         TrigFunctions trigFunctions = new TrigFunctions();

         trigFunctions.FootToDecimal(12.0204);
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
         Angles angles = new Angles();

         angles.Angle1 = 24.0204;
         angles.Angle2 = 25.0205;
         angles.Angle3 = 14.0523;
         angles.Angle4 = 98.2404;

         FRMTrig trigForm = new FRMTrig(angles.Angle1, angles.Angle2, angles.Angle3, angles.Angle4);

            trigForm.Show();
        }

      private void UserEntryBox_TextChanged(object sender, EventArgs e)
      {
         
      }

      private void DetailerCalculator_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToInt16(Keys.Enter))
         {
            Stack<double> stack = new Stack<double>();
            stack.Push(Convert.ToDouble(UserEntryBox.Text));

            OutputWindow.Text = Convert.ToString(stack.Pop());
         }
      }
   }
}
