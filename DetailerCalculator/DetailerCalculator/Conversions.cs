using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class Conversions
   {
      public static double FootToDecimal(double userEntry)
      {
         //determine feet
         double feet = Math.Truncate(userEntry);

         //determine inches(feet)
         double inches = Math.Round(userEntry - feet, 4);
         double inch_feet = Math.Truncate(inches * 100);
         inches = inch_feet / 12; //0.5

         //determine sixteenths
         double sixteenths = userEntry - feet - (inch_feet / 100);
         sixteenths = Math.Round(sixteenths, 4); 
         sixteenths = sixteenths * 10000 / 16 / 12;

         //Add them up
         return feet + inches + sixteenths;

      }

      public static double DecimalToFoot(double userEntry)
      {
         //determine feet
         double feet = Math.Truncate(userEntry);

         //determine inches
         double inches = userEntry - feet;
         inches = inches * 12;
         inches = Math.Truncate(inches);
         inches = inches / 100;

         //determine sixteenths
         double sixteenths = userEntry - feet;
         sixteenths = sixteenths * 12;
         double tempInches = Math.Truncate(sixteenths);
         sixteenths = sixteenths - tempInches;
         sixteenths = sixteenths * 16;
         sixteenths = sixteenths / 10000;

         //add them up
         return feet + inches + sixteenths;
      }

      public static double AngleToRadians(double angle)
      {
         return angle * Math.PI/180;
      }

      public static double RadiansToAngle(double radians)
      {
         return radians * 180 / Math.PI;
      }

      public static double ChangeToNegative_Positive(double num)
      {
         try
         {
            return num * -1;
         }
         catch (Exception)
         {
            return 0;
         }
      }
   }
}
