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
      
        public static double Angle = 0;

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
         Conversions trigFunctions = new Conversions();

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
         Triangle1 t1 = new Triangle1();
         Triangle2 t2 = new Triangle2();
         Triangle3 t3 = new Triangle3();
         Triangle4 t4 = new Triangle4();

         t1.Angle = 21.0208;
         t2.Angle = 14.0635;
         t3.Angle = 15.0809;
         t4.Angle = 75.0458;

         FRMTrig trigForm = new FRMTrig(t1.Angle, t2.Angle, t3.Angle, t4.Angle);
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

      private void AddButton_Click(object sender, EventArgs e)
      {

      }
   }
}
