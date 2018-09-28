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
         var userBase = 3.06;
         var userRise = 4.06;
         var expectedResponse = 5.0807;

         //Act
         var response = sTrig.BaseRiseToSlope(userBase, userRise);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void BaseToSlope_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var userBase = 12.0204;
         var angle = 26.565051;
         var expectedResponse = 13.0708;

         //Act
         var response = sTrig.BaseToSlope(userBase, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToRise_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var userBase = 4.06;
         var angle = 26.565051;
         var expectedResponse = 2.03;

         //Act
         var response = sTrig.BaseToRise(userBase, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToBase_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var slope = 5.0604;
         var angle = 26.565051;
         var expectedResponse = 4.1104;

         //Act
         var response = sTrig.SlopeToBase(slope, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToRise_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var slope = 9.0208;
         var angle = 26.565051;
         var expectedResponse = 4.0107;

         //Act
         var response = sTrig.SlopeToRise(slope, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RisetoSlope_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var rise = 0.0508;
         var angle = 26.565051;
         var expectedResponse = 1.0005;

         //Act
         var response = sTrig.RiseToSlope(rise, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RiseToBase_UnitTest()
      {
         //Arrange
         SidesTrig sTrig = new SidesTrig();
         var rise = 0.0509;
         var angle = 26.565051;
         var expectedResponse = 0.1102;

         //Act
         var response = sTrig.RiseToBase(rise, angle);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }
   }
}
