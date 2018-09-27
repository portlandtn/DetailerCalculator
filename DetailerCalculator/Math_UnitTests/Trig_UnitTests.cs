using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;

namespace UnitTests
{
   [TestClass]
   public class Trig_Unit_Tests
   {
      [TestMethod]
      public void FootToDecimal_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.1875;

         //Act
         var response = trigFunc.FootToDecimal(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void DecimalToFoot_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.1875;
         var expectedResponse = 12.0204;

         //Act
         var response = trigFunc.DecimalToFoot(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseRiseToAngle_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.BaseRiseToAngle(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseRiseToSlope_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.BaseRiseToAngle(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToSlope_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.BaseToSlope(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToRise_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.BaseToRise(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToBase_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.SlopeToBase(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToRise_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.SlopeToRise(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RisetoSlope_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.RiseToSlope(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RiseToBase_UnitTest()
      {
         //Arrange
         TrigFunctions trigFunc = new TrigFunctions();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = trigFunc.RiseToBase(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }
   }
}
