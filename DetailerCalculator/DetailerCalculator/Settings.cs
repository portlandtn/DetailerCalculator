using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class Settings
   {
      public double Angle { get; set; }

      public int ActiveAngle { get; set; }

      public bool IsDetailingMathMethod { get; set; }

      public static double DetermineFirstNumberForMath(int totalNumbersRequired, int outputWindowListCount, List<double> outputWindowList)
      {
         if (totalNumbersRequired == 2)
         {
            return (outputWindowList.Count <= 1) ? 0 : outputWindowList[outputWindowListCount - 2];
         }
         else
         {
            return (outputWindowList.Count == 0) ? 0 : outputWindowList[outputWindowListCount - 1];
         }
      }

      public static double DetermineSecondNumberForMath(int outputWindowListCount, List<double> outputWindowList)
      {
         return (outputWindowList.Count <= 1) ? 0 : outputWindowList[outputWindowListCount - 1];
      }

      public static double FootToDecimalButtonClick(int outputWindowListCount, List<double> outputWindowList)
      {
         return (outputWindowListCount == 0) ? 0 : Conversions.FootToDecimal(outputWindowList[outputWindowListCount - 1]);
      }

      public static double DecimalToFootButtonClick(int outputWindowListCount, List<double> outputWindowList)
      {
         return (outputWindowListCount == 0) ? 0 : Conversions.DecimalToFoot(outputWindowList[outputWindowListCount - 1]);
      }

      public static double TrigFunctionButtonClick(double num, double angle, string function, bool isDetailingMathMethod)
      {
         num = (isDetailingMathMethod == true) ? Conversions.FootToDecimal(num) : num;

         switch (function)
         {
            case "b2s":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(SidesTrig.BaseToSlope(num, angle)) : SidesTrig.BaseToSlope(num, angle);
            case "b2r":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(SidesTrig.BaseToRise(num, angle)) : SidesTrig.BaseToRise(num, angle);
            case "s2b":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(SidesTrig.SlopeToBase(num, angle)) : SidesTrig.SlopeToBase(num, angle);
            case "s2r":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(SidesTrig.SlopeToRise(num, angle)) : SidesTrig.SlopeToRise(num, angle);
            case "r2b":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(SidesTrig.RiseToBase(num, angle)) : SidesTrig.RiseToBase(num, angle);
            case "r2s":
               return (isDetailingMathMethod == true) ? Conversions.DecimalToFoot(SidesTrig.RiseToSlope(num, angle)) : SidesTrig.RiseToSlope(num, angle);
            default:
               return 0;
         }
      }
   }
}
