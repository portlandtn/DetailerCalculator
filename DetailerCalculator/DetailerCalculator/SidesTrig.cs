using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class SidesTrig
   {
      public double BaseRiseToSlope(double userBaseInFeet, double riseInFeet)
      {
         Conversions c = new Conversions();
         var userBase = c.FootToDecimal(userBaseInFeet);
         var rise = c.FootToDecimal(riseInFeet);
         double slope = Math.Sqrt((userBase * userBase) + (rise * rise));
         slope = c.DecimalToFoot(slope);
         return Math.Round(slope, 4);
      }

      public double BaseToSlope(double userBaseInFeet, double angleA)
      {
         Conversions c = new Conversions();
         var userBase = c.FootToDecimal(userBaseInFeet);
         var angleB = 90 - angleA;
         var radianB = c.AngleToRadians(angleB);
         double slope = userBase / Math.Sin(radianB);
         slope = c.DecimalToFoot(slope);
         return Math.Round(slope, 4);
      }

      public double BaseToRise(double userBaseInFeet, double angleA)
      {
         Conversions c = new Conversions();
         var userBase = c.FootToDecimal(userBaseInFeet);
         var angleB = 90 - angleA;
         var radianB = c.AngleToRadians(angleB);
         double rise = userBase / Math.Tan(radianB);
         rise = c.DecimalToFoot(rise);
         return Math.Round(rise, 4);
      }

      public double SlopeToBase(double slopeInFeet, double angleA)
      {
         Conversions c = new Conversions();
         var radianA = c.AngleToRadians(angleA);
         var slope = c.FootToDecimal(slopeInFeet);
         var response = Math.Cos(radianA) * slope;
         response = c.DecimalToFoot(response);
         return response;
      }

      public double SlopeToRise(double slopeInFeet, double angleA)
      {
         Conversions c = new Conversions();
         var radianA = c.AngleToRadians(angleA);
         var slope = c.FootToDecimal(slopeInFeet);
         var rise = Math.Sin(radianA) * slope;
         rise = c.DecimalToFoot(rise);
         return rise;
      }

      public double RiseToBase(double riseInFeet, double angleA)
      {
         Conversions c = new Conversions();
         var radianA = c.AngleToRadians(angleA);
         var rise = c.FootToDecimal(riseInFeet);
         var response = rise / Math.Tan(radianA);
         response = c.DecimalToFoot(response);
         return response;
      }

      public double RiseToSlope(double riseInFeet, double angleA)
      {
         Conversions c = new Conversions();
         var radianA = c.AngleToRadians(angleA);
         var rise = c.FootToDecimal(riseInFeet);
         var slope = rise / Math.Sin(radianA);
         slope = c.DecimalToFoot(slope);
         return slope;
      }
   }
}
