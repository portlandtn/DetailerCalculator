using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;

namespace UnitTests
{
   [TestClass]
   public class AnglesTrig_UnitTests
   {
      [TestMethod]
      public void BaseRiseToAngle_UnitTest()
      {
         //Arrange
         AnglesTrig aTrig = new AnglesTrig();
         var number = 12.0204;
         var expectedResponse = 12.0225;

         //Act
         var response = aTrig.BaseRiseToAngle(number);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

   }
}
