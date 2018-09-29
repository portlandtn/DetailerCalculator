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

      public FRMDetailerCalculator()
      {
         InitializeComponent();
         Angle1RadioButton.Text = "Angle 1: " + 24.0208;
      }

      private void FRMDetailerCalculator_Load(object sender, EventArgs e)
      {

      }

      private void BtnBase2Rise_Click(object sender, EventArgs e)
      {
         Triangle t1 = new Triangle();
         Triangle t2 = new Triangle();
         Triangle t3 = new Triangle();
         Triangle t4 = new Triangle();

         double angle;

         if (Angle1RadioButton.Checked)
         {
            angle = t1.Angle;
         }
         else if (Angle2RadioButton.Checked)
         {
            angle = t2.Angle;
         }
         else if (Angle3RadioButton.Checked)
         {
            angle = t3.Angle;
         }
         else if (Angle4RadioButton.Checked)
         {
            angle = t4.Angle;
         }

         else
         {
            throw new Exception("Angle not detected");
         }

         SidesTrig sTrig = new SidesTrig();
         OutputWindow.Text = Convert.ToString(sTrig.BaseToRise(Convert.ToDouble(OutputWindow.Text), angleA: angle));
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
         OverwriteAngle frmAngle = new OverwriteAngle();

         frmAngle.Show();

      }

      private void BtnTrig_Click(object sender, EventArgs e)
      {
         Triangle t1 = new Triangle();
         Triangle t2 = new Triangle();
         Triangle t3 = new Triangle();
         Triangle t4 = new Triangle();

         t1.Angle = Convert.ToDouble(Angle1RadioButton.Text.Substring(9));
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
            UserEntryBox.Text = "";
         }
      }

      private void AddButton_Click(object sender, EventArgs e)
      {

      }
   }
}
