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
using static System.Drawing.Printing.PrinterSettings;
using StringCollection = System.Collections.Specialized.StringCollection;

namespace DetailerCalculator
{
   /// <summary>
   /// Main Form. Calculator that takes user input and does various math and trig operations.
   /// </summary>
   public partial class FRMDetailerCalculator : Form
   {
      //Initialize settings for four angles, the current active angle, the method of math being used, how many decimal places are fixed.
      List<decimal> _OutputWindowList = new List<decimal>();
      Settings _Settings = new Settings();
      Stack<List<decimal>> undoRedoStack = new Stack<List<decimal>>();

      /// <summary>
      /// Initializes the main form.
      /// </summary>
      public FRMDetailerCalculator()
      {
         InitializeComponent();
      }

      private void FRMDetailerCalculator_Load(object sender, EventArgs e)
      {
         //Restores angles from previous session.
         //Defaults active angle back to the first angle, math method back to detailing.
         RestoreSettings();
         _Settings.ActiveAngle = 1;
         _Settings.IsDetailingMathMethod = true;
         _Settings.LengthIsInFeet = true;
         _Settings.WidthIsInFeet = false;
         _Settings.WeightFormIsShown = false;
         ActiveControl = UserEntryBox;
      }

      private void BaseToRiseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("b2r", _Settings.CurrentAngle);
         UserEntryBox.Focus();
      }

