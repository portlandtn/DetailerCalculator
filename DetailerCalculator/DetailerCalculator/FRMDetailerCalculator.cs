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
using System.Globalization;
using System.Collections.Specialized;

namespace DetailerCalculator
{
   /// <summary>
   /// Main Form. Calculator that takes user input and does various math and trig operations.
   /// </summary>
   public partial class FRMDetailerCalculator : Form
   {
      //Initialize settings for four angles, the current active angle, the method of math being used, how many decimal places are fixed.
      Settings _Angle1 = new Settings();
      Settings _Angle2 = new Settings();
      Settings _Angle3 = new Settings();
      Settings _Angle4 = new Settings();
      Settings _ActiveAngle = new Settings();
      Settings _MathMethod = new Settings();
      Settings _CurrentAngle = new Settings();
      Settings _FixedDecimal = new Settings();
      Settings _GeneralSettings = new Settings();
      List<decimal> _OutputWindowList = new List<decimal>();

      /// <summary>
      /// Initializes the main form.
      /// </summary>
      public FRMDetailerCalculator()
      {
         InitializeComponent();
      }

      private void FRMDetailerCalculator_Load(object sender, EventArgs e)
      {
         //Restores angles from previous session (soon to be output window text).
         //Defaults active angle back to the first angle, math method back to detailing.
         RestoreSettings();
         _ActiveAngle.ActiveAngle = 1;
         _MathMethod.IsDetailingMathMethod = true;
         ActiveControl = UserEntryBox;
      }

      private void BaseToRiseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("b2r", _CurrentAngle.Angle);
         UserEntryBox.Focus();
      }

