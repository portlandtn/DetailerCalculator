using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class MathFunctions
   {
      public double AddNumbers(double num1, double num2, bool detailingMath)
      {
         if (detailingMath == true)
         {
            Conversions trig = new Conversions();
            var num1ft = trig.FootToDecimal(num1);
            var num2ft = trig.FootToDecimal(num2);

            return Math.Round(trig.DecimalToFoot(num1ft + num2ft), 4);
         }
         else
         {
            return Math.Round(num1 + num2, 4);
         }
      }

      public double SubtractNumbers(double num1, double num2, bool detailingMath)
      {
         if (detailingMath == true)
         {
            Conversions trig = new Conversions();
            var num1ft = trig.FootToDecimal(num1);
            var num2ft = trig.FootToDecimal(num2);

            return Math.Round(trig.DecimalToFoot(num1ft - num2ft), 4);
         }
         else
         {
            return Math.Round(num1 - num2, 4);
         }
      }

      public double MultiplyNumbers(double num1, double num2, bool detailingMath)
      {

         if (detailingMath == true)
         {
            Conversions trig = new Conversions();
            var num1ft = trig.FootToDecimal(num1);
            var num2ft = trig.FootToDecimal(num2);
            return Math.Round(trig.DecimalToFoot(num1ft * num2ft), 4);
         }
         else
         {
            return Math.Round(num1 * num2, 4);
         }
      }

      public double DivideNumbers(double num1, double num2, bool detailingMath)
      {

         if (detailingMath == true)
         {
            Conversions trig = new Conversions();
            var num1ft = trig.FootToDecimal(num1);
            var num2ft = trig.FootToDecimal(num2);
            return Math.Round(trig.DecimalToFoot(num1ft / num2ft), 4);
         }
         else
         {
            return Math.Round(num1 / num2, 4);
         }
      }
   }
}
