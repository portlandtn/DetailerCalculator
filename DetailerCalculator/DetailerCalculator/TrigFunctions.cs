using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   /// <summary>
   /// This class is for performing trig functions only and returning a value.
   /// </summary>
   public class TrigFunctions
   {
      /// <summary>
      /// Takes the user input base and rise dimensions and returns the radians to be used for math.
      /// </summary>
      /// <param name="bayse"></param>
      /// <param name="rise"></param>
      /// <returns></returns>
      public static decimal BaseRiseToRadian(decimal bayse, decimal rise)
      {
         return Convert.ToDecimal(Math.Atan(Convert.ToDouble(rise / bayse)));
      }

      /// <summary>
      /// Takes the user input base and rise to determine the slope dimension.
      /// </summary>
      /// <param name="bayse"></param>
      /// <param name="rise"></param>
      /// <returns></returns>
      public static decimal BaseRiseToSlope(decimal bayse, decimal rise)
      {
         return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble((bayse * bayse) + (rise * rise))));
      }

      /// <summary>
      /// Takes the user input base and angle to determine the slope.
      /// </summary>
      /// <param name="bayse"></param>
      /// <param name="angleA"></param>
      /// <returns></returns>
      public static decimal BaseToSlope(decimal bayse, decimal angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         return bayse / Convert.ToDecimal((Math.Sin(Convert.ToDouble(radianB))));
      }

      /// <summary>
      /// Takes the user input base and angle to determien the rise.
      /// </summary>
      /// <param name="bayse"></param>
      /// <param name="angleA"></param>
      /// <returns></returns>
      public static decimal BaseToRise(decimal bayse, decimal angleA)
      {
         var angleB = 90 - angleA;
         var radianB = Conversions.AngleToRadians(angleB);
         return bayse / Convert.ToDecimal(Math.Tan(Convert.ToDouble(radianB)));
      }

      /// <summary>
      /// Takes the user input slope and angle to determine the base.
      /// </summary>
      /// <param name="slope"></param>
      /// <param name="angleA"></param>
      /// <returns></returns>
      public static decimal SlopeToBase(decimal slope, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return Convert.ToDecimal(Math.Cos(Convert.ToDouble(radianA))) * slope;
      }

      /// <summary>
      /// Takes the user input slope and angle to determine the rise.
      /// </summary>
      /// <param name="slope"></param>
      /// <param name="angleA"></param>
      /// <returns></returns>
      public static decimal SlopeToRise(decimal slope, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return Convert.ToDecimal(Math.Sin(Convert.ToDouble(radianA))) * slope;
      }

      /// <summary>
      /// Takes the user input rise and angle to determine the base.
      /// </summary>
      /// <param name="rise"></param>
      /// <param name="angleA"></param>
      /// <returns></returns>
      public static decimal RiseToBase(decimal rise, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return rise / Convert.ToDecimal(Math.Tan(Convert.ToDouble(radianA)));
      }

      /// <summary>
      /// Takes the user input rise and angle to determine the slope.
      /// </summary>
      /// <param name="rise"></param>
      /// <param name="angleA"></param>
      /// <returns></returns>
      public static decimal RiseToSlope(decimal rise, decimal angleA)
      {
         var radianA = Conversions.AngleToRadians(angleA);
         return rise / Convert.ToDecimal(Math.Sin(Convert.ToDouble(radianA)));
      }
   }
}
