﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetailerCalculator
{
   /// <summary>
   /// Class for taking in numbers and returning conversions only.
   /// </summary>
   public class Conversions
   {
      /// <summary>
      /// Takes the user entry in ft-in-16's format and returns a decimal format.
      /// </summary>
      /// <param name="userEntry"></param>
      /// <returns></returns>
      public static decimal FootToDecimal(decimal userEntry)
      {
         //determine feet
         decimal feet = Math.Truncate(userEntry);

         //determine inches(feet)
         decimal inches = userEntry - feet;
         decimal inch_feet = Math.Truncate(inches * 100);
         inches = inch_feet / 12;

         //determine sixteenths
         decimal sixteenths = (userEntry - feet - (inch_feet / 100)) * 10000 / 16 / 12;

         //Add them up
         return feet + inches + sixteenths;
      }

      /// <summary>
      /// Takes the user entry in decimal format and returns a ft-in-16's format.
      /// </summary>
      /// <param name="userEntry"></param>
      /// <returns></returns>
      public static decimal DecimalToFoot(decimal userEntry)
      {
         //determine feet
         decimal feet = Math.Truncate(userEntry);

         decimal inches = Math.Truncate((userEntry - feet) * 12)/100;

         //determine sixteenths
         decimal sixteenths = (userEntry - feet) * 12;
         decimal tempInches = Math.Truncate(sixteenths);
         sixteenths = ((sixteenths - tempInches) * 16) / 10000;
         if (sixteenths >= 0.00155m)
         {
            inches = inches + 0.01m;
            sixteenths = 0;
         }
         if (inches >= 0.1155m)
         {
            feet++;
            inches = 0;
         }
         //add them up
         return feet + inches + sixteenths;
      }

      /// <summary>
      /// Converts an angle to a radian for trig math.
      /// </summary>
      /// <param name="angle"></param>
      /// <returns></returns>
      public static decimal AngleToRadians(decimal angle)
      {
         return angle * Convert.ToDecimal(Math.PI) / 180;
      }

      /// <summary>
      /// Converts a radian to an angle for output to the user.
      /// </summary>
      /// <param name="radians"></param>
      /// <returns></returns>
      public static decimal RadiansToAngle(decimal radians)
      {
         return radians * 180 / Convert.ToDecimal(Math.PI);
      }

      /// <summary>
      /// Converts any number to a negative/positive number, based on the original input - inverse is returned.
      /// </summary>
      /// <param name="num"></param>
      /// <returns></returns>
      public static decimal ChangeToNegativePositive(decimal num)
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

      /// <summary>
      /// Uses three numbers to figure the weight of steel.
      /// </summary>
      /// <param name="length"></param>
      /// <param name="width"></param>
      /// <param name="thickness"></param>
      /// <returns></returns>
      public static decimal DetermineDimensionForWeightCalculations(decimal dimension, bool isDetailingMathMethod, bool dimensionIsInFeet)
      {
         return dimensionIsInFeet == false
            ? dimension
            : isDetailingMathMethod == true ? FootToDecimal(dimension) * 12 : dimension * 12;
      }
   }
}
