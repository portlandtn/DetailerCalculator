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
            return num1 + num2;
         }
         else
         {
            return num1 + num2;
         }
      }

      public double MultiplyNumbers(double num1, double num2, bool detailingMath)
      {
         if (detailingMath == true)
         {
            return num1 * num2;
         }
         else
         {
            return num1 * num2;
         }
      }
   }
}
