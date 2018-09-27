using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailerCalculator
{
   public class Conversions
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
   }
}
