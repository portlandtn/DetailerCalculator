using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class SidesTrig
   {
      public static decimal BaseRiseToSlope(decimal bayse, decimal rise)
      {
         return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble((bayse * bayse) + (rise * rise))));
      }

      public static decimal BaseToSlope(decimal bayse, decimal angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         return bayse / Convert.ToDecimal((Math.Sin(Convert.ToDouble(radianB))));
      }

      public static decimal BaseToRise(decimal bayse, decimal angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         return bayse / Convert.ToDecimal(Math.Tan(Convert.ToDouble(radianB)));
      }

      public static decimal SlopeToBase(decimal slope, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return Convert.ToDecimal(Math.Cos(Convert.ToDouble(radianA))) * slope;
      }

      public static decimal SlopeToRise(decimal slope, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return Convert.ToDecimal(Math.Sin(Convert.ToDouble(radianA))) * slope;
      }

      public static decimal RiseToBase(decimal rise, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return rise / Convert.ToDecimal(Math.Tan(Convert.ToDouble(radianA)));
      }

      public static decimal RiseToSlope(decimal rise, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return rise / Convert.ToDecimal(Math.Sin(Convert.ToDouble(radianA)));
      }
   }
}
