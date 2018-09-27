using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class TrigFunctions
   {
      public double FootToDecimal(double userEntry)
      {
         //userEntry = 12.0204

         double feet = Math.Truncate(userEntry); //12
         double inches = userEntry - feet; //.0204
         inches = Math.Truncate(inches * 100); //2
         inches = inches / 12; //0.1667
         double a = (userEntry - feet) * 100; //2.04
         double sixteenths = Math.Truncate(a); //2
         sixteenths = a - sixteenths; //0.04
         sixteenths = sixteenths * 100; //4
         sixteenths = sixteenths / 16; //0.25
         sixteenths = sixteenths / 12; //0.0208

         return Math.Round(feet + inches + sixteenths, 4); //12.1875
      }

      public double DecimalToFoot(double userEntry)
      {

         //userEntry = 12.1875

         double feet = Math.Truncate(userEntry); //12
         double inches = Math.Truncate((userEntry - feet) * 12); //2
         inches = inches / 100; //.02
         double sixteenths = (((userEntry - feet) * 12) - 2) * 16; //4
         sixteenths = sixteenths / 10000; //.0004

         return feet + inches + sixteenths; //12.0204
      }

      public double BaseRiseToSlope(double userEntry)
      {
         var slope = 0;
         return slope;
      }

      public double BaseRiseToAngle(double userEntry)
      {
         var angle = 0;
         return angle;
      }

      public double BaseToSlope(double userEntry)
      {
         var slope = 0;
         return slope;
      }

      public double BaseToRise(double userEntry)
      {
         var rise = 0;
         return rise;
      }

      public double SlopeToBase(double userEntry)
      {
         var response = 0;
         return response;
      }

      public double SlopeToRise(double userEntry)
      {
         var rise = 0;
         return rise;
      }

      public double RiseToBase(double userEntry)
      {
         var response = 0;
         return response;
      }

      public double RiseToSlope(double userEntry)
      {
         var slope = 0;
         return slope;
      }
   }
}
