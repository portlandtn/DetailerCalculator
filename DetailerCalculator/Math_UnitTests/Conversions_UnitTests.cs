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
         Conversions trigFunc = new Conversions();
         var number = 23.0005;
         var expectedResponse = 23.0260;

         //Act
         var response = trigFunc.FootToDecimal(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void DecimalToFoot_UnitTest()
      {
         //Arrange
         Conversions trigFunc = new Conversions();
         var number = 23.02604;
         var expectedResponse = 23.0005;

         //Act
         var response = trigFunc.DecimalToFoot(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
