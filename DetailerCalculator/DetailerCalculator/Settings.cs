using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   /// <summary>
   /// This class is for storing settings only.
   /// </summary>
   public class Settings
   {
      public decimal Angle { get; set; }

      public int ActiveAngle { get; set; }

      public bool IsDetailingMathMethod { get; set; }

      public string FixedDecimals { get; set; }

      public bool HaveSeenTrayIconInstructions { get; set; }
   }
}
