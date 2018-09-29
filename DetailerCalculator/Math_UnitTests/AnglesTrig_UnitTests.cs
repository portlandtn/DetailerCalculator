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
         var userBase = 12;
         var rise = 1;
         var expectedAngle = 4.7636;

         //Act
         var angle = aTrig.BaseRiseToAngle(userBase, rise);

         //Assert
         Assert.AreEqual(expectedAngle, angle);
      }
   }
}
