using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class MathTests
   {
      [TestMethod]
      public void Add_Standard_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = false;
         var num1a = 22.1115m;
         var num1b = 0.0005m;
         var expectedResponse1 = 22.112m;
         var num2a = 14.0208m;
         var num2b = 2.2113m;
         var expectedResponse2 = 16.2321m;
         var num3a = 51.2369m;
         var num3b = 11.6528m;
         var expectedResponse3 = 62.8897m;
         var num4a = 21.6325m;
         var num4b = -25.1985m;
         var expectedResponse4 = -3.566m;

         //Act
         var response1 = Math.Round(MathFunctions.AddNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.AddNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.AddNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.AddNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Add_Detailing_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = true;
         var num1a = 22.1115m;
         var num1b = 0.0005m;
         var expectedResponse1 = 23.0004m;
         var num2a = 52.0208m;
         var num2b = 0.1113m;
         var expectedResponse2 = 53.0205m;
         var num3a = 17.1111m;
         var num3b = 6.0908m;
         var expectedResponse3 = 24.0903m;
         var num4a = 16.0005m;
         var num4b = -18.0208m;
         var expectedResponse4 = -2.0203m;


         //Act
         var response1 = Math.Round(MathFunctions.AddNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.AddNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.AddNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.AddNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Subtract_Standard_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = false;
         var num1a = 23.1102m;
         var num1b = 0.0005m;
         var expectedResponse1 = 23.1097m;
         var num2a = 11.0206m;
         var num2b = 0.1111m;
         var expectedResponse2 = 10.9095m;
         var num3a = 16m;
         var num3b = 0.5m;
         var expectedResponse3 = 15.5m;
         var num4a = 11.958m;
         var num4b = -0.25m;
         var expectedResponse4 = 12.208m;


         //Act
         var response1 = Math.Round(MathFunctions.SubtractNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.SubtractNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.SubtractNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.SubtractNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Subtract_Detailing_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = true;
         var num1a = 23.1102m;
         var num1b = 0.0005m;
         var expectedResponse1 = 23.1013m;
         var num2a = 14.0508m;
         var num2b = 0.0009m;
         var expectedResponse2 = 14.0415m;
         var num3a = 89.1011m;
         var num3b = 69.1115m;
         var expectedResponse3 = 19.1012m;
         var num4a = 11.0208m;
         var num4b = -25.0603m;
         var expectedResponse4 = 36.0811m;


         //Act
         var response1 = Math.Round(MathFunctions.SubtractNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.SubtractNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.SubtractNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.SubtractNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Multiply_Standard_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = false;
         var num1a = 51m;
         var num1b = 25m;
         var expectedResponse1 = 1275m;
         var num2a = 71.258m;
         var num2b = 0.25m;
         var expectedResponse2 = 17.8145m;
         var num3a = 61.957m;
         var num3b = 17.6915m;
         var expectedResponse3 = 1096.1123m;
         var num4a = 11.527m;
         var num4b = -16.23m;
         var expectedResponse4 = -187.0832m;

         //Act
         var response1 = Math.Round(MathFunctions.MultiplyNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.MultiplyNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.MultiplyNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.MultiplyNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Multiply_Detailing_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = true;
         var num1a = 23.1102m;
         var num1b = 0.0005m;
         var expectedResponse1 = 0.0708m;
         var num2a = 11.0508m;
         var num2b = 1.0204m;
         var expectedResponse2 = 13.0704m;
         var num3a = 16.1115m;
         var num3b = 21.0212m;
         var expectedResponse3 = 360.0907m;
         var num4a = 11.1110m;
         var num4b = -2.0608m;
         var expectedResponse4 = -30.0501m;

         //Act
         var response1 = Math.Round(MathFunctions.MultiplyNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.MultiplyNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.MultiplyNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.MultiplyNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Divide_Standard_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = false;
         var num1a = 6m;
         var num1b = 3m;
         var expectedResponse1 = 2m;
         var num2a = 21.627m;
         var num2b = 0.25m;
         var expectedResponse2 = 86.508m;
         var num3a = 11.9417m;
         var num3b = 71.825m;
         var expectedResponse3 = 0.1663m;
         var num4a = 18.5258m;
         var num4b = -63.14m;
         var expectedResponse4 = -0.2934m;

         //Act
         var response1 = Math.Round(MathFunctions.DivideNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.DivideNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.DivideNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.DivideNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void Divide_Detailing_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = true;
         var num1a = 23.1102m;
         var num1b = 0.0005m;
         var expectedResponse1 = 918.0910m;
         var num2a = 16.0508m;
         var num2b = 10.0507m;
         var expectedResponse2 = 1.0614m;
         var num3a = 41.1115m;
         var num3b = 0.0003m;
         var expectedResponse3 = 2687.08m;
         var num4a = 1.1112m;
         var num4b = -0.0012m;
         var expectedResponse4 = -31.08m;

         //Act
         var response1 = Math.Round(MathFunctions.DivideNumbers(num1a, num1b, isDetailingMethod), 4);
         var response2 = Math.Round(MathFunctions.DivideNumbers(num2a, num2b, isDetailingMethod), 4);
         var response3 = Math.Round(MathFunctions.DivideNumbers(num3a, num3b, isDetailingMethod), 4);
         var response4 = Math.Round(MathFunctions.DivideNumbers(num4a, num4b, isDetailingMethod), 4);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
         Assert.AreEqual(expectedResponse3, response3);
         Assert.AreEqual(expectedResponse4, response4);
      }

      [TestMethod]
      public void DoMath_Standard_Add_UnitTest()
      {
         //Arrange
         var function = "Add";
         var num1 = 2.0408m;
         var num2 = 1.0611m;
         var detailingMath = false;
         var expectedResponse = 3.1019m;

         //Act
         var response = MathFunctions.DoMath(function,num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DoMath_Standard_Subtract_UnitTest()
      {
         //Arrange
         var function = "Subtract";
         var num1 = 2.0408m;
         var num2 = 2.9857m;
         var detailingMath = false;
         var expectedResponse = -0.9449m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DoMath_Standard_Multiply_UnitTest()
      {
         //Arrange
         var function = "Multiply";
         var num1 = 2.0408m;
         var num2 = 1.0509m;
         var detailingMath = false;
         var expectedResponse = 2.1447m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DoMath_Standard_Divide_UnitTest()
      {
         //Arrange
         var function = "Divide";
         var num1 = 2.0408m;
         var num2 = 3.5m;
         var detailingMath = false;
         var expectedResponse = 0.5831m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DoMath_Detailing_Add_UnitTest()
      {
         //Arrange
         var function = "Add";
         var num1 = 2.0408m;
         var num2 = 6.0208m;
         var detailingMath = true;
         var expectedResponse = 8.07m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
      [TestMethod]
      public void DoMath_Detailing_Subtract_UnitTest()
      {
         //Arrange
         var function = "Subtract";
         var num1 = 16.0208m;
         var num2 = 11.0515m;
         var detailingMath = true;
         var expectedResponse = 4.0809m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DoMath_Detailing_Multiply_UnitTest()
      {
         //Arrange
         var function = "Multiply";
         var num1 = 16.0205m;
         var num2 = 11.05m;
         var detailingMath = true;
         var expectedResponse = 184.1006m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DoMath_Detailing_Divide_UnitTest()
      {
         //Arrange
         var function = "Divide";
         var num1 = 2.0408m;
         var num2 = 6.0208m;
         var detailingMath = true;
         var expectedResponse = 0.0409m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