      private void BaseToSlopeButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("b2s", _Settings.CurrentAngle);
         UserEntryBox.Focus();
      }

      private void SlopeToBaseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("s2b", _Settings.CurrentAngle);
         UserEntryBox.Focus();
      }

      private void SlopeToRiseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("s2r", _Settings.CurrentAngle);
         UserEntryBox.Focus();
      }

      private void RiseToSlopeButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("r2s", _Settings.CurrentAngle);
         UserEntryBox.Focus();
      }

      private void RiseToBaseButton_Click(object sender, EventArgs e)
      {
         FunctionButtonClick("r2b", _Settings.CurrentAngle);
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
         OverwriteAngles(_Settings.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
         UserEntryBox.Focus();
      }

      private void EntryBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            WarningNumericEntryOnlyLabel.Visible = false;
            decimal outputWindowDecimal;
            try
            {
               if (UserEntryBox.Text == "")
               {
                  outputWindowDecimal = _OutputWindowList[_OutputWindowList.Count - 1];
               }
               else
               {
                  var fixedDecimal = _Settings.FixedDecimals;
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
            decimal response = MathFunctions.DoMath(Convert.ToString(e.KeyCode), num1, num2, _Settings.IsDetailingMathMethod);
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
               OverwriteAngles(_Settings.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
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
               OverwriteAngles(_Settings.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
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
               OverwriteAngles(_Settings.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
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
         if (TextValidation(UserEntryBox.Text) == false)
         {
            UserEntryBox.Text = "";
            WarningNumericEntryOnlyLabel.Visible = true;
         }
      }

      private void Angle1RadioBox_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.
         SetActiveAngle(1, _Settings.Angle1);
      }

      private void Angle2RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.

         SetActiveAngle(2, _Settings.Angle2);
      }

      private void Angle3RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.

         SetActiveAngle(3, _Settings.Angle3);
      }

      private void Angle4RadioButton_CheckedChanged(object sender, EventArgs e)
      {
         //Changes the settings to make the current active angle # match the radio button, as well as the angle value used for calculations.

         SetActiveAngle(4, _Settings.Angle4);
      }

      private void SlopeTextBox_TextChanged(object sender, EventArgs e)
      {
         if (TextValidation(SlopeTextBox.Text) == false)
         {
            SlopeTextBox.Text = "";
            return;
         }
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
         _Settings.IsDetailingMathMethod = DetailingMethodRadioButton.Checked ? true : false;
      }

      private void StandardMethodRadioButton_CheckedChanged(object sender, EventArgs e)
      {
         _Settings.IsDetailingMathMethod = StandardMethodRadioButton.Checked ? false : true;
      }

      private void BaseTextBox_TextChanged(object sender, EventArgs e)
      {
         if (TextValidation(BaseTextBox.Text) == false)
         {
            BaseTextBox.Text = "";
            return;
         }
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
         if (TextValidation(RiseTextBox.Text) == false)
         {
            RiseTextBox.Text = "";
         }
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
         _Settings.FixedDecimals = "F" + RoundingNumberPicker.Value;
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
         if (_Settings.HaveSeenTrayIconInstructions == false)
         {
            MessageBox.Show("This program has been minimized to the tray icon. Right-click the tray icon to exit completely, or double-click to open again. " +
               "If you'd like to exit the calculator from here in the future, choose File, then Exit at the top.", "Calculator Minimized",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            _Settings.HaveSeenTrayIconInstructions = true;
         }
         Properties.Settings.Default["HaveSeenTrayIconInstructions"] = _Settings.HaveSeenTrayIconInstructions;
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

         

            _Settings.Angle1 = Convert.ToDecimal(Properties.Settings.Default.Angle1);
         _Settings.Angle2 = Convert.ToDecimal(Properties.Settings.Default.Angle2);
         _Settings.Angle3 = Convert.ToDecimal(Properties.Settings.Default.Angle3);
         _Settings.Angle4 = Convert.ToDecimal(Properties.Settings.Default.Angle4);
         _Settings.CurrentAngle = Convert.ToDecimal(Properties.Settings.Default.CurrentAngle);
         _Settings.FixedDecimals = Convert.ToString(Properties.Settings.Default.FixedDecimal);
         _Settings.HaveSeenTrayIconInstructions = Convert.ToBoolean(Properties.Settings.Default.HaveSeenTrayIconInstructions);
         StringCollection stringCollection = new StringCollection();
         stringCollection = Properties.Settings.Default.OutputWindowStringCollection;

         List<string> stringList = new List<string>();
         stringList = stringCollection.Cast<string>().ToList();
         foreach (var item in stringList)
         {
            _OutputWindowList.Add(Convert.ToDecimal(item));
         }

         Angle1Label.Text = Convert.ToString(Math.Round(_Settings.Angle1, 4));
         Angle2Label.Text = Convert.ToString(Math.Round(_Settings.Angle2, 4));
         Angle3Label.Text = Convert.ToString(Math.Round(_Settings.Angle3, 4));
         Angle4Label.Text = Convert.ToString(Math.Round(_Settings.Angle4, 4));
         RoundingNumberPicker.Value = Convert.ToDecimal(_Settings.FixedDecimals.Substring(1));
         OutputWindowStringBuilder();
      }

      private void SetActiveAngle(int angleNumber, decimal angleValue)
      {
         //Sets current and active angles for use in math based on radio button selection.
         _Settings.ActiveAngle = angleNumber;
         _Settings.CurrentAngle = angleValue;
      }

      private void OverwriteAngles(int activeAngle, decimal angleValue)
      {
         //Sets angle label text to the overwrite textbox. Sets the angle in settings to the value as well.
         switch (activeAngle)
         {
            case 1:
               _Settings.Angle1 = angleValue;
               break;
            case 2:
               _Settings.Angle2 = angleValue;
               break;
            case 3:
               _Settings.Angle3 = angleValue;
               break;
            case 4:
               _Settings.Angle4 = angleValue;
               break;
            default:
               break;
         }
         UpdateAngleLabels();
         _Settings.CurrentAngle = angleValue;
         SlopeTextBox.Text = "";
         OverWriteAngleTextBox.Text = "";
      }

      private void UpdateAngleLabels()
      {
         Angle1Label.Text = Convert.ToString(Math.Round(_Settings.Angle1, 4));
         Angle2Label.Text = Convert.ToString(Math.Round(_Settings.Angle2, 4));
         Angle3Label.Text = Convert.ToString(Math.Round(_Settings.Angle3, 4));
         Angle4Label.Text = Convert.ToString(Math.Round(_Settings.Angle4, 4));
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
         //This method is used for the Drop function and restoring numbers from previous session only.
         OutputWindowTextBuilder();
         undoRedoStack.Push(_OutputWindowList);
         UndoButton.Enabled = true;
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

         OutputWindowTextBuilder();

         UndoStackBuilder();
      }

      private void UndoStackBuilder()
      {
         List<decimal> tempListForUndoRedo = new List<decimal>();

         foreach (var item in _OutputWindowList)
         {
            tempListForUndoRedo.Add(item);
         }

         undoRedoStack.Push(tempListForUndoRedo);
         UndoButton.Enabled = true;
      }

      private void OutputWindowTextBuilder()
      {
         var list = new List<decimal>();
         const int maxItemsInWindow = 16;

         OutputWindow.Text = "";

         if (_OutputWindowList.Count() <= maxItemsInWindow)
         {
            foreach (var item in _OutputWindowList)
            {
               var itemString = item.ToString(_Settings.FixedDecimals, CultureInfo.InvariantCulture);
               list.Add(Convert.ToDecimal(itemString));
               OutputWindow.Text = "";
               OutputWindow.Text = string.Join(Environment.NewLine, list);
            }
         }
         else
         {
            try
            {
               for (int i = maxItemsInWindow; i >= 0; i--)
               {
                  var itemString = _OutputWindowList[_OutputWindowList.Count() - i].ToString(_Settings.FixedDecimals, CultureInfo.InvariantCulture);
                  list.Add(Convert.ToDecimal(itemString));
                  OutputWindow.Text = string.Join(Environment.NewLine, list);
               }
            }
            catch (ArgumentOutOfRangeException)
            {
               for (int i = maxItemsInWindow; i >= 0; i--)
               {
                  var itemString = _OutputWindowList[_OutputWindowList.Count() - i - 1].ToString(_Settings.FixedDecimals, CultureInfo.InvariantCulture);
                  list.Add(Convert.ToDecimal(itemString));
                  OutputWindow.Text = string.Join(Environment.NewLine, list);
               }
            }
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
            decimal response = MathFunctions.DoMath(function, num2, num0, _Settings.IsDetailingMathMethod);
            UserEntryBox.Text = "";
            OutputWindowStringBuilder(response, 2);
         }
      }

      private void FunctionButtonClick(string function, decimal angle)
      {
         //Overloaded function that determines angles.
         var num1 = MathFunctions.DetermineFirstNumberForMath(1, _OutputWindowList.Count, _OutputWindowList);
         var response = MathFunctions.TrigFunctionButtonClick(num1, angle, function, _Settings.IsDetailingMathMethod);
         OutputWindowStringBuilder(response, 1);
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
         OverwriteAngles(_Settings.ActiveAngle, Convert.ToDecimal(OverWriteAngleTextBox.Text));
      }

      private void SetOutputListRounding()
      {
         //Creates a temporary list and iterates through the main list to come up with new numbers. 
         //This happens at every modification of the Output Window.
         var tempList = new List<decimal>();

         foreach (var item in _OutputWindowList)
         {
            var outputText = item.ToString(_Settings.FixedDecimals, CultureInfo.InvariantCulture);
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
         StringCollection stringCollection = new StringCollection();
         foreach (var item in _OutputWindowList)
         {
            stringCollection.Add(Convert.ToString(item));
         }

         //Saves all settings from the current session for retrieval later.
         Properties.Settings.Default.Angle1 = _Settings.Angle1;
         Properties.Settings.Default.Angle2 = _Settings.Angle2;
         Properties.Settings.Default.Angle3 = _Settings.Angle3;
         Properties.Settings.Default.Angle4 = _Settings.Angle4;
         Properties.Settings.Default.CurrentAngle = _Settings.CurrentAngle;
         Properties.Settings.Default.FixedDecimal = _Settings.FixedDecimals;
         Properties.Settings.Default.OutputWindowStringCollection = stringCollection;
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
         if (_Settings.IsDetailingMathMethod == true)
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

      private bool TextValidation(string textToCheck)
      {
         //Checks to make sure the text entered is valid. If not, an error label appears telling the user to try again and clears the textbox.
         Regex regex = new Regex(@"[^0-9^.^\+^\-^\*^\/]");
         MatchCollection matches = regex.Matches(textToCheck);
         return matches.Count > 0 ? false : true;
      }

      private void OverWriteAngleTextBox_TextChanged(object sender, EventArgs e)
      {
         if (TextValidation(OverWriteAngleTextBox.Text) == false)
         {
            OverWriteAngleTextBox.Text = "";
         }
      }

      private void KeepOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         TopMost = KeepOnTopCheckBox.Checked ? true : false;
      }

      private void CalculateWeightButton_Click(object sender, EventArgs e)
      {
         if (_Settings.WeightFormIsShown == false)
         {
            _Settings.WeightFormIsShown = true;
            SetVisibility(true);
            CalculateWeightButton.Text = "Hide Weight";
            LengthTextBox.Focus();
         }
         else
         {
            _Settings.WeightFormIsShown = false;
            SetVisibility(false);
            CalculateWeightButton.Text = "Calc Weight";
            UserEntryBox.Focus();
         }
      }

      private void PushToOutputButton_Click(object sender, EventArgs e)
      {
         OutputWindowStringBuilder(DetermineWeight(), 0);
         LengthTextBox.Text = "";
         WidthTextBox.Text = "";
         ThicknessNumberPicker.Value = 0;
         UserEntryBox.Focus();
      }

      private void LengthTextBox_TextChanged(object sender, EventArgs e)
      {
         DetermineWeight();
      }

      private void WidthTextBox_TextChanged(object sender, EventArgs e)
      {
         DetermineWeight();
      }

      private void ThicknessNumberPicker_ValueChanged(object sender, EventArgs e)
      {
         DetermineWeight();
      }

      private void SetVisibility(bool visible)
      {
         List<Label> labels = new List<Label> { LengthLabel, WidthLabel, ThicknessLabel, TotalWeightLabel, InchLabel, FeetLabel };
         List<TextBox> textBoxes = new List<TextBox> { LengthTextBox, WidthTextBox, };
         List<RadioButton> radioButtons = new List<RadioButton> { InchRadioButtonLength, FeetRadioButtonLength, InchRadioButtonWidth, FeetRadioButtonWidth };

         foreach (var item in labels)
         {
            item.Visible = visible;
         }
         foreach (var item in textBoxes)
         {
            item.Visible = visible;
         }
         foreach (var item in radioButtons)
         {
            item.Visible = visible;
         }

         ThicknessNumberPicker.Visible = visible;
         PushToOutputWindowButton.Visible = visible;
      }

      private void InchRadioButtonLength_CheckedChanged(object sender, EventArgs e)
      {
         _Settings.LengthIsInFeet = InchRadioButtonLength.Checked ? false : true;
      }

      private void FeetRadioButtonLength_CheckedChanged(object sender, EventArgs e)
      {
         _Settings.LengthIsInFeet = FeetRadioButtonLength.Checked ? true : false;
      }

      private void InchRadioButtonWidth_CheckedChanged(object sender, EventArgs e)
      {
         _Settings.WidthIsInFeet = InchRadioButtonWidth.Checked ? false : true;
      }

      private void FeetRadioButtonWidth_CheckedChanged(object sender, EventArgs e)
      {
         _Settings.WidthIsInFeet = FeetRadioButtonWidth.Checked ? true : false;
      }

      private decimal DetermineWeight()
      {
         decimal weight;
         if (WidthTextBox.Text == "" || LengthTextBox.Text == "" || ThicknessNumberPicker.Value == 0)
         {
            weight = 0;
         }
         else
         {
            var length = Conversions.DetermineDimensionForWeightCalculations(Convert.ToDecimal(LengthTextBox.Text),
               _Settings.IsDetailingMathMethod,
               _Settings.LengthIsInFeet);
            var width = Conversions.DetermineDimensionForWeightCalculations(Convert.ToDecimal(WidthTextBox.Text),
               _Settings.IsDetailingMathMethod,
               _Settings.WidthIsInFeet);
            weight = MathFunctions.CalculateWeight(width, length, ThicknessNumberPicker.Value);
         }
         TotalWeightLabel.Text = "Weight: " + Convert.ToString(Math.Round(weight, 6));
         return weight;
      }

      private void UndoButton_Click(object sender, EventArgs e)
      {
         _OutputWindowList.Clear();
         List<decimal> list = new List<decimal>();

         list = undoRedoStack.Peek();
         foreach (var item in list)
         {
            OutputWindowStringBuilder(item, 0);
            undoRedoStack.Pop();
         }
         UndoButton.Enabled = undoRedoStack.Count < 1 ? false : true;
      }

      private void RedoButton_Click(object sender, EventArgs e)
      {

      }
   }
}
