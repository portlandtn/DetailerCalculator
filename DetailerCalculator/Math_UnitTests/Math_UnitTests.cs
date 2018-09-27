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
         var expectedResponse = 39;
         var detailingMathMethod = false;
         //Act
         var response = mathFunc.AddNumbers(21, 18, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Subtract_Standard_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var expectedResponse = 3;
         var detailingMathMethod = false;
         //Act
         var response = mathFunc.AddNumbers(21, -18, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void Multiply_UnitTest()
      {
         //Arrange
         MathFunctions mathFunc = new MathFunctions();
         var expectedResponse = 378;
         var detailingMathMethod = false;
         //Act
         var response = mathFunc.MultiplyNumbers(21, 18, detailingMathMethod);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
