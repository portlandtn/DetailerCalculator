using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;

namespace UnitTests
{
   [TestClass]
   public class SideSidesTrig_UnitTests
   {
      [TestMethod]
      public void BaseRiseToSlope_UnitTest()
      {
         //Arrange
         var userBase = 3;
         var userRise = 4;
         var expectedResponse = 5;

         //Act
         var response = SidesTrig.BaseRiseToSlope(userBase, userRise);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void BaseToSlope_UnitTest()
      {
         //Arrange
         var userBase = 12;
         var angle = 26.565051;
         var expectedResponse = 13.4167;

         //Act
         var response = SidesTrig.BaseToSlope(userBase, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToRise_UnitTest()
      {
         //Arrange
         var userBase = 4.21;
         var angle = 26.565051;
         var expectedResponse = 2.1053;

         //Act
         var response = SidesTrig.BaseToRise(userBase, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToBase_UnitTest()
      {
         //Arrange
         var slope = 5.418;
         var angle = 26.565051;
         var expectedResponse = 4.8461;

         //Act
         var response = SidesTrig.SlopeToBase(slope, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToRise_UnitTest()
      {
         //Arrange
         var slope = 9.615;
         var angle = 26.565051;
         var expectedResponse = 4.2995;

         //Act
         var response = SidesTrig.SlopeToRise(slope, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RisetoSlope_UnitTest()
      {
         //Arrange
         var rise = 1.5;
         var angle = 26.565051;
         var expectedResponse = 3.3544;

         //Act
         var response = SidesTrig.RiseToSlope(rise, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RiseToBase_UnitTest()
      {
         //Arrange
         var rise = 1.21;
         var angle = 26.565051;
         var expectedResponse = 2.4203;

         //Act
         var response = SidesTrig.RiseToBase(rise, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }
   }
}
