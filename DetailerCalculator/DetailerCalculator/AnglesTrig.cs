using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class AnglesTrig
   {

      public static double BaseRiseToRadian(double bayse, double rise)
      {
         return Math.Atan(rise / bayse);
      }
   }
}
