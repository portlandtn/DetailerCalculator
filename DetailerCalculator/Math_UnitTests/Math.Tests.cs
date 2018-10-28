using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;
using System.Collections.Generic;

namespace UnitTests
{
   /// <summary>
   /// Test class designed to test the Math Functions class only.
   /// </summary>
   [TestClass]
   public class MathTests
   {
      /// <summary>
      /// Returns the sum of two numbers based on traditional math.
      /// </summary>
      [TestMethod]
      public void Add_Standard()
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

      /// <summary>
      /// Returns the sum of two numbers based on detailing formatted numbers.
      /// </summary>
      [TestMethod]
      public void Add_Detailing()
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

      /// <summary>
      /// Returns the difference of two numbers based on traditional math.
      /// </summary>
      [TestMethod]
      public void Subtract_Standard()
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

      /// <summary>
      /// Returns the difference of two numbers based on numbers formatted to detailing standards.
      /// </summary>
      [TestMethod]
      public void Subtract_Detailing()
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

      /// <summary>
      /// Returns the product of two numbers based on traditional math.
      /// </summary>
      [TestMethod]
      public void Multiply_Standard()
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

      /// <summary>
      /// Returns the product of two numbers based on detailing formatted numbers.
      /// </summary>
      [TestMethod]
      public void Multiply_Detailing()
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

      /// <summary>
      /// Returns the quotient of two numbers based on traditional math.
      /// </summary>
      [TestMethod]
      public void Divide_Standard()
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

      /// <summary>
      /// Returns the quotient of two numbers based on detailing formatted numbers.
      /// </summary>
      [TestMethod]
      public void Divide_Detailing()
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

      /// <summary>
      /// Returns the sum of two numbers using standard math, based on the function input "add".
      /// </summary>
      [TestMethod]
      public void DoMath_Standard_Add()
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

      /// <summary>
      /// Returns the difference of two numbers using standard math, based on the function input "subtract".
      /// </summary>
      [TestMethod]
      public void DoMath_Standard_Subtract()
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

