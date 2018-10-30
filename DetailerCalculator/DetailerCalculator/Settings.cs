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
      public decimal Angle1 { get; set; }

      public decimal Angle2 { get; set; }

      public decimal Angle3 { get; set; }

      public decimal Angle4 { get; set; }

      public decimal CurrentAngle { get; set; }

      public int ActiveAngle { get; set; }

      public bool WeightFormIsShown { get; set; }

      public bool IsDetailingMathMethod { get; set; }

      public bool WidthIsInFeet { get; set; }

      public bool LengthIsInFeet { get; set; }

      public string FixedDecimals { get; set; }

      public bool HaveSeenTrayIconInstructions { get; set; }

      public Stack<List<decimal>> UndoRedoSettings { get; set; }
   }
}