      private void BaseToSlopeButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("b2s", _CurrentAngle.Angle);
         UserEntryBox.Focus();
      }

      private void SlopeToBaseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("s2b", _CurrentAngle.Angle);
         UserEntryBox.Focus();
      }

      private void SlopeToRiseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("s2r", _CurrentAngle.Angle);
         UserEntryBox.Focus();
      }

      private void RiseToSlopeButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("r2s", _CurrentAngle.Angle);
         UserEntryBox.Focus();
      }

      private void RiseToBaseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("r2b", _CurrentAngle.Angle);
         UserEntryBox.Focus();
      }

      private void FootToDecimalButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("f2d");
         UserEntryBox.Focus();
      }

      private void DecimalToFootButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("d2f");
      }

      private void AddButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Add");
         UserEntryBox.Focus();
      }

      private void SubtractButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Subtract");
         UserEntryBox.Focus();
      }

      private void MultiplyButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Multiply");
         UserEntryBox.Focus();
      }

      private void DivideButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("Divide");
         UserEntryBox.Focus();
      }

      private void DropButton_Click(object sender, EventArgs e)
      {
         DropLastNumber();
         UserEntryBox.Focus();
      }

      private void ClearAllButton_Click(object sender, EventArgs e)
      {
         _OutputWindowList.Clear();
         OutputWindow.Text = "";
         UserEntryBox.Focus();
      }

      private void PlusMinusButton_Click(object sender, EventArgs e)
      {
         OutputWindowStringBuilder(Conversions.ChangeToNegativePositive(_OutputWindowList[_OutputWindowList.Count - 1]), 1);
         UserEntryBox.Focus();
      }

      private void OverwriteAngleButton_Click(object sender, EventArgs e)
      {
         //Sets the angle text, fixed to four decimal places.
         SetAngleLabelsText(_ActiveAngle.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
         UserEntryBox.Focus();
      }

      private void EntryBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            decimal outputWindowDecimal;
            try
            {
               if (UserEntryBox.Text == "")
               {
                  outputWindowDecimal = _OutputWindowList[_OutputWindowList.Count - 1];
               }
               else
               {
                  var fixedDecimal = _FixedDecimal.FixedDecimals;
                  outputWindowDecimal = Convert.ToDecimal(UserEntryBox.Text);
               }
               OutputWindowStringBuilder(outputWindowDecimal, 0);
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
            var num1 = MathFunctions.DetermineFirstNumberForMath(2, _OutputWindowList.Count, _OutputWindowList);
            var num2 = MathFunctions.DetermineSecondNumberForMath(_OutputWindowList.Count, _OutputWindowList);
            decimal response = MathFunctions.DoMath(Convert.ToString(e.KeyCode), num1, num2, _MathMethod.IsDetailingMathMethod);
            UserEntryBox.Text = "";
            OutputWindowStringBuilder(response, 2);
            e.Handled = true;
            e.SuppressKeyPress = true;
         }

         if (e.KeyCode == Keys.Escape)
         {
            UserEntryBox.Text = "";
            e.SuppressKeyPress = true;
         }

         if (e.KeyCode == Keys.Delete)
         {
            UserEntryBox.Text = "";
            e.SuppressKeyPress = true;
            DropLastNumber();
         }
      }

      private void BaseTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            try
            {
               SetAngleLabelsText(_ActiveAngle.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
               BaseTextBox.Text = "";
               RiseTextBox.Text = "";
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
               SetAngleLabelsText(_ActiveAngle.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
               OverWriteAngleTextBox.Text = "";
               SlopeTextBox.Text = "";
               e.Handled = true;
               e.SuppressKeyPress = true;
            }

         }
      }

      private void RiseTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            try
            {
               SetAngleLabelsText(_ActiveAngle.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
               BaseTextBox.Text = "";
               RiseTextBox.Text = "";
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
      }

      private void UserEntryBox_TextChanged(object sender, EventArgs e)
      {
         //Checks to make sure the text entered is valid. If not, an error label appears telling the user to try again and clears the textbox.
         Regex regex = new Regex(@"[^0-9^.^\+^\-^\*^\/]");
         MatchCollection matches = regex.Matches(UserEntryBox.Text);
         if (UserEntryBox.Text.Contains("F"))
         {
            return;
         }
         else if (matches.Count > 0)
         {
            WarningNumericEntryOnlyLabel.Visible = true;
            UserEntryBox.Text = "";
         }
      }

      private void Angle1RadioBox_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.
         SetAngles(1, _Angle1.Angle);
      }

      private void Angle2RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.

         SetAngles(2, _Angle2.Angle);
      }

      private void Angle3RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.

         SetAngles(3, _Angle3.Angle);
      }

      private void Angle4RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.

         SetAngles(4, _Angle4.Angle);
      }

      private void SlopeTextBox_TextChanged(object sender, EventArgs e)
      {
         //Automatically calculates the roof slope, based on text entered in the slope textbox (based on 1'-0" base)
         if (SlopeTextBox.Text == "")
         {
            OverWriteAngleTextBox.Text = "";
            return;
         }
         try
         {
            var radians = TrigFunctions.BaseRiseToRadian(12, Convert.ToDecimal(SlopeTextBox.Text));
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

      private void BaseTextBox_TextChanged(object sender, EventArgs e)
      {
         //Calculates the angle based on the base and rise entered.
         //This is only active when the BRtoA button is pressed.
         if (BaseTextBox.Text == "")
         {
            OverWriteAngleTextBox.Text = "";
            return;
         }
         if (RiseTextBox.Text != "" && BaseTextBox.Text != "")
         {
            BaseRiseCalc(Convert.ToDecimal(BaseTextBox.Text), Convert.ToDecimal(RiseTextBox.Text));
         }
      }

      private void RiseTextBox_TextChanged(object sender, EventArgs e)
      {
         //Calculates the angle based on the base and rise entered.
         //This is only active when the BRtoA button is pressed.
         if (RiseTextBox.Text == "")
         {
            OverWriteAngleTextBox.Text = "";
            return;
         }
         if (RiseTextBox.Text != "" && BaseTextBox.Text != "")
         {
            BaseRiseCalc(Convert.ToDecimal(BaseTextBox.Text), Convert.ToDecimal(RiseTextBox.Text));
         }
      }

      private void RoundingNumberPicker_ValueChanged(object sender, EventArgs e)
      {
         //Sets the fixed decimals in settings with the prefix "F"
         _FixedDecimal.FixedDecimals = "F" + RoundingNumberPicker.Value;
         SetOutputListRounding();
      }

      private void OutputWindow_MouseEnter(object sender, EventArgs e)
      {
         //Output window is actually a button. This keeps the color from changing when you hover over it.
         Button b = (Button)sender;
         b.FlatAppearance.MouseOverBackColor = Color.Transparent;
      }

      private void DetailerCalculatorClosed(object sender, FormClosingEventArgs e)
      {
         if (_GeneralSettings.HaveSeenTrayIconInstructions == false)
         {
            MessageBox.Show("This program has been minimized to the tray icon. Right-click the tray icon to exit completely, or double-click to open again. " +
               "If you'd like to exit the calculator from here in the future, choose File, then Exit at the top.", "Calculator Minimized",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            _GeneralSettings.HaveSeenTrayIconInstructions = true;
         }
         Properties.Settings.Default["HaveSeenTrayIconInstructions"] = _GeneralSettings.HaveSeenTrayIconInstructions;
         SaveSettings();
         if (e.CloseReason == CloseReason.UserClosing)
         {
            Hide();
            e.Cancel = true;
         }
      }

      private void RestoreSettings()
      {
         //Restores settings from the previous session. (angles, fixed decimals). Output window text is still in progress.

         _Angle1.Angle = Convert.ToDecimal(Properties.Settings.Default["Angle1"]);
         _Angle2.Angle = Convert.ToDecimal(Properties.Settings.Default["Angle2"]);
         _Angle3.Angle = Convert.ToDecimal(Properties.Settings.Default["Angle3"]);
         _Angle4.Angle = Convert.ToDecimal(Properties.Settings.Default["Angle4"]);
         _CurrentAngle.Angle = Convert.ToDecimal(Properties.Settings.Default["CurrentAngle"]);
         _FixedDecimal.FixedDecimals = Convert.ToString(Properties.Settings.Default["FixedDecimal"]);
         _GeneralSettings.HaveSeenTrayIconInstructions = Convert.ToBoolean(Properties.Settings.Default["HaveSeenTrayIconInstructions"]);

         Angle1Label.Text = Convert.ToString(Math.Round(_Angle1.Angle, 4));
         Angle2Label.Text = Convert.ToString(Math.Round(_Angle2.Angle, 4));
         Angle3Label.Text = Convert.ToString(Math.Round(_Angle3.Angle, 4));
         Angle4Label.Text = Convert.ToString(Math.Round(_Angle4.Angle, 4));
         RoundingNumberPicker.Value = Convert.ToDecimal(_FixedDecimal.FixedDecimals.Substring(1));
      }

      private void SetAngleLabelsText(int activeAngle, decimal angleValue)
      {
         //Sets angle label text to the overwrite textbox. Sets the angle in settings to the value as well.
         switch (activeAngle)
         {
            case 1:
               _Angle1.Angle = angleValue;
               Angle1Label.Text = Convert.ToString(Math.Round(_Angle1.Angle, 4));
               break;
            case 2:
               _Angle2.Angle = angleValue;
               Angle2Label.Text = Convert.ToString(Math.Round(_Angle2.Angle, 4));
               break;
            case 3:
               _Angle3.Angle = angleValue;
               Angle3Label.Text = Convert.ToString(Math.Round(_Angle3.Angle, 4));
               break;
            case 4:
               _Angle4.Angle = angleValue;
               Angle4Label.Text = Convert.ToString(Math.Round(_Angle4.Angle, 4));
               break;
            default:
               break;
         }
         _CurrentAngle.Angle = angleValue;
         SlopeTextBox.Text = "";
         OverWriteAngleTextBox.Text = "";
      }

      private void UserEntryLostFocus(object sender, EventArgs e)
      {
         WarningNumericEntryOnlyLabel.Visible = false;
      }

      private void OutputWindowTextCopy(object sender, MouseEventArgs e)
      {
         try
         {
            Clipboard.SetText(OutputWindow.Text);
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
            return;
         }
      }

      private void OutputWindowStringBuilder()
      {
         //This method is used for the Drop function only

         TempListBuilder();
      }

      private void OutputWindowStringBuilder(decimal numberToAdd, int numbersToReplace)
      {
         //Updates the main list with values entered on the User Entry Textbox, removing numbers and replacing them as necessary, based on function.
         while (numbersToReplace > 0)
         {
            try
            {
               _OutputWindowList.RemoveAt(_OutputWindowList.Count - 1);
               numbersToReplace--;
            }
            catch (Exception)
            {
               return;
            }
         }
         _OutputWindowList.Add(numberToAdd);

         TempListBuilder();
      }

      private void TempListBuilder()
      {
         var list = new List<decimal>();
         foreach (var item in _OutputWindowList)
         {
            var itemString = item.ToString(_FixedDecimal.FixedDecimals, CultureInfo.InvariantCulture);
            list.Add(Convert.ToDecimal(itemString));
            OutputWindow.Text = "";
            OutputWindow.Text = string.Join(Environment.NewLine, list);
         }
      }

      private void FunctionButtonClick(string function)
      {
         //Calculates which numbers to use based on the function being performed.
         var num0 = MathFunctions.DetermineSecondNumberForMath(_OutputWindowList.Count, _OutputWindowList);
         var num1 = MathFunctions.DetermineFirstNumberForMath(1, _OutputWindowList.Count, _OutputWindowList);
         var num2 = MathFunctions.DetermineFirstNumberForMath(2, _OutputWindowList.Count, _OutputWindowList);

         if (function == "d2f" || function == "f2d")
         {
            //If it's a simple conversion, one number is replaced with the new number.
            var response = (function == "f2d") ? Conversions.FootToDecimal(Convert.ToDecimal(num1)) : Conversions.DecimalToFoot(Convert.ToDecimal(num1));
            OutputWindowStringBuilder(response, 1);
         }
         else
         {
            //If math is required, two numbers are replaced with the answer from both.
            decimal response = MathFunctions.DoMath(function, num2, num0, _MathMethod.IsDetailingMathMethod);
            UserEntryBox.Text = "";
            OutputWindowStringBuilder(response, 2);
         }
      }

      private void FunctionButtonClick(string function, decimal angle)
      {
         //Overloaded function that determines angles.
         var num1 = MathFunctions.DetermineFirstNumberForMath(1, _OutputWindowList.Count, _OutputWindowList);
         var response = MathFunctions.TrigFunctionButtonClick(num1, angle, function, _MathMethod.IsDetailingMathMethod);
         OutputWindowStringBuilder(response, 1);
      }

      private void SetAngles(int angleNumber, decimal actualAngle)
      {
         //Sets current and active angles for use in math based on radio button selection.
         _ActiveAngle.ActiveAngle = angleNumber;
         _CurrentAngle.Angle = actualAngle;
      }

      private void SwapButton_Click(object sender, EventArgs e)
      {
         SwapBtn(_OutputWindowList[_OutputWindowList.Count - 1], _OutputWindowList[_OutputWindowList.Count - 2]);
      }

      private void SwapBtn(decimal num1, decimal num2)
      {
         //Takes the last two numbers in the Output Window and swaps their places.
         var numB = num1;
         var numA = num2;
         _OutputWindowList.RemoveAt(_OutputWindowList.Count - 1);
         _OutputWindowList.RemoveAt(_OutputWindowList.Count - 1);

         OutputWindowStringBuilder(numB, 0);
         OutputWindowStringBuilder(numA, 0);
      }

      private void BaseRiseToAngle()
      {
         decimal angle = TrigFunctions.BaseRiseToRadian(Convert.ToDecimal(BaseTextBox.Text), Convert.ToDecimal(RiseTextBox.Text));
         angle = Conversions.RadiansToAngle(angle);
         OverWriteAngleTextBox.Text = Convert.ToString(angle);
         SetAngleLabelsText(_ActiveAngle.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
      }

      private void SetOutputListRounding()
      {
         //Creates a temporary list and iterates through the main list to come up with new numbers. 
         //This happens at every modification of the Output Window.
         var tempList = new List<decimal>();

         foreach (var item in _OutputWindowList)
         {
            var outputText = item.ToString(_FixedDecimal.FixedDecimals, CultureInfo.InvariantCulture);
            tempList.Add(Convert.ToDecimal(outputText));
            OutputWindow.Text = string.Join(Environment.NewLine, tempList);
         }
      }

      private void DropLastNumber()
      {
         if (_OutputWindowList.Count == 1)
         {
            _OutputWindowList.Clear();
            OutputWindow.Text = "";
         }
         //Removes the last number in the Output Window. If the window is blank, the exception is ignored.
         try
         {
            _OutputWindowList.RemoveAt(_OutputWindowList.Count - 1);
            OutputWindowStringBuilder();
         }
         catch (Exception)
         {
            return;
         }
      }

      private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveSettings();
         Application.Exit();
      }

      private void SaveSettings()
      {
         //Saves all settings from the current session for retrieval later.
         Properties.Settings.Default["Angle1"] = _Angle1.Angle;
         Properties.Settings.Default["Angle2"] = _Angle2.Angle;
         Properties.Settings.Default["Angle3"] = _Angle3.Angle;
         Properties.Settings.Default["Angle4"] = _Angle4.Angle;
         Properties.Settings.Default["CurrentAngle"] = _Angle1.Angle;
         Properties.Settings.Default["FixedDecimal"] = _FixedDecimal.FixedDecimals;
         Properties.Settings.Default.Save();
      }

      private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveSettings();
         SettingsSavedLabel.Visible = true;
         SettingsSavedLabel.Update();
         System.Threading.Thread.Sleep(1000);
         SettingsSavedLabel.Visible = false;
         SettingsSavedLabel.Update();
      }

      private void DropToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DropLastNumber();
      }

      private void ClearScreenToolStripMenuItem_Click(object sender, EventArgs e)
      {
         OutputWindow.Text = "";
         _OutputWindowList.Clear();
      }

      private void GeneralGuidanceToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Help.ShowHelp(this, "DetailingCalculatorHelp.chm");
      }

      private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         FRMAboutPopUp about = new FRMAboutPopUp();
         about.Show();
      }

      private void RightClickMenu_Opening(object sender, CancelEventArgs e)
      {

      }

      private void Exit_Click(object sender, EventArgs e)
      {
         SaveSettings();
         Application.Exit();
      }

      private void ShowTheForm(object sender, MouseEventArgs e)
      {
         Show();
         BringToFront();
      }

      private void BaseRiseCalc(decimal bayse, decimal rise)
      {
         if (_MathMethod.IsDetailingMathMethod == true)
         {
            bayse = Conversions.FootToDecimal(Convert.ToDecimal(bayse));
            rise = Conversions.FootToDecimal(Convert.ToDecimal(rise));
         }
         try
         {
            var radians = TrigFunctions.BaseRiseToRadian(bayse, rise);
            var angle = Conversions.RadiansToAngle(radians);
            OverWriteAngleTextBox.Text = Convert.ToString(angle);
         }
         catch (Exception)
         {
            BaseTextBox.Text = "";
            MessageBox.Show("Please include a 0 before any number smaller than 1. (i.e. 0.5 instead of .5)");
            return;
         }
      }

      private void HipValleyButton_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Feature Coming Soon");
      }
   }
}
