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
         double slope = Math.Sqrt((bayse * bayse) + (rise * rise));
         return Math.Round(slope, 4);
      }

      public static double BaseToSlope(double bayse, double angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         double slope = bayse / Math.Sin(radianB);
         return Math.Round(slope, 4);
      }

      public static double BaseToRise(double bayse, double angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         double rise = bayse / Math.Tan(radianB);
         return Math.Round(rise, 4);
      }

      public static double SlopeToBase(double slope, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         var bayse = Math.Cos(radianA) * slope;
         return Math.Round(bayse,4);
      }

      public static double SlopeToRise(double slope, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         var rise = Math.Sin(radianA) * slope;
         return Math.Round(rise,4);
      }

      public static double RiseToBase(double rise, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         var bayse = rise / Math.Tan(radianA);
         return Math.Round(bayse,4);
      }

      public static double RiseToSlope(double rise, double angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         var slope = rise / Math.Sin(radianA);
         return Math.Round(slope,4);
      }
   }
}
