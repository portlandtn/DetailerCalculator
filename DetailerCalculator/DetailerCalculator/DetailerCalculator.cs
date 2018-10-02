using System;
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
         this.ActiveControl = UserEntryBox;
      }

      private void BaseToRiseButton_Click(object sender, EventArgs e)
      {
         double angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         double bayse = 14;
         string rise = Convert.ToString(SidesTrig.BaseToRise(bayse, angle));
      }

      private void BaseToSlopeButton_Click(object sender, EventArgs e)
      {
         double angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.BaseToSlope(14, angle));
      }

      private void SlopeToBaseButton_Click(object sender, EventArgs e)
      {
         double angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.SlopeToBase(14, angle));
      }

      private void SlopeToRiseButton_Click(object sender, EventArgs e)
      {
         double angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.SlopeToBase(14, angle));
      }

      private void RiseToSlopeButton_Click(object sender, EventArgs e)
      {
         double angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.RiseToSlope(14, angle));
      }

      private void RiseToBaseButton_Click(object sender, EventArgs e)
      {
         double angle = Settings.CurrentAngle(_ActiveAngle.ActiveAngle, _Angle1.Angle, _Angle2.Angle, _Angle3.Angle, _Angle4.Angle);
         OutputWindow.Text = Convert.ToString(SidesTrig.RiseToBase(14, angle));
      }

      private void FootToDecimalButton_Click(object sender, EventArgs e)
      {
         var f2d = FootToDecimal(UserEntryBox.Text);
         if (f2d == 0)
         {
            return;
         }
         else
         {
            OutputWindowStringBuilder(f2d);
         }
      }
      private void DecimalToFootButton_Click(object sender, EventArgs e)
      {
         var d2f = DecimalToFoot(UserEntryBox.Text);
         if (d2f == 0)
         {
            return;
         }
         else
         {
            OutputWindowStringBuilder(d2f);
         }
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
         Regex regex = new Regex(@"[^0-9^.^\+^\-^\*^\/]");
         MatchCollection matches = regex.Matches(UserEntryBox.Text);

         if (matches.Count > 0)
         {
            WarningNumbericEntryOnlyLabel.Visible = true;
            UserEntryBox.Text = "";
         }
      }

      private void AddButton_Click(object sender, EventArgs e)
      {
         var response = MathLogicUsingOutputWindow("Add", UserEntryBox.Text);
         UserEntryBox.Text = "";
         OutputWindowStringBuilder(response);
      }

      private void SubtractButton_Click(object sender, EventArgs e)
      {
         var response = MathLogicUsingOutputWindow("Subtract", UserEntryBox.Text);
         UserEntryBox.Text = "";
         OutputWindowStringBuilder(response);
      }

      private void MultiplyButton_Click(object sender, EventArgs e)
      {
         var response = MathLogicUsingOutputWindow("Multiply", UserEntryBox.Text);
         UserEntryBox.Text = "";
         OutputWindowStringBuilder(response);
      }

      private void DivideButton_Click(object sender, EventArgs e)
      {
         var response = MathLogicUsingOutputWindow("Divide", UserEntryBox.Text);
         UserEntryBox.Text = "";
         OutputWindowStringBuilder(response);
      }

      private void DropButton_Click(object sender, EventArgs e)
      {
         _OutputWindowList.RemoveAt(_OutputWindowList.Count - 1);
         OutputWindowStringBuilder(0);

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
            OutputWindowStringBuilder(Convert.ToDouble(UserEntryBox.Text));

            UserEntryBox.Text = "";
            e.Handled = true;
            e.SuppressKeyPress = true;
         }

         if (e.KeyCode == Keys.Add)
         {
            MathLogicUsingOutputWindow("Add", UserEntryBox.Text);
         }

         if (e.KeyCode == Keys.Subtract)
         {
            MathLogicUsingOutputWindow("Subtract", UserEntryBox.Text);
         }

         if (e.KeyCode == Keys.Multiply)
         {
            MathLogicUsingOutputWindow("Multiply", UserEntryBox.Text);
         }

         if (e.KeyCode == Keys.Divide)
         {
            MathLogicUsingOutputWindow("Divide", UserEntryBox.Text);
         }
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

      private double DoMath(string function, double num1, double num2, bool isDetailingMethod)
      {
         switch (function)
         {
            case "Add":
               return MathFunctions.AddNumbers(num1, num2, isDetailingMethod);
            case "Subtract":
               return MathFunctions.SubtractNumbers(num1, num2, isDetailingMethod);
            case "Multiply":
               return MathFunctions.MultiplyNumbers(num1, num2, isDetailingMethod);
            case "Divide":
               return MathFunctions.DivideNumbers(num1, num2, isDetailingMethod);
            default:
               return 0;
         }
      }

      private double FootToDecimal(string userEntry)
      {
         if (userEntry != "")
         {
            var response = Convert.ToDouble(userEntry);
            response = Conversions.FootToDecimal(response);
            return response;
         }
         else if (_OutputWindowList.Count == 0)
         {
            return 0;
         }
         else
         {
            var response = _OutputWindowList[_OutputWindowList.Count - 1];
            response = Conversions.FootToDecimal(response);
            return response;
         }
      }

      private double DecimalToFoot(string userEntry)
      {
         if (userEntry != "")
         {
            var response = Convert.ToDouble(userEntry);
            response = Conversions.DecimalToFoot(response);
            return response;
         }
         else if (_OutputWindowList.Count == 0)
         {
            return 0;
         }
         else
         {
            var response = _OutputWindowList[_OutputWindowList.Count - 1];
            response = Conversions.DecimalToFoot(response);
            return response;
         }
      }

      private void UserEntryLostFocus(object sender, EventArgs e)
      {
         WarningNumbericEntryOnlyLabel.Visible = false;
      }

      private void OuputWindowTextCopy(object sender, MouseEventArgs e)
      {
         Clipboard.SetText(OutputWindow.Text);
         ToolTip tt = new ToolTip
         {
            AutoPopDelay = 0,
            InitialDelay = 0
         };
         tt.SetToolTip(this.OutputWindow, "Text Copied");
      }

      private void OutputWindowClickToCopy(object sender, EventArgs e)
      {
         ToolTip tt = new ToolTip
         {
            AutoPopDelay = 0,
            InitialDelay = 0
         };
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

      private void OutputWindowStringBuilder(double stringToAdd)
      {
         if (stringToAdd == 0)
         {
            OutputWindow.Text = String.Join(Environment.NewLine, _OutputWindowList);
         }
         else
         {
            _OutputWindowList.Add(stringToAdd);
            OutputWindow.Text = String.Join(Environment.NewLine, _OutputWindowList);
         }
      }

      private double MathLogicUsingOutputWindow(string function, string userEntryText)
      {
         if (userEntryText == "")
         {
            if (_OutputWindowList.Count >= 2)
            {
               double num1 = _OutputWindowList[_OutputWindowList.Count - 2];
               double num2 = _OutputWindowList[_OutputWindowList.Count - 1];
               return DoMath(function, num1, num2, _MathMethod.IsDetailingMathMethod);
            }
            else
            {
               return 0;
            }
         }
         else if (_OutputWindowList.Count <= 2)
         {
            double num1 = _OutputWindowList[_OutputWindowList.Count - 1];
            double num2 = Convert.ToDouble(UserEntryBox.Text);
            return DoMath(function, num1, num2, _MathMethod.IsDetailingMathMethod);
         }
         else
         {
            double num1 = _OutputWindowList[_OutputWindowList.Count - 2];
            double num2 = _OutputWindowList[_OutputWindowList.Count - 1];
            return DoMath(function, num1, num2, _MathMethod.IsDetailingMathMethod);
         }
      }
   }
}
