using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   /// <summary>
   /// Tests designed to test all trig calculations.
   /// </summary>
   [TestClass]
   public class TrigTests
   {
      /// <summary>
      /// Should return radians, based on a base and rise input.
      /// </summary>
      [TestMethod]
      public void BaseRiseToRadian()
      {
         //Arrange
         var bayse = 12m;
         var rise = 1m;
         var expectedRadian = 0.0831m;

         //Act
         var radian = Math.Round(TrigFunctions.BaseRiseToRadian(bayse, rise), 4);

         //Assert
         Assert.AreEqual(expectedRadian, radian);
      }

      /// <summary>
      /// Should return the slope, based onthe base and rise input.
      /// </summary>
      [TestMethod]
      public void BaseRiseToSlope()
      {
         //Arrange
         var bayse = 3m;
         var userRise = 4m;
         var expectedResponse = 5m;

         //Act
         var response = Math.Round(TrigFunctions.BaseRiseToSlope(bayse, userRise), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Should return the slope, based on the angle and base input.
      /// </summary>
      [TestMethod]
      public void BaseToSlope()
      {
         //Arrange
         var bayse = 12m;
         var angle = 26.5651m;
         var expectedResponse = 13.4164m;

         //Act
         var response = Math.Round(TrigFunctions.BaseToSlope(bayse, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Should return rise, based on the angle and rise input.
      /// </summary>
      [TestMethod]
      public void BaseToRise()
      {
         //Arrange
         var bayse = 4.21m;
         var angle = 26.5651m;
         var expectedResponse = 2.105m;

         //Act
         var response = Math.Round(TrigFunctions.BaseToRise(bayse, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Should return the base, based on the slope and angle input.
      /// </summary>
      [TestMethod]
      public void SlopeToBase()
      {
         //Arrange
         var slope = 5.418m;
         var angle = 26.5651m;
         var expectedResponse = 4.846m;

         //Act
         var response = Math.Round(TrigFunctions.SlopeToBase(slope, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
      
      /// <summary>
      /// Should return the rise, based on the slope and angle input.
      /// </summary>
      [TestMethod]
      public void SlopeToRise()
      {
         //Arrange
         var slope = 9.615m;
         var angle = 26.5651m;
         var expectedResponse = 4.3m;

         //Act
         var response = Math.Round(TrigFunctions.SlopeToRise(slope, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Should return the slope, based on the rise and angle input.
      /// </summary>
      [TestMethod]
      public void RisetoSlope()
      {
         //Arrange
         var rise = 1.5m;
         var angle = 26.5651m;
         var expectedResponse = 3.3541m;

         //Act
         var response = Math.Round(TrigFunctions.RiseToSlope(rise, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Should return the base, based on the angle and rise input.
      /// </summary>
      [TestMethod]
      public void RiseToBase()
      {
         //Arrange
         var rise = 1.21m;
         var angle = 26.5651m;
         var expectedResponse = 2.42m;

         //Act
         var response = Math.Round(TrigFunctions.RiseToBase(rise, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
