using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class Conversions_UnitTests
   {
      [TestMethod]
      public void FootToDecimal_UnitTest()
      {
         //Arrange
         var foot1 = 4.06;
         var expectedDecimal1 = 4.5;
         var foot2 = 4.0608;
         var expectedDecimal2 = 4.5417;
         var foot3 = 144.0802;
         var expectedDecimal3 = 144.6771;
         var foot4 = -118.02;
         var expectedDecimal4 = -118.1667;

         //Act
         var decimal1 = Math.Round(Conversions.FootToDecimal(foot1), 4);
         var decimal2 = Math.Round(Conversions.FootToDecimal(foot2), 4);
         var decimal3 = Math.Round(Conversions.FootToDecimal(foot3), 4);
         var decimal4 = Math.Round(Conversions.FootToDecimal(foot4), 4);

         //Assert
         Assert.AreEqual(expectedDecimal1, decimal1);
         Assert.AreEqual(expectedDecimal2, decimal2);
         Assert.AreEqual(expectedDecimal3, decimal3);
         Assert.AreEqual(expectedDecimal4, decimal4);
      }

      [TestMethod]
      public void DecimalToFoot_UnitTest()
      {
         //Arrange
         var decNumber1 = 4.5;
         var expectedFoot1 = 4.06;
         var decNumber2 = 4.5417;
         var expectedFoot2 = 4.0608;
         var decNumber3 = 144.6771;
         var expectedFoot3 = 144.0802;
         var decNumber4 = -118.1667;
         var expectedFoot4 = -118.02;

         //Act
         var foot1 = Math.Round(Conversions.DecimalToFoot(decNumber1), 4);
         var foot2 = Math.Round(Conversions.DecimalToFoot(decNumber2), 4);
         var foot3 = Math.Round(Conversions.DecimalToFoot(decNumber3), 4);
         var foot4 = Math.Round(Conversions.DecimalToFoot(decNumber4), 4);

         //Assert
         Assert.AreEqual(expectedFoot1, foot1);
         Assert.AreEqual(expectedFoot2, foot2);
         Assert.AreEqual(expectedFoot3, foot3);
         Assert.AreEqual(expectedFoot4, foot4);
      }

      [TestMethod]
      public void AngleToRadians_UnitTest()
      {
         //Arrange
         var angle1 = 4.7623;
         var expectedRadians1 = 0.0831;
         var angle2 = 24;
         var expectedRadians2 = 0.4189;
         var angle3 = 21.0208;
         var expectedRadians3 = 0.3669;
         var angle4 = 81.514;
         var expectedRadians4 = 1.4227;

         //Act
         var radians1 = Math.Round(Conversions.AngleToRadians(angle1), 4);
         var radians2 = Math.Round(Conversions.AngleToRadians(angle2), 4);
         var radians3 = Math.Round(Conversions.AngleToRadians(angle3), 4);
         var radians4 = Math.Round(Conversions.AngleToRadians(angle4), 4);

         //Assert
         Assert.AreEqual(expectedRadians1, radians1);
         Assert.AreEqual(expectedRadians2, radians2);
         Assert.AreEqual(expectedRadians3, radians3);
         Assert.AreEqual(expectedRadians4, radians4);
      }

      [TestMethod]
      public void RadiansToAngle_UnitTest()
      {
         //Arrange
         var radians1 = 0.2501;
         var expectedAngle1 = 14.3297;
         var radians2 = 0.715;
         var expectedAngle2 = 40.9665;
         var radians3 = 1.3128;
         var expectedAngle3 = 75.2179;
         var radians4 = 0.122;
         var expectedAngle4 = 6.9901;

         //Act
         var angle1 = Math.Round(Conversions.RadiansToAngle(radians1), 4);
         var angle2 = Math.Round(Conversions.RadiansToAngle(radians2), 4);
         var angle3 = Math.Round(Conversions.RadiansToAngle(radians3), 4);
         var angle4 = Math.Round(Conversions.RadiansToAngle(radians4), 4);

         //Assert
         Assert.AreEqual(expectedAngle1, angle1);
         Assert.AreEqual(expectedAngle2, angle2);
         Assert.AreEqual(expectedAngle3, angle3);
         Assert.AreEqual(expectedAngle4, angle4);
      }

      [TestMethod]
      public void ChangeToNegative_Positve_UnitTest()
      {
         //Arrange
         double num1 = 21;
         double num2 = -18;
         double expectedResponse1 = -21;
         double expectedResponse2 = 18;

         //Act
         double response1 = Conversions.ChangeToNegative_Positive(num1);
         double response2 = Conversions.ChangeToNegative_Positive(num2);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);


      }
   }
}
