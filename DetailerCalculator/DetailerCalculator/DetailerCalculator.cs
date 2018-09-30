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
      }

      private void FRMDetailerCalculator_Load(object sender, EventArgs e)
      {
         Angle1Label.Text = Convert.ToString(Properties.Settings.Default["Angle1"]);
         Angle2Label.Text = Convert.ToString(Properties.Settings.Default["Angle2"]);
         Angle3Label.Text = Convert.ToString(Properties.Settings.Default["Angle3"]);
         Angle4Label.Text = Convert.ToString(Properties.Settings.Default["Angle4"]);

         OutputWindow.Text = Convert.ToString(Properties.Settings.Default["OutputWindow"]);
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
         //OverwriteAngle frmAngle = new OverwriteAngle();

         //frmAngle.Show();

         int angleToBeOverwritten = 5;
         if (Angle1RadioButton.Checked)
         {
            angleToBeOverwritten = 1;
         }

         else if (Angle2RadioButton.Checked)
         {
            angleToBeOverwritten = 2;
         }

         else if (Angle3RadioButton.Checked)
         {
            angleToBeOverwritten = 3;
         }

         else if (Angle4RadioButton.Checked)
         {
            angleToBeOverwritten = 4;
         }

         else
         {
            angleToBeOverwritten = 5;
         }

         OverwriteAngle(Convert.ToDouble(OverWriteAngleTextBox.Text), angleToBeOverwritten);

      }

      private void BtnTrig_Click(object sender, EventArgs e)
      {
         Triangle t1 = new Triangle();
         Triangle t2 = new Triangle();
         Triangle t3 = new Triangle();
         Triangle t4 = new Triangle();

         t1.Angle = Convert.ToDouble(Angle1Label.Text);
         t2.Angle = Convert.ToDouble(Angle2Label.Text); ;
         t3.Angle = Convert.ToDouble(Angle3Label.Text); ;
         t4.Angle = Convert.ToDouble(Angle4Label.Text); ;

         FRMTrig trigForm = new FRMTrig(t1.Angle, t2.Angle, t3.Angle, t4.Angle);
         trigForm.Show();
      }

      private void UserEntryBox_TextChanged(object sender, EventArgs e)
      {

      }

      private void DetailerCalculator_KeyPress(object sender, KeyPressEventArgs e)
      {


      }

      private void AddButton_Click(object sender, EventArgs e)
      {

      }

      private void DetailerCalculatorClosed(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default["OutputWindow"] = OutputWindow.Text;
         Properties.Settings.Default["Angle1"] = Convert.ToDouble(Angle1Label.Text);
         Properties.Settings.Default["Angle2"] = Convert.ToDouble(Angle1Label.Text);
         Properties.Settings.Default["Angle3"] = Convert.ToDouble(Angle3Label.Text);
         Properties.Settings.Default["Angle4"] = Convert.ToDouble(Angle1Label.Text);
         Properties.Settings.Default.Save();
      }

      private void OverwriteAngle(double angle, int angleToBeOverwritten)
      {
         try
         {
            if (angleToBeOverwritten == 5)
            {
               throw new Exception(string.Format("Cannot determine angle to be overwritten."));
            }

            Triangle t = new Triangle();
            t.Angle = angle;

            if (angleToBeOverwritten == 1)
            {
               Angle1Label.Text = Convert.ToString(angle);
            }

            if (angleToBeOverwritten == 2)
            {
               Angle2Label.Text = Convert.ToString(angle);
            }

            if (angleToBeOverwritten == 3)
            {
               Angle3Label.Text = Convert.ToString(angle);
            }

            if (angleToBeOverwritten == 4)
            {
               Angle4Label.Text = Convert.ToString(angle);
            }
         }
         catch (Exception)
         {
            MessageBox.Show("Cannot determine angle.");
         }
      }

      private void DropButton_Click(object sender, EventArgs e)
      {
         OutputWindow.Text = OutputWindow.Text.Remove(OutputWindow.Text.LastIndexOf(Environment.NewLine));
      }

      private void ClearAllButton_Click(object sender, EventArgs e)
      {
         OutputWindow.Text = "";
      }

      private void EntryBox_KeyDown(object sender, KeyEventArgs e)
      {
         List<double> list = new List<double>();

         if (e.KeyCode == Keys.Enter)
         {
            OutputWindow.Text = OutputWindow.Text + "\n " + UserEntryBox.Text;
            UserEntryBox.Text = "";
            e.Handled = true;
            e.SuppressKeyPress = true;
         }

         //if (e.KeyCode == Keys.Enter)
         //{
         //   list.Add(Convert.ToDouble(UserEntryBox.Text));
         //   foreach (var i in list)
         //   {
         //      OutputWindow.Text = "\n" + Convert.ToString(i);
         //   }

         //   UserEntryBox.Text = "";
         //   e.Handled = true;
         //   e.SuppressKeyPress = true;
         //}
      }
   }
}
