using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class MathFunctions
   {
      public static double AddNumbers(double num1, double num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(Convert.ToDouble(num1));
            num2 = Conversions.FootToDecimal(Convert.ToDouble(num2));
            var response = num1 + num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 + num2, 4);
         }
      }

      public static double SubtractNumbers(double num1, double num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(Convert.ToDouble(num1));
            num2 = Conversions.FootToDecimal(Convert.ToDouble(num2));
            var response = num1 - num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 - num2, 4);
         }
      }

      public static double MultiplyNumbers(double num1, double num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(Convert.ToDouble(num1));
            num2 = Conversions.FootToDecimal(Convert.ToDouble(num2));
            var response = num1 * num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 * num2, 4);
         }
      }

      public static double DivideNumbers(double num1, double num2, bool isDetailingMethod)
      {
         if (isDetailingMethod == true)
         {
            num1 = Conversions.FootToDecimal(Convert.ToDouble(num1));
            num2 = Conversions.FootToDecimal(Convert.ToDouble(num2));
            var response = num1 / num2;
            return Math.Round((Conversions.DecimalToFoot(response)), 4);
         }
         else
         {
            return Math.Round(num1 / num2, 4);
         }
      }

      public static double DoMath(string function, double num1, double num2, bool isDetailingMethod)
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
   }
}
