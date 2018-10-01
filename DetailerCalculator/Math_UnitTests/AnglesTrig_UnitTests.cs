using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class AnglesTrig_UnitTests
   {
      [TestMethod]
      public void BaseRiseToRadian_UnitTest()
      {
         //Arrange
         var bayse = 12;
         var rise = 1;
         var expectedRadian = 0.0831;

         //Act
         var radian = Math.Round(AnglesTrig.BaseRiseToRadian(bayse, rise),4);

         //Assert
         Assert.AreEqual(expectedRadian, radian);
      }
   }
}