      /// <summary>
      /// Returns the product of two numbers using standard math, based on the function input "multiply".
      /// </summary>
      [TestMethod]
      public void DoMath_Standard_Multiply()
      {
         //Arrange
         var function = "Multiply";
         var num1 = 2.0408m;
         var num2 = 1.0509m;
         var detailingMath = false;
         var expectedResponse = 2.1447m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Returns the quotient of two numbers using standard math, based on the function input "divide".
      /// </summary>
      [TestMethod]
      public void DoMath_Standard_Divide()
      {
         //Arrange
         var function = "Divide";
         var num1 = 2.0408m;
         var num2 = 3.5m;
         var detailingMath = false;
         var expectedResponse = 0.5831m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Returns the sum of two numbers using detailing formatted numbers, based on the function input of "add".
      /// </summary>
      [TestMethod]
      public void DoMath_Detailing_Add()
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

      /// <summary>
      /// Returns the difference of two numbers using detailing formatted numbers, based on the function input of "subtract".
      /// </summary>
      [TestMethod]
      public void DoMath_Detailing_Subtract()
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

      /// <summary>
      /// Returns the product of two numbers using detailing formatted numbers, based on the function input of "multiply".
      /// </summary>
      [TestMethod]
      public void DoMath_Detailing_Multiply()
      {
         //Arrange
         var function = "Multiply";
         var num1 = 16.0205m;
         var num2 = 11.05m;
         var detailingMath = true;
         var expectedResponse = 184.1006m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Returns the quotient of two numbers using detailing formatted numbers, based on the function input of "divide".
      /// </summary>
      [TestMethod]
      public void DoMath_Detailing_Divide()
      {
         //Arrange
         var function = "Divide";
         var num1 = 2.0408m;
         var num2 = 6.0208m;
         var detailingMath = true;
         var expectedResponse = 0.0409m;

         //Act
         var response = MathFunctions.DoMath(function, num1, num2, detailingMath);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks to make sure the first number used for math is either the bottom number, based on numbers required for the calculation,
      /// or the next one up, if two numbers are required.
      /// </summary>
      [TestMethod]
      public void DetermineSingleNumberForMath_NonEmptyList()
      {
         //Arrange
         var list = new List<decimal> { 1m, 18m, 42m, 21m };
         int outputWindowListCount = list.Count;
         var expectedResponse1 = 21m;
         var expectedResponse2 = 42m;

         //Act
         var response1 = MathFunctions.DetermineFirstNumberForMath(1, outputWindowListCount, list);
         var response2 = MathFunctions.DetermineFirstNumberForMath(2, outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);

      }

      /// <summary>
      /// Checks that the number returned is 0 when determining numbers for math because the list is empty.
      /// </summary>
      [TestMethod]
      public void DetermineSingleNumberForMath_EmptyList()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse1 = 0;
         var expectedResponse2 = 0;

         //Act
         var response1 = MathFunctions.DetermineFirstNumberForMath(1, outputWindowListCount, list);
         var response2 = MathFunctions.DetermineFirstNumberForMath(1, outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
      }

      /// <summary>
      /// Checks that the second number used for math is the last number in the list.
      /// </summary>
      [TestMethod]
      public void DetermineSecondNumberForMath_NonEmptyList()
      {
         //Arrange
         var list = new List<decimal> { 1m, 18m, 42m, 21m };
         int outputWindowListCount = list.Count;
         var expectedResponse = 21m;

         //Act
         var response = MathFunctions.DetermineSecondNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      /// <summary>
      /// Checks that the return is 0 because the list is empty.
      /// </summary>
      [TestMethod]
      public void DetermineSecondNumberForMath_EmptyList()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse = 0;

         //Act
         var response = MathFunctions.DetermineSecondNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the returned value is 0 because the list is empty.
      /// </summary>
      [TestMethod]
      public void FootToDecimalButtonClick_EmptyList()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse = 0;

         //Act
         var response = MathFunctions.FootToDecimalButtonClick(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the decimal format of the last number in the list.
      /// </summary>
      [TestMethod]
      public void FootToDecimalButtonClick_NonEmptyList()
      {
         //Arrange
         var list = new List<decimal> { 1.0204m, 2.0608m, 3.1112m };
         int outputWindowListCount = list.Count;
         var expectedResponse = 3.9792m;

         //Act
         var response = MathFunctions.FootToDecimalButtonClick(outputWindowListCount, list);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is 0 because the list is empty.
      /// </summary>
      [TestMethod]
      public void DecimalToFoot_EmptyList()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse = 0;

         //Act
         var response = MathFunctions.DecimalToFootButtonClick(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number rerturned is the foot format oft he last number in the list.
      /// </summary>
      [TestMethod]
      public void DecimalToFoot_NonEmptyList()
      {
         //Arrange
         var list = new List<decimal> { 13.2154m, 16.5m, 21.0208m };
         int outputWindowListCount = list.Count;
         var expectedResponse = 21.0004m;

         //Act
         var response = MathFunctions.DecimalToFootButtonClick(outputWindowListCount, list);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the slope dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_b2s__Standard()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2s";
         bool isDetailingMathMethod = false;
         var expectedResponse = 1.0518m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the rise dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_b2r__Standard()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2r";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.2551m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the base dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_s2b__Standard()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2b";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.9899m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the rise dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_s2r__Standard()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2r";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.2475m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the base dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_r2b__Standard()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2b";
         bool isDetailingMathMethod = false;
         var expectedResponse = 4.0816m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the slope dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_r2s__Standard()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2s";
         bool isDetailingMathMethod = false;
         var expectedResponse = 4.2072m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the slope dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_b2s__Detailing()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2s";
         bool isDetailingMathMethod = true;
         var expectedResponse = 1.0211m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the rise dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_b2r__Detailing()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2r";
         bool isDetailingMathMethod = true;
         var expectedResponse = 0.0309m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the base dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_s2b__Detailing()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2b";
         bool isDetailingMathMethod = true;
         var expectedResponse = 1.0113m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the rise dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_s2r__Detailing()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2r";
         bool isDetailingMathMethod = true;
         var expectedResponse = 0.0307m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the base dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_r2b__Detailing()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2b";
         bool isDetailingMathMethod = true;
         var expectedResponse = 4.09m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      /// <summary>
      /// Checks that the number returned is the slope dimension based on the angle and number entered, in detailing number format.
      /// </summary>
      [TestMethod]
      public void TrigFunctionButtonClick_r2s__Detailing()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2s";
         bool isDetailingMathMethod = true;
         var expectedResponse = 4.1012m;

         //Act
         var response = MathFunctions.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void CalculateWeight()
      {
         //Arrange
         var width = 8m;
         var length = 210m;
         var thickness = 0.125m;
         var expectedResponse = 60.984m;

         //Act
         var response = Math.Round(MathFunctions.CalculateWeight(width, length, thickness),4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}

