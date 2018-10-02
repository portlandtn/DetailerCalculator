using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class SideSidesTrig_UnitTests
   {
      [TestMethod]
      public void BaseRiseToSlope_UnitTest()
      {
         //Arrange
         var bayse = 3;
         var userRise = 4;
         var expectedResponse = 5;

         //Act
         var response = Math.Round(SidesTrig.BaseRiseToSlope(bayse, userRise), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void BaseToSlope_UnitTest()
      {
         //Arrange
         var bayse = 12;
         var angle = 26.5651;
         var expectedResponse = 13.4164;

         //Act
         var response = Math.Round(SidesTrig.BaseToSlope(bayse, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToRise_UnitTest()
      {
         //Arrange
         var bayse = 4.21;
         var angle = 26.5651;
         var expectedResponse = 2.105;

         //Act
         var response = Math.Round(SidesTrig.BaseToRise(bayse, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToBase_UnitTest()
      {
         //Arrange
         var slope = 5.418;
         var angle = 26.5651;
         var expectedResponse = 4.846;

         //Act
         var response = Math.Round(SidesTrig.SlopeToBase(slope, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToRise_UnitTest()
      {
         //Arrange
         var slope = 9.615;
         var angle = 26.5651;
         var expectedResponse = 4.3;

         //Act
         var response = Math.Round(SidesTrig.SlopeToRise(slope, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RisetoSlope_UnitTest()
      {
         //Arrange
         var rise = 1.5;
         var angle = 26.5651;
         var expectedResponse = 3.3541;

         //Act
         var response = Math.Round(SidesTrig.RiseToSlope(rise, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RiseToBase_UnitTest()
      {
         //Arrange
         var rise = 1.21;
         var angle = 26.5651;
         var expectedResponse = 2.42;

         //Act
         var response = Math.Round(SidesTrig.RiseToBase(rise, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }
   }
}
