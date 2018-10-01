﻿using System;
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
         //userEntry = 4.0608

         //determine feet
         double feet = Math.Truncate(userEntry); //4

         //determine inches(feet)
         double inches = Math.Round(userEntry - feet, 4); //.0608
         double inch_feet = Math.Truncate(inches * 100); //6
         inches = inch_feet / 12; //0.5

         //determine sixteenths
         double sixteenths = userEntry - feet - (inch_feet / 100); //0.0008xxxxxxxx;
         sixteenths = Math.Round(sixteenths, 4); //0.0008
         sixteenths = sixteenths * 10000 / 16 / 12; //0.04166667

         return Math.Round(feet + inches + sixteenths, 4); //4.5167

      }

      public static double DecimalToFoot(double userEntry)
      {

         //userEntry = 23.02604

         double feet = Math.Truncate(userEntry); //23
         double inches = userEntry - feet;
         inches = inches * 12;
         inches = Math.Truncate(inches);
         inches = inches / 100;
         double sixteenths = userEntry - feet; //.02604
         sixteenths = sixteenths * 12; //0.02604 * 12 = 0.31248
         double tempInches = Math.Truncate(sixteenths); //truncate 0.31248 = 0
         sixteenths = sixteenths - tempInches; // 0.31248 - 0 = 0.31248
         sixteenths = sixteenths * 16; //0.31248 * 16 = 4.999968
         sixteenths = sixteenths / 10000; // 4.999968 / 10000 = 0.0004999968;

         return Math.Round(feet + inches + sixteenths, 4); //12.0204
      }

      public static double AngleToRadians(double angle)
      {
         var radians = angle * Math.PI/180;
         return Math.Round(radians, 4);
      }

      public static double RadiansToAngle(double radians)
      {
         var angle = radians * 180 / Math.PI;
         return Math.Round(angle, 4);
      }

      public static double InchDecimalToInchFeet(double inches)
      {
         var inchft = Math.Truncate(inches);
         inches = inches - inchft;
         inches = inches * 16;
         var sixteenths = inches / 10000;

         return inchft + sixteenths;
      }
   }
}
