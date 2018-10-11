using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class MathFunctions
   {
      public static decimal AddNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 + num2;
            return Conversions.DecimalToFoot(response);
         }
         else
         {
            return num1 + num2;
         }
      }

      public static decimal SubtractNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 - num2;
            return Conversions.DecimalToFoot(response);
         }
         else
         {
            return num1 - num2;
         }
      }

      public static decimal MultiplyNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 * num2;
            return Conversions.DecimalToFoot(response);
         }
         else
         {
            return num1 * num2;
         }
      }

      public static decimal DivideNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 / num2;
            return Conversions.DecimalToFoot(response);
         }
         else
         {
            return num1 / num2;
         }
      }

      public static decimal DoMath(string function, decimal num1, decimal num2, bool isDetailingMethod)
      {
         switch (function)
         {
            case "Add":
               return AddNumbers(num1, num2, isDetailingMethod);
            case "Subtract":
               return SubtractNumbers(num1, num2, isDetailingMethod);
            case "Multiply":
               return MultiplyNumbers(num1, num2, isDetailingMethod);
            case "Divide":
               return DivideNumbers(num1, num2, isDetailingMethod);
            default:
               return 0;
         }
      }

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

      public static decimal DetermineSecondNumberForMath(int outputWindowListCount, List<decimal> outputWindowList)
      {
         return (outputWindowList.Count <= 1) ? 0 : outputWindowList[outputWindowListCount - 1];
      }

      public static decimal FootToDecimalButtonClick(int outputWindowListCount, List<decimal> outputWindowList)
      {
         return (outputWindowListCount == 0) ? 0 : Conversions.FootToDecimal(outputWindowList[outputWindowListCount - 1]);
      }

      public static decimal DecimalToFootButtonClick(int outputWindowListCount, List<decimal> outputWindowList)
      {
         return (outputWindowListCount == 0) ? 0 : Conversions.DecimalToFoot(outputWindowList[outputWindowListCount - 1]);
      }

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
   }
}
