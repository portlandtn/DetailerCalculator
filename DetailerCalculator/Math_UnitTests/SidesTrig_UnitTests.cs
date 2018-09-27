using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;

namespace UnitTests
{
   [TestClass]
   public class SidesTrig_UnitTests
   {
      [TestMethod]
      public void BaseRiseToSlope_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.BaseRiseToSlope(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void BaseToSlope_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.BaseToSlope(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToRise_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.BaseToRise(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToBase_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.SlopeToBase(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToRise_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.SlopeToRise(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RisetoSlope_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.RiseToSlope(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RiseToBase_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = sTrig.RiseToBase(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }
   }
}
