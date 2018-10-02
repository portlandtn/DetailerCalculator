﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Reflection;

namespace DetailerCalculator
{
   public partial class FRMDetailerCalculator : Form
   {
      Settings _Angle1 = new Settings();
      Settings _Angle2 = new Settings();
      Settings _Angle3 = new Settings();
      Settings _Angle4 = new Settings();
      Settings _ActiveAngle = new Settings();
      Settings _MathMethod = new Settings();
      List<double> _OutputWindowList = new List<double>();

      public FRMDetailerCalculator()
      {
         InitializeComponent();
      }

      private void FRMDetailerCalculator_Load(object sender, EventArgs e)
      {
         RestoreSettings();
         _ActiveAngle.ActiveAngle = 1;
         _MathMethod.IsDetailingMathMethod = true;
      }

      private void BaseToRiseButton_Click(object sender, EventArgs e)
      {
         var angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.BaseToRise(14, angle));
      }

      private void BaseToSlopeButton_Click(object sender, EventArgs e)
      {
         var angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.BaseToSlope(14, angle));
      }

      private void SlopeToBaseButton_Click(object sender, EventArgs e)
      {
         var angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.SlopeToBase(14, angle));
      }

      private void SlopeToRiseButton_Click(object sender, EventArgs e)
      {
         var angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.SlopeToBase(14, angle));
      }

      private void RiseToSlopeButton_Click(object sender, EventArgs e)
      {
         var angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.RiseToSlope(14, angle));
      }

      private void RiseToBaseButton_Click(object sender, EventArgs e)
      {
         var angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.RiseToBase(14, angle));
      }

      private void FootToDecimalButton_Click(object sender, EventArgs e)
      {
         FootToDecimal();
      }
      private void DecimalToFootButton_Click(object sender, EventArgs e)
      {
         DecimalToFoot();
      }

      public void Angle1RadioBox_CheckedChanged(object sender, EventArgs e)
      {
         _ActiveAngle.ActiveAngle = 1;
      }

      private void Angle2RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         _ActiveAngle.ActiveAngle = 2;
      }

      private void Angle3RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         _ActiveAngle.ActiveAngle = 3;
      }

      private void Angle4RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         _ActiveAngle.ActiveAngle = 4;

      }

      private void OverwriteAngleButton_Click(object sender, EventArgs e)
      {

         OverwriteAngle(_ActiveAngle.ActiveAngle);

      }

      private void UserEntryBox_TextChanged(object sender, EventArgs e)
      {
         Regex regex = new Regex(@"[^0-9^+^\-^\/^\*^.]");
         MatchCollection matches = regex.Matches(UserEntryBox.Text);

         if (matches.Count > 0)
         {
            WarningNumbericEntryOnlyLabel.Visible = true;
            UserEntryBox.Text = "";
         }
      }

      private void AddButton_Click(object sender, EventArgs e)
      {
         var sum = AddNumbers(Convert.ToDouble(UserEntryBox.Text), Convert.ToDouble(UserEntryBox.Text), _MathMethod.IsDetailingMathMethod);
         OutputWindow.Text = Convert.ToString(sum);
         UserEntryBox.Text = "";
      }

      private void SubtractButton_Click(object sender, EventArgs e)
      {
         var diff = SubtractNumbers(Convert.ToDouble(UserEntryBox.Text), Convert.ToDouble(UserEntryBox.Text) - 6, _MathMethod.IsDetailingMathMethod);
         OutputWindow.Text = Convert.ToString(diff);
         UserEntryBox.Text = "";
      }

      private void MultiplyButton_Click(object sender, EventArgs e)
      {
         var prod = MultiplyNumbers(Convert.ToDouble(UserEntryBox.Text), Convert.ToDouble(UserEntryBox.Text), _MathMethod.IsDetailingMathMethod);
         OutputWindow.Text = Convert.ToString(prod);
         UserEntryBox.Text = "";
      }

      private void DivideButton_Click(object sender, EventArgs e)
      {
         var quotient = DivideNumbers(Convert.ToDouble(UserEntryBox.Text), Convert.ToDouble(UserEntryBox.Text), _MathMethod.IsDetailingMathMethod);
         OutputWindow.Text = Convert.ToString(quotient);
         UserEntryBox.Text = "";
      }

      private void DropButton_Click(object sender, EventArgs e)
      {
         OutputWindow.Text = OutputWindow.Text.Remove(OutputWindow.Text.LastIndexOf(Environment.NewLine));
      }

      private void ClearAllButton_Click(object sender, EventArgs e)
      {
         _OutputWindowList.Clear();
         OutputWindow.Text = "";
      }

      private void BaseRiseToAngleButton_Click(object sender, EventArgs e)
      {
         BaseRiseToAngle(12, 1);
      }

      private void EntryBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            _OutputWindowList.Add(Convert.ToDouble(UserEntryBox.Text));

            foreach (var item in _OutputWindowList)
            {
               OutputWindow.Text =  String.Join(Environment.NewLine, item);
            }

            UserEntryBox.Text = "";
            e.Handled = true;
            e.SuppressKeyPress = true;
         }

         if (e.KeyCode == Keys.Add)
         {
            if (UserEntryBox.Text != "" && _OutputWindowList.Count > 1)
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 2];
               double num2 = _OutputWindowList[_OutputWindowList.Count - 1];
               ArithmeticFunctionsFromKeys("Add", num1, num2);
            }
            else
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 1];
               double num2 = Convert.ToDouble(UserEntryBox.Text);
               ArithmeticFunctionsFromKeys("Add", num1, num2);
            }
         }

         if (e.KeyCode == Keys.Subtract)
         {
            if (UserEntryBox.Text != "" && _OutputWindowList.Count > 1)
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 2];
               double num2 = _OutputWindowList[_OutputWindowList.Count - 1];
               ArithmeticFunctionsFromKeys("Subtract", num1, num2);
            }
            else
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 1];
               double num2 = Convert.ToDouble(UserEntryBox.Text);
               ArithmeticFunctionsFromKeys("Subtract", num1, num2);
            }
         }

         if (e.KeyCode == Keys.Multiply)
         {
            if (UserEntryBox.Text != "" && _OutputWindowList.Count > 1)
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 2];
               double num2 = _OutputWindowList[_OutputWindowList.Count - 1];
               ArithmeticFunctionsFromKeys("Multiply", num1, num2);
            }
            else
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 1];
               double num2 = Convert.ToDouble(UserEntryBox.Text);
               ArithmeticFunctionsFromKeys("Multiply", num1, num2);
            }
         }

         if (e.KeyCode == Keys.Divide)
         {
            if (UserEntryBox.Text != "" && _OutputWindowList.Count > 1)
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 2];
               double num2 = _OutputWindowList[_OutputWindowList.Count - 1];
               ArithmeticFunctionsFromKeys("Divide", num1, num2);
            }
            else
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 1];
               double num2 = Convert.ToDouble(UserEntryBox.Text);
               ArithmeticFunctionsFromKeys("Divide", num1, num2);
            }
         }
      }

      public void RestoreSettings()
      {
         OutputWindow.Text = Convert.ToString(Properties.Settings.Default["OutputWindow"]);


         double _Angle1 = Convert.ToDouble(Properties.Settings.Default["Angle1"]);
         double _Angle2 = Convert.ToDouble(Properties.Settings.Default["Angle2"]);
         double _Angle3 = Convert.ToDouble(Properties.Settings.Default["Angle3"]);
         double _Angle4 = Convert.ToDouble(Properties.Settings.Default["Angle4"]);

         Angle1Label.Text = Convert.ToString(_Angle1);
         Angle2Label.Text = Convert.ToString(_Angle2);
         Angle3Label.Text = Convert.ToString(_Angle3);
         Angle4Label.Text = Convert.ToString(_Angle4);
      }

      private void DetailerCalculatorClosed(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default["Angle1"] = Convert.ToDouble(Angle1Label.Text);
         Properties.Settings.Default["Angle2"] = Convert.ToDouble(Angle2Label.Text);
         Properties.Settings.Default["Angle3"] = Convert.ToDouble(Angle3Label.Text);
         Properties.Settings.Default["Angle4"] = Convert.ToDouble(Angle4Label.Text);
         Properties.Settings.Default.Save();
      }

      private void OverwiteAngleTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            OverwriteAngle(_ActiveAngle.ActiveAngle);
            OverWriteAngleTextBox.Text = "";
            e.Handled = true;
            e.SuppressKeyPress = true;
         }
      }

      public void OverwriteAngle(int activeAngle)
      {
         switch (activeAngle)
         {
            case 1:
               _Angle1.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               var angle = Math.Round(_Angle1.Angle, 4);
               Angle1Label.Text = Convert.ToString(angle);
               break;
            case 2:
               _Angle2.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               angle = Math.Round(_Angle2.Angle, 4);
               Angle2Label.Text = Convert.ToString(angle);
               break;
            case 3:
               _Angle3.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               angle = Math.Round(_Angle3.Angle, 4);
               Angle3Label.Text = Convert.ToString(angle);
               break;
            case 4:
               _Angle4.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               angle = Math.Round(_Angle4.Angle, 4);
               Angle4Label.Text = Convert.ToString(angle);
               break;
            default:
               MessageBox.Show("Angle was not detected");
               break;
         }
      }

      private void SlopeTextBox_TextChanged(object sender, EventArgs e)
      {
         if (SlopeTextBox.Text == "")
         {
            OverWriteAngleTextBox.Text = "";
            return;
         }

         var radians = AnglesTrig.BaseRiseToRadian(12, Convert.ToDouble(SlopeTextBox.Text));
         var angle = Conversions.RadiansToAngle(radians);
         OverWriteAngleTextBox.Text = Convert.ToString(angle);
      }

      private void DetailingMethodRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         if (DetailingMethodRadioButton.Checked)
         {
            _MathMethod.IsDetailingMathMethod = true;
         }
         else
         {
            _MathMethod.IsDetailingMathMethod = false;
         }
      }

      private void StandardMethodRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         if (DetailingMethodRadioButton.Checked)
         {
            _MathMethod.IsDetailingMathMethod = false;
         }
         else
         {
            _MathMethod.IsDetailingMathMethod = true;
         }
      }

      private double AddNumbers(double num1, double num2, bool isDetailingMethod)
      {
         return MathFunctions.AddNumbers(num1, num2, isDetailingMethod);
      }

      private double SubtractNumbers(double num1, double num2, bool isDetailingMethod)
      {
         return MathFunctions.SubtractNumbers(num1, num2, isDetailingMethod);
      }

      private double MultiplyNumbers(double num1, double num2, bool isDetailingMethod)
      {
         return MathFunctions.MultiplyNumbers(num1, num2, isDetailingMethod);
      }

      private double DivideNumbers(double num1, double num2, bool isDetailingMethod)
      {
         return MathFunctions.DivideNumbers(num1, num2, isDetailingMethod);
      }

      private void FootToDecimal()
      {
         string userEntry = UserEntryBox.Text;
         if (userEntry != "")
         {
            var userEntryDouble = Convert.ToDouble(UserEntryBox.Text);
            userEntryDouble = Conversions.FootToDecimal(userEntryDouble);
            OutputWindow.Text = Convert.ToString(userEntryDouble);
         }
         else
         {
            var outputText = Convert.ToDouble(OutputWindow.Text);
            outputText = Conversions.FootToDecimal(outputText);
            OutputWindow.Text = Convert.ToString(outputText);
         }
      }

      private void DecimalToFoot()
      {
         string userEntry = UserEntryBox.Text;
         if (userEntry != "")
         {
            var userEntryDouble = Convert.ToDouble(UserEntryBox.Text);
            userEntryDouble = Conversions.DecimalToFoot(userEntryDouble);
            OutputWindow.Text = Convert.ToString(userEntryDouble);
         }
         else
         {
            var outputText = Convert.ToDouble(OutputWindow.Text);
            outputText = Conversions.DecimalToFoot(outputText);
            OutputWindow.Text = Convert.ToString(outputText);
         }
      }

      private void UserEntryLostFocus(object sender, EventArgs e)
      {
         WarningNumbericEntryOnlyLabel.Visible = false;
      }

      private void OuputWindowTextCopy(object sender, MouseEventArgs e)
      {
         Clipboard.SetText(OutputWindow.Text);
         ToolTip tt = new ToolTip();
         tt.AutoPopDelay = 0;
         tt.InitialDelay = 0;
         tt.SetToolTip(this.OutputWindow, "Text Copied");
      }

      private void OutputWindowClickToCopy(object sender, EventArgs e)
      {
         ToolTip tt = new ToolTip();
         tt.AutoPopDelay = 0;
         tt.InitialDelay = 0;
         tt.SetToolTip(this.OutputWindow, "Click to copy this text");
      }

      private double BaseRiseToAngle(double bayse, double rise)
      {
         var radians = AnglesTrig.BaseRiseToRadian(bayse, rise);
         var angle = Conversions.RadiansToAngle(radians);
         OverWriteAngleTextBox.Text = Convert.ToString(Conversions.RadiansToAngle(radians));
         OutputWindow.Text = Convert.ToString(Conversions.RadiansToAngle(radians));
         return angle;
      }

      private void ArithmeticFunctionsFromKeys(string function, double num1, double num2)
      {
         switch (function)
         {
            case "Add":
               AddNumbers(num1, num2, _MathMethod.IsDetailingMathMethod);
               break;
            case "Subtract":
               SubtractNumbers(num1, num2, _MathMethod.IsDetailingMathMethod);
               break;
            case "Multiply":
               MultiplyNumbers(num1, num2, _MathMethod.IsDetailingMathMethod);
               break;
            case "Divide":
               DivideNumbers(num1, num2, _MathMethod.IsDetailingMathMethod);
               break;
            default:
               break;
         }
      }
   }
}
