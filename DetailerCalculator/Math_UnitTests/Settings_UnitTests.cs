using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class Settings_UnitTests
   {
      [TestMethod]
      public void CurrentAngle_Angle1_UnitTest()
      {
         //Arrange
         var activeAngle = 1;
         var angle1 = 1.1935;
         var angle2 = 2.4632;
         var angle3 = 3.4032;
         var angle4 = 14.0363;
         var expectedAngle = 1.1935;

         //Act
         var angle = Settings.CurrentAngle(activeAngle, angle1, angle2, angle3, angle4);

         //Assert
         Assert.AreEqual(expectedAngle, angle);
      }

      [TestMethod]
      public void CurrentAngle_Angle2_UnitTest()
      {
         //Arrange
         var activeAngle = 2;
         var angle1 = 1.1935;
         var angle2 = 2.4632;
         var angle3 = 3.4032;
         var angle4 = 14.0363;
         var expectedAngle = 2.4632;

         //Act
         var angle = Settings.CurrentAngle(activeAngle, angle1, angle2, angle3, angle4);

         //Assert
         Assert.AreEqual(expectedAngle, angle);
      }

      [TestMethod]
      public void CurrentAngle_Angle3_UnitTest()
      {
         //Arrange
         var activeAngle = 3;
         var angle1 = 1.1935;
         var angle2 = 2.4632;
         var angle3 = 3.4032;
         var angle4 = 14.0363;
         var expectedAngle = 3.4032;

         //Act
         var angle = Settings.CurrentAngle(activeAngle, angle1, angle2, angle3, angle4);

         //Assert
         Assert.AreEqual(expectedAngle, angle);
      }

      [TestMethod]
      public void CurrentAngle_Angle4_UnitTest()
      {
         //Arrange
         var activeAngle = 4;
         var angle1 = 1.1935;
         var angle2 = 2.4632;
         var angle3 = 3.4032;
         var angle4 = 14.0363;
         var expectedAngle = 14.0363;

         //Act
         var angle = Settings.CurrentAngle(activeAngle, angle1, angle2, angle3, angle4);

         //Assert
         Assert.AreEqual(expectedAngle, angle);
      }
   }
}
