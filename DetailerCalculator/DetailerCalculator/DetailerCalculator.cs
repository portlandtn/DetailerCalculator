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
      Settings _CurrentAngle = new Settings();
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
         ActiveControl = UserEntryBox;
      }

      private void BaseToRiseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("b2r", _CurrentAngle.Angle);
      }

      private void BaseToSlopeButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("b2s", _CurrentAngle.Angle);
      }

      private void SlopeToBaseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("s2b", _CurrentAngle.Angle);
      }

      private void SlopeToRiseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("s2r", _CurrentAngle.Angle);
      }

      private void RiseToSlopeButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("r2s", _CurrentAngle.Angle);
      }

      private void RiseToBaseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("r2b", _CurrentAngle.Angle);
      }

      private void FootToDecimalButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("f2d");
      }

      private void DecimalToFootButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("d2f");
      }

      public void Angle1RadioBox_CheckedChanged(object sender, EventArgs e)
      {
         SetAngles(1);
      }

      private void Angle2RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         SetAngles(2);
      }

      private void Angle3RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         SetAngles(3);
      }

      private void Angle4RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         SetAngles(4);
      }

      private void OverwriteAngleButton_Click(object sender, EventArgs e)
      {

         SetAngleLabelsText(_ActiveAngle.ActiveAngle);
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
         FunctionButtonClick("Add");
      }

      private void SubtractButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Subtract");
      }

      private void MultiplyButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Multiply");
      }

      private void DivideButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Divide");
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
         var bayse = Settings.DetermineFirstNumberForMath(2, _OutputWindowList.Count, _OutputWindowList);
         var rise = Settings.DetermineSecondNumberForMath(_OutputWindowList.Count, _OutputWindowList);
         SetBaseRiseToAngle(bayse, rise);
      }

      private void EntryBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            try
            {
               double outputWindowDouble = (UserEntryBox.Text == "") ? _OutputWindowList[_OutputWindowList.Count - 1] : Convert.ToDouble(UserEntryBox.Text);
               OutputWindowStringBuilder(outputWindowDouble);
            }
            catch (Exception)
            {
               return;
            }
            finally
            {
               UserEntryBox.Text = "";
               e.Handled = true;
               e.SuppressKeyPress = true;
            }
         }

         if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
         {
            var num1 = Settings.DetermineFirstNumberForMath(2, _OutputWindowList.Count, _OutputWindowList);
            var num2 = Settings.DetermineSecondNumberForMath(_OutputWindowList.Count, _OutputWindowList);
            double response = MathFunctions.DoMath(Convert.ToString(e.KeyCode), num1, num2, _MathMethod.IsDetailingMathMethod);
            UserEntryBox.Text = "";
            OutputWindowStringBuilder(response);
            e.Handled = true;
            e.SuppressKeyPress = true;
         }

         if (e.KeyCode == Keys.Escape)
         {
            UserEntryBox.Text = "";
            e.SuppressKeyPress = true;
         }
      }

      private void OverwiteAngleTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            if (OverWriteAngleTextBox.Text == "")
            {
               e.SuppressKeyPress = true;
               return;
            }
            else
            {
               SetAngleLabelsText(_ActiveAngle.ActiveAngle);
               OverWriteAngleTextBox.Text = "";
               SlopeTextBox.Text = "";
               e.Handled = true;
               e.SuppressKeyPress = true;
            }

         }
      }

      private void SlopeTextBox_TextChanged(object sender, EventArgs e)
      {
         if (SlopeTextBox.Text == "")
         {
            OverWriteAngleTextBox.Text = "";
            return;
         }
         try
         {
            var radians = AnglesTrig.BaseRiseToRadian(12, Convert.ToDouble(SlopeTextBox.Text));
            var angle = Conversions.RadiansToAngle(radians);
            OverWriteAngleTextBox.Text = Convert.ToString(angle);
         }
         catch (Exception)
         {
            SlopeTextBox.Text = "";
            MessageBox.Show("Please include a 0 before any number smaller than 1. (i.e. 0.5 instead of .5)");
            return;
         }
      }

      private void DetailingMethodRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         _MathMethod.IsDetailingMathMethod = DetailingMethodRadioButton.Checked ? true : false;
      }

      private void StandardMethodRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         _MathMethod.IsDetailingMathMethod = StandardMethodRadioButton.Checked ? false : true;
      }

      private void DetailerCalculatorClosed(object sender, FormClosingEventArgs e)
      {
         Properties.Settings.Default["Angle1"] = _Angle1.Angle;
         Properties.Settings.Default["Angle2"] = _Angle2.Angle;
         Properties.Settings.Default["Angle3"] = _Angle3.Angle;
         Properties.Settings.Default["Angle4"] = _Angle4.Angle;
         Properties.Settings.Default["CurrentAngle"] = _Angle1.Angle;
         Properties.Settings.Default.Save();
      }

      public void RestoreSettings()
      {
         OutputWindow.Text = Convert.ToString(Properties.Settings.Default["OutputWindow"]);

         _Angle1.Angle = Convert.ToDouble(Properties.Settings.Default["Angle1"]);
         _Angle2.Angle = Convert.ToDouble(Properties.Settings.Default["Angle2"]);
         _Angle3.Angle = Convert.ToDouble(Properties.Settings.Default["Angle3"]);
         _Angle4.Angle = Convert.ToDouble(Properties.Settings.Default["Angle4"]);
         _CurrentAngle.Angle = Convert.ToDouble(Properties.Settings.Default["CurrentAngle"]);

         Angle1Label.Text = Convert.ToString(Math.Round(_Angle1.Angle, 4));
         Angle2Label.Text = Convert.ToString(Math.Round(_Angle2.Angle, 4));
         Angle3Label.Text = Convert.ToString(Math.Round(_Angle3.Angle, 4));
         Angle4Label.Text = Convert.ToString(Math.Round(_Angle4.Angle, 4));
      }

      public void SetAngleLabelsText(int activeAngle)
      {
         switch (activeAngle)
         {
            case 1:
               _Angle1.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               var angle = Math.Round(_Angle1.Angle, 4);
               Angle1Label.Text = Convert.ToString(angle);
               _CurrentAngle.Angle = _Angle1.Angle;
               SlopeTextBox.Text = "";
               OverWriteAngleTextBox.Text = "";
               break;
            case 2:
               _Angle2.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               angle = Math.Round(_Angle2.Angle, 4);
               Angle2Label.Text = Convert.ToString(angle);
               _CurrentAngle.Angle = _Angle2.Angle;
               SlopeTextBox.Text = "";
               OverWriteAngleTextBox.Text = "";
               break;
            case 3:
               _Angle3.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               angle = Math.Round(_Angle3.Angle, 4);
               Angle3Label.Text = Convert.ToString(angle);
               _CurrentAngle.Angle = _Angle3.Angle;
               SlopeTextBox.Text = "";
               OverWriteAngleTextBox.Text = "";
               break;
            case 4:
               _Angle4.Angle = Convert.ToDouble(OverWriteAngleTextBox.Text);
               angle = Math.Round(_Angle4.Angle, 4);
               Angle4Label.Text = Convert.ToString(angle);
               _CurrentAngle.Angle = _Angle4.Angle;
               SlopeTextBox.Text = "";
               OverWriteAngleTextBox.Text = "";
               break;
            default:
               MessageBox.Show("Angle was not detected");
               break;
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

      private void SetBaseRiseToAngle(double bayse, double rise)
      {
         var radians = AnglesTrig.BaseRiseToRadian(bayse, rise);
         var angle = Conversions.RadiansToAngle(radians);
         OverWriteAngleTextBox.Text = Convert.ToString(angle);
         OutputWindow.Text = Convert.ToString(angle);
      }

      private void OutputWindowStringBuilder(double stringToAdd)
      {
         if (stringToAdd == 0)
         {
            OutputWindow.Text = string.Join(Environment.NewLine, _OutputWindowList);
         }
         else
         {
            _OutputWindowList.Add(stringToAdd);
            OutputWindow.Text = string.Join(Environment.NewLine, _OutputWindowList);
         }

         if (_OutputWindowList.Count > 15)
         {
            _OutputWindowList.RemoveAt(0);
         }
      }

      private void FunctionButtonClick(string function)
      {
         var num1 = Settings.DetermineFirstNumberForMath(2, _OutputWindowList.Count, _OutputWindowList);
         var num2 = Settings.DetermineSecondNumberForMath(_OutputWindowList.Count, _OutputWindowList);

         if (function == "d2f" || function == "f2d")
         {
            var response = (function == "f2d") ? Conversions.FootToDecimal(num1) : Conversions.DecimalToFoot(num1);
            OutputWindowStringBuilder(Math.Round(response, 4));
         }
         else
         {
            double response = MathFunctions.DoMath(function, num1, num2, _MathMethod.IsDetailingMathMethod);
            UserEntryBox.Text = "";
            OutputWindowStringBuilder(Math.Round(response, 4));
         }
      }

      private void FunctionButtonClick(string function, double angle)
      {
         var num1 = Settings.DetermineFirstNumberForMath(1, _OutputWindowList.Count, _OutputWindowList);
         var response = Settings.TrigFunctionButtonClick(num1, angle, function, _MathMethod.IsDetailingMathMethod);
         OutputWindowStringBuilder(Math.Round(response, 4));
      }

      private void SetAngles(int angleNumber)
      {
         switch (angleNumber)
         {
            case 1:
               _ActiveAngle.ActiveAngle = 1;
               _CurrentAngle.Angle = _Angle1.Angle;
               break;
            case 2:
               _ActiveAngle.ActiveAngle = 2;
               _CurrentAngle.Angle = _Angle2.Angle;
               break;
            case 3:
               _ActiveAngle.ActiveAngle = 3;
               _CurrentAngle.Angle = _Angle3.Angle;
               break;
            case 4:
               _ActiveAngle.ActiveAngle = 4;
               _CurrentAngle.Angle = _Angle4.Angle;
               break;
            default:
               break;
         }
      }
   }
}
