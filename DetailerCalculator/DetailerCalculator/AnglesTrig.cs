using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class AnglesTrig
   {

      public static decimal BaseRiseToRadian(decimal bayse, decimal rise)
      {
         return Convert.ToDecimal(Math.Atan(Convert.ToDouble(rise / bayse)));
      }
   }
}
