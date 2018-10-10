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
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 + num2, 4);
         }
      }

      public static decimal SubtractNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 - num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 - num2, 4);
         }
      }

      public static decimal MultiplyNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 * num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 * num2, 4);
         }
      }

      public static decimal DivideNumbers(decimal num1, decimal num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(num1);
            num2 = Conversions.FootToDecimal(num2);
            var response = num1 / num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 / num2, 4);
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
   }
}
