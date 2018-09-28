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
         Conversions trigFunc = new Conversions();
         var foot1 = 4.06;
         var expectedDecimal1 = 4.5;
         var foot2 = 4.0608;
         var expectedDecimal2 = 4.5417;
         var foot3 = 144.0802;
         var expectedDecimal3 = 144.6771;
         var foot4 = -118.02;
         var expectedDecimal4 = -118.1667;

         //Act
         var decimal1 = trigFunc.FootToDecimal(foot1);
         var decimal2 = trigFunc.FootToDecimal(foot2);
         var decimal3 = trigFunc.FootToDecimal(foot3);
         var decimal4 = trigFunc.FootToDecimal(foot4);

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
         Conversions trigFunc = new Conversions();
         var decNumber1 = 4.5;
         var expectedFoot1 = 4.06;
         var decNumber2 = 4.5417;
         var expectedFoot2 = 4.0608;
         var decNumber3 = 144.6771;
         var expectedFoot3 = 144.0802;
         var decNumber4 = -118.1667;
         var expectedFoot4 = -118.02;

         //Act
         var foot1 = trigFunc.DecimalToFoot(decNumber1);
         var foot2 = trigFunc.DecimalToFoot(decNumber2);
         var foot3 = trigFunc.DecimalToFoot(decNumber3);
         var foot4 = trigFunc.DecimalToFoot(decNumber4);

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
         Conversions trigFunc = new Conversions();
         var angle = 4.7623;
         var expectedResponse = 0.0831;

         //Act
         var response = trigFunc.AngleToRadians(angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void RadiansToAngle_UnitTest()
      {
         //Arrange
         Conversions trigFunc = new Conversions();
         var radians = 0.2501;
         var expectedResponse = 14.3297;

         //Act
         var response = trigFunc.RadiansToAngle(radians);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
