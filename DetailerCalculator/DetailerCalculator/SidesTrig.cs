using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class SidesTrig
   {
      public static double BaseRiseToSlope(double bayse, double rise)
      {
         return Math.Sqrt((bayse * bayse) + (rise * rise));
      }

      public static double BaseToSlope(double bayse, double angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         return bayse / Math.Sin(radianB);
      }

      public static double BaseToRise(double bayse, double angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         return bayse / Math.Tan(radianB);
      }

      public static double SlopeToBase(double slope, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return Math.Cos(radianA) * slope;
      }

      public static double SlopeToRise(double slope, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return Math.Sin(radianA) * slope;
      }

      public static double RiseToBase(double rise, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return rise / Math.Tan(radianA);
      }

      public static double RiseToSlope(double rise, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return rise / Math.Sin(radianA);
      }
   }
}
