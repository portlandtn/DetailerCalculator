using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class Math_Unit_Tests
   {
      [TestMethod]
      public void Add_Standard_UnitTest()
      {
         //Arrange
         bool isDetailingMethod = false;
         var num1a = 22.1115;
         var num1b = 0.0005;
         var expectedResponse1 = 22.112;
         var num2a = 14.0208;
         var num2b = 2.2113;
         var expectedResponse2 = 16.2321;
         var num3a = 51.2369;
         var num3b = 11.6528;
         var expectedResponse3 = 62.8897;
         var num4a = 21.6325;
         var num4b = -25.1985;
         var expectedResponse4 = -3.566;

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
         var num1a = 22.1115;
         var num1b = 0.0005;
         var expectedResponse1 = 23.0004;
         var num2a = 52.0208;
         var num2b = 0.1113;
         var expectedResponse2 = 53.0205;
         var num3a = 17.1111;
         var num3b = 6.0908;
         var expectedResponse3 = 24.0903;
         var num4a = 16.0005;
         var num4b = -18.0208;
         var expectedResponse4 = -2.0203;


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
         var num1a = 23.1102;
         var num1b = 0.0005;
         var expectedResponse1 = 23.1097;
         var num2a = 11.0206;
         var num2b = 0.1111;
         var expectedResponse2 = 10.9095;
         var num3a = 16;
         var num3b = 0.5;
         var expectedResponse3 = 15.5;
         var num4a = 11.958;
         var num4b = -0.25;
         var expectedResponse4 = 12.208;


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
         var num1a = 23.1102;
         var num1b = 0.0005;
         var expectedResponse1 = 23.1013;
         var num2a = 14.0508;
         var num2b = 0.0009;
         var expectedResponse2 = 14.0415;
         var num3a = 89.1011;
         var num3b = 69.1115;
         var expectedResponse3 = 19.1012;
         var num4a = 11.0208;
         var num4b = -25.0603;
         var expectedResponse4 = 36.0811;


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
         var num1a = 51;
         var num1b = 25;
         var expectedResponse1 = 1275;
         var num2a = 71.258;
         var num2b = 0.25;
         var expectedResponse2 = 17.8145;
         var num3a = 61.957;
         var num3b = 17.6915;
         var expectedResponse3 = 1096.1123;
         var num4a = 11.527;
         var num4b = -16.23;
         var expectedResponse4 = -187.0832;

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
         var num1a = 23.1102;
         var num1b = 0.0005;
         var expectedResponse1 = 0.0708;
         var num2a = 11.0508;
         var num2b = 1.0204;
         var expectedResponse2 = 13.0705;
         var num3a = 16.1115;
         var num3b = 21.0212;
         var expectedResponse3 = 360.0907;
         var num4a = 11.1110;
         var num4b = -2.0608;
         var expectedResponse4 = -30.0501;

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
         var num1a = 6;
         var num1b = 3;
         var expectedResponse1 = 2;
         var num2a = 21.627;
         var num2b = 0.25;
         var expectedResponse2 = 86.508;
         var num3a = 11.9417;
         var num3b = 71.825;
         var expectedResponse3 = 0.1663;
         var num4a = 18.5258;
         var num4b = -63.14;
         var expectedResponse4 = -0.2934;

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
         var num1a = 23.1102;
         var num1b = 0.0005;
         var expectedResponse1 = 918.0910;
         var num2a = 16.0508;
         var num2b = 10.0507;
         var expectedResponse2 = 1.0614;
         var num3a = 41.1115;
         var num3b = 0.0003;
         var expectedResponse3 = 2687.08;
         var num4a = 1.1112;
         var num4b = -0.0012;
         var expectedResponse4 = -31.08;

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
         double num1 = 2.0408;
         double num2 = 1.0611;
         var detailingMath = false;
         var expectedResponse = 3.1019;

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
         double num1 = 2.0408;
         double num2 = 2.9857;
         var detailingMath = false;
         var expectedResponse = -0.9449;

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
         double num1 = 2.0408;
         double num2 = 1.0509;
         var detailingMath = false;
         var expectedResponse = 2.1447;

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
         double num1 = 2.0408;
         double num2 = 3.5;
         var detailingMath = false;
         var expectedResponse = 0.5831;

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
         double num1 = 2.0408;
         double num2 = 6.0208;
         var detailingMath = true;
         var expectedResponse = 8.07;

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
         double num1 = 16.0208;
         double num2 = 11.0515;
         var detailingMath = true;
         var expectedResponse = 4.0809;

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
         double num1 = 16.0205;
         double num2 = 11.05;
         var detailingMath = true;
         var expectedResponse = 184.1006;

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
         double num1 = 2.0408;
         double num2 = 6.0208;
         var detailingMath = true;
         var expectedResponse = 0.0409;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
