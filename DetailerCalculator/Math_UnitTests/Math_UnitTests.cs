using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;

namespace UnitTests
{
   [TestClass]
   public class Math_Unit_Tests
   {
      [TestMethod]
      public void Add_Standard_UnitTest()
      {
         //Arrange
         var num1 = 22.1115;
         var num2 = 0.0005;
         var expectedResponse = 22.112;
         bool isDetailingMethod = false;

         //Act
         var response = MathFunctions.AddNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Add_Detailing_UnitTest()
      {
         //Arrange
         var num1 = 22.1115;
         var num2 = 0.0005;
         var expectedResponse = 23.0004;
         bool isDetailingMethod = true;

         //Act
         var response = MathFunctions.AddNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Subtract_Standard_UnitTest()
      {
         //Arrange
         var num1 = 23.1102;
         var num2 = 0.0005;
         var expectedResponse = 23.1097;
         bool isDetailingMethod = false;

         //Act
         var response = MathFunctions.SubtractNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Subtract_Detailing_UnitTest()
      {
         //Arrange
         var num1 = 23.1102;
         var num2 = 0.0005;
         var expectedResponse = 23.1013;
         bool isDetailingMethod = true;

         //Act
         var response = MathFunctions.SubtractNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Multiply_Standard_UnitTest()
      {
         //Arrange
         var num1 = 12.0204;
         var num2 = 14.0806;
         var expectedResponse = 169.2544;
         //171.0705
         bool isDetailingMethod = false;

         //Act
         var response = MathFunctions.MultiplyNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Multiply_Detailing_UnitTest()
      {
         //Arrange
         var num1 = 12.0204;
         var num2 = 14.0806;
         var expectedResponse = 179.0109;
         bool isDetailingMethod = true;

         //Act
         var response = MathFunctions.MultiplyNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Divide_Standard_UnitTest()
      {
         //Arrange
         var num1 = 23.0608;
         var num2 = 15.0302;
         var expectedResponse = 1.5343;
         bool isDetailingMethod = false;

         //1.0608

         //Act
         var response = MathFunctions.DivideNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Divide_Detailing_UnitTest()
      {
         //Arrange
         var num1 = 23.0608;
         var num2 = 15.0302;
         var expectedResponse = 1.0608;
         bool isDetailingMethod = true;

         //Act
         var response = MathFunctions.DivideNumbers(num1, num2, isDetailingMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
