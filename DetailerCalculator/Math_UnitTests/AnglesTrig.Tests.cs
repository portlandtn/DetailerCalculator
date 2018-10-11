using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class AnglesTrigTests
   {
      [TestMethod]
      public void BaseRiseToRadian_UnitTest()
      {
         //Arrange
         var bayse = 12m;
         var rise = 1m;
         var expectedRadian = 0.0831m;

         //Act
         var radian = Math.Round(AnglesTrig.BaseRiseToRadian(bayse, rise),4);

         //Assert
         Assert.AreEqual(expectedRadian, radian);
      }
   }
}
