using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;
using System.Collections.Generic;

namespace UnitTests
{
   [TestClass]
   public class Settings_UnitTests
   {
     [TestMethod]
     public void DetermineSingleNumberForMath_NonEmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { 1, 18, 42, 21 };
         int outputWindowListCount = list.Count;
         double expectedResponse = 42;

         //Act
         double response = Settings.DetermineFirstNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void DetermineSingleNumberForMath_EmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { };
         int outputWindowListCount = list.Count;
         double expectedResponse = 0;

         //Act
         double response = Settings.DetermineFirstNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DetermineSecondNumberForMath_NonEmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { 1, 18, 42, 21 };
         int outputWindowListCount = list.Count;
         double expectedResponse = 21;

         //Act
         double response = Settings.DetermineSecondNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void DetermineSecondNumberForMath_EmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { };
         int outputWindowListCount = list.Count;
         double expectedResponse = 0;

         //Act
         double response = Settings.DetermineSecondNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void FoootToDecimalButtonClick_EmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { };
         int outputWindowListCount = list.Count;
         double expectedResponse = 0;

         //Act
         double response = Settings.FootToDecimalButtonClick(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void FootToDecimalButtonClick_NonEmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { 1.0204, 2.0608, 3.1112};
         int outputWindowListCount = list.Count;
         double expectedResponse = 3.9792;

         //Act
         double response = Settings.FootToDecimalButtonClick(outputWindowListCount, list);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DecimalToFoot_EmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { };
         int outputWindowListCount = list.Count;
         double expectedResponse = 0;

         //Act
         double response = Settings.DecimalToFootButtonClick(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DecimalToFoot_NonEmptyList_UnitTest()
      {
         //Arrange
         List<double> list = new List<double> { 13.2154, 16.5, 21.0208 };
         int outputWindowListCount = list.Count;
         double expectedResponse = 21.0004;

         //Act
         double response = Settings.DecimalToFootButtonClick(outputWindowListCount, list);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_b2s__Standard_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "b2s";
         bool isDetailingMathMethod = false;
         var expectedResponse = 1.0518;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_b2r__Standard_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "b2r";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.2551;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2b__Standard_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "s2b";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.9899;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2r__Standard_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "s2r";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.2475;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2b__Standard_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "r2b";
         bool isDetailingMathMethod = false;
         var expectedResponse = 4.0816;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2s__Standard_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "r2s";
         bool isDetailingMathMethod = false;
         var expectedResponse = 4.2072;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }


      [TestMethod]
      public void TrigFunctionButtonClick_b2s__Detailing_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "b2s";
         bool isDetailingMathMethod = true;
         var expectedResponse = 1.0211;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_b2r__Detailing_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "b2r";
         bool isDetailingMathMethod = true;
         var expectedResponse = 0.0309;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2b__Detailing_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "s2b";
         bool isDetailingMathMethod = true;
         var expectedResponse = 1.0113;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2r__Detailing_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "s2r";
         bool isDetailingMathMethod = true;
         var expectedResponse = 0.0307;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2b__Detailing_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "r2b";
         bool isDetailingMathMethod = true;
         var expectedResponse = 4.09;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2s__Detailing_UnitTest()
      {
         //Arrange
         double num = 1.0204;
         double angle = 14.036243;
         string function = "r2s";
         bool isDetailingMathMethod = true;
         var expectedResponse = 4.1012;

         //Act
         double response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
