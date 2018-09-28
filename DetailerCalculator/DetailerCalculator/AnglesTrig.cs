using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class AnglesTrig
   {

      public double BaseRiseToAngle(double userBase, double rise)
      {
         Conversions c = new Conversions();
         userBase = c.FootToDecimal(userBase);
         rise = c.FootToDecimal(rise);
         var radianA = Math.Atan(rise / userBase);
         var angle = c.RadiansToAngle(radianA);
         return angle;
      }
   }
}
