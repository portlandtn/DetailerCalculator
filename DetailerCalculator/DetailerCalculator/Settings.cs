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

      public static double CurrentAngle(int activeAngle, double angle1, double angle2, double angle3, double angle4)
      {
         switch (activeAngle)
         {
            case 1:
               return angle1;
            case 2:
               return angle2;
            case 3:
               return angle3;
            case 4:
               return angle4;
            default:
               return 0;
         }
      }
   }
}
