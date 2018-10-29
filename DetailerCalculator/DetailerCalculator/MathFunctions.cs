using System;
using System.Collections.Generic;

namespace DetailerCalculator
{
   /// <summary>
   /// Class designed to perform math based on various inputs/settings from the user.
   /// </summary>
   public class MathFunctions
   {
      /// <summary>
      /// Takes two numbers and adds them together. How it is added is determined from the detailing method selected.
      /// </summary>
      /// <param name="num1"></param>
      /// <param name="num2"></param>
      /// <param name="isDetailingMethod"></param>
      /// <returns></returns>
      public static decimal AddNumbers(decimal num1, decimal num2)
      {
            return num1 + num2;
      }

      /// <summary>
      /// Takes two numbers and subtracts them. How it is added is determined from the detailing method selected.
      /// </summary>
      /// <param name="num1"></param>
      /// <param name="num2"></param>
      /// <param name="isDetailingMethod"></param>
      /// <returns></returns>
      public static decimal SubtractNumbers(decimal num1, decimal num2)
      {
            return num1 - num2;
      }

      /// <summary>
      /// Takes two numbers and multiplies them. How it is added is determined from the detailing method selected.
      /// </summary>
      /// <param name="num1"></param>
      /// <param name="num2"></param>
      /// <param name="isDetailingMethod"></param>
      /// <returns></returns>
      public static decimal MultiplyNumbers(decimal num1, decimal num2)
      {
            return num1 * num2;
      }

      /// <summary>
      /// Takes two numbers and divides them. How it is added is determined from the detailing method selected.
      /// </summary>
      /// <param name="num1"></param>
      /// <param name="num2"></param>
      /// <param name="isDetailingMethod"></param>
      /// <returns></returns>
      public static decimal DivideNumbers(decimal num1, decimal num2)
      {
            return num1 / num2;
      }

      /// <summary>
      /// Performs either addition, subtractions, multiplication, or division, based on the passed in 'function' variable.
      /// </summary>
      /// <param name="function"></param>
      /// <param name="num1"></param>
      /// <param name="num2"></param>
      /// <param name="isDetailingMethod"></param>
      /// <returns></returns>
      public static decimal DoMath(string function, decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
         }
         decimal response;
         switch (function)
         {
            case "Add":
               response = AddNumbers(num1, num2);
               break;
            case "Subtract":
               response =  SubtractNumbers(num1, num2);
               break;
            case "Multiply":
               response = MultiplyNumbers(num1, num2);
               break;
            case "Divide":
               response = DivideNumbers(num1, num2);
               break;
            default:
               response = 0;
               break;
         }
         return (isDetailingMethod == true) ? Conversions.DecimalToFoot(response) : response;
      }

      /// <summary>
      /// Determines the first number to be used for a calculation from the Output Window List and the total numbers required for a calculation.
      /// If there are two numbers required, the first number will be the second one from the bottom of the list. If there is one number required,
      /// the number will be the last number in the list. If the output window is blank, the number is 0.
      /// </summary>
      /// <param name="totalNumbersRequired"></param>
      /// <param name="outputWindowListCount"></param>
      /// <param name="outputWindowList"></param>
      /// <returns></returns>
      public static decimal DetermineFirstNumberForMath(int totalNumbersRequired, int outputWindowListCount, List<decimal> outputWindowList)
      {

         if (totalNumbersRequired == 2)
         {
            return (outputWindowList.Count <= 1) ? 0 : outputWindowList[outputWindowListCount - 2];
         }
         else
         {
            return (outputWindowList.Count == 0) ? 0 : outputWindowList[outputWindowListCount - 1];
         }
      }

      /// <summary>
      /// Determines the second number to be used for a calculation from the Output Window List. If there is only one number in the list, it returns
      /// 0. Otherwise, it returns the last number in the list.
      /// </summary>
      /// <param name="outputWindowListCount"></param>
      /// <param name="outputWindowList"></param>
      /// <returns></returns>
      public static decimal DetermineSecondNumberForMath(int outputWindowListCount, List<decimal> outputWindowList)
      {
         return (outputWindowList.Count <= 1) ? 0 : outputWindowList[outputWindowListCount - 1];
      }

      /// <summary>
      /// Returns the decimal value from the last number in the Output Window list. If the number does not exist, it returns 0.
      /// </summary>
      /// <param name="outputWindowListCount"></param>
      /// <param name="outputWindowList"></param>
      /// <returns></returns>
      public static decimal FootToDecimalButtonClick(int outputWindowListCount, List<decimal> outputWindowList)
      {
         return (outputWindowListCount == 0) ? 0 : Conversions.FootToDecimal(outputWindowList[outputWindowListCount - 1]);
      }

      /// <summary>
      /// Returns the ft-in-16 value from the last number in the Output Window list. If the number does not exist, it returns 0.
      /// </summary>
      /// <param name="outputWindowListCount"></param>
      /// <param name="outputWindowList"></param>
      /// <returns></returns>
      public static decimal DecimalToFootButtonClick(int outputWindowListCount, List<decimal> outputWindowList)
      {
         return (outputWindowListCount == 0) ? 0 : Conversions.DecimalToFoot(outputWindowList[outputWindowListCount - 1]);
      }

      /// <summary>
      /// Returns a number, taking into account the detailing method selected. Trig is used to determine what formula is used.
      /// </summary>
      /// <param name="num"></param>
      /// <param name="angle"></param>
      /// <param name="function"></param>
      /// <param name="isDetailingMathMethod"></param>
      /// <returns>Returns a number.</returns>
      public static decimal TrigFunctionButtonClick(decimal num, decimal angle, string function, bool isDetailingMathMethod)
      {
         num = (isDetailingMathMethod == true) ? Conversions.FootToDecimal(num) : num;

         switch (function)
         {
            case "b2s":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(TrigFunctions.BaseToSlope(num, angle)) : TrigFunctions.BaseToSlope(num, angle);
            case "b2r":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(TrigFunctions.BaseToRise(num, angle)) : TrigFunctions.BaseToRise(num, angle);
            case "s2b":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(TrigFunctions.SlopeToBase(num, angle)) : TrigFunctions.SlopeToBase(num, angle);
            case "s2r":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(TrigFunctions.SlopeToRise(num, angle)) : TrigFunctions.SlopeToRise(num, angle);
            case "r2b":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(TrigFunctions.RiseToBase(num, angle)) : TrigFunctions.RiseToBase(num, angle);
            case "r2s":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(TrigFunctions.RiseToSlope(num, angle)) : TrigFunctions.RiseToSlope(num, angle);
            default:
               return 0;
         }
      }

      /// <summary>
      /// Uses width, length, and thickness to determine weight.
      /// </summary>
      /// <param name="width"></param>
      /// <param name="length"></param>
      /// <param name="thickness"></param>
      /// <returns>Decimal value of width, length and thickness multiplied by 0.2904.</returns>
      public static decimal CalculateWeight(decimal width, decimal length, decimal thickness)
      {
         const decimal weightPerCubicInch = 0.2904m;
         return length * width * thickness * weightPerCubicInch;
      }
   }
}
