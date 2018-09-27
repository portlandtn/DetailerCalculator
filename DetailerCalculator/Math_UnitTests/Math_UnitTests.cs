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
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 22.1115;
         var num2 = 0.0005;
         var expectedResponse = 22.112;
         var detailingMathMethod = false;

         //Act
         var response = mathFunc.AddNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Add_Detailing_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 22.1115;
         var num2 = 0.0005;
         var expectedResponse = 23.0004;
         var detailingMathMethod = true;

         //Act
         var response = mathFunc.AddNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Subtract_Standard_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 23.1102;
         var num2 = 0.0005;
         var expectedResponse = 23.1097;
         var detailingMathMethod = false;

         //Act
         var response = mathFunc.SubtractNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Subtract_Detailing_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 23.1102;
         var num2 = 0.0003;
         var expectedResponse = 23.1015;
         var detailingMathMethod = true;

         //Act
         var response = mathFunc.SubtractNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Multiply_Standard_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 12.0204;
         var num2 = 14.0806;
         var expectedResponse = 169.2544;
         var detailingMathMethod = false;
         //Act
         var response = mathFunc.MultiplyNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Multiply_Detailing_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 12.0204;
         var num2 = 14.0806;
         var expectedResponse = 179.0109;
         var detailingMathMethod = true;
         //Act
         var response = mathFunc.MultiplyNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Divide_Standard_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 12.0204;
         var num2 = 14.0806;
         var expectedResponse = 0.8537;
         var detailingMathMethod = false;
         //Act
         var response = mathFunc.DivideNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Divide_Detailing_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var num1 = 12.0204;
         var num2 = 14.0806;
         var expectedResponse = 0.0915;
         var detailingMathMethod = true;
         //Act
         var response = mathFunc.DivideNumbers(num1, num2, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
