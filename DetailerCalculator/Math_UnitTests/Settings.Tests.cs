using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;
using System.Collections.Generic;

namespace UnitTests
{
   [TestClass]
   public class SettingsTests
   {
     [TestMethod]
     public void DetermineSingleNumberForMath_NonEmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { 1m, 18m, 42m, 21m };
         int outputWindowListCount = list.Count;
         var expectedResponse1 = 21m;
         var expectedResponse2 = 42m;

         //Act
         var response1 = Settings.DetermineFirstNumberForMath(1, outputWindowListCount, list);
         var response2 = Settings.DetermineFirstNumberForMath(2, outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);

      }

      [TestMethod]
      public void DetermineSingleNumberForMath_EmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse1 = 0;
         var expectedResponse2 = 0;

         //Act
         var response1 = Settings.DetermineFirstNumberForMath(1, outputWindowListCount, list);
         var response2 = Settings.DetermineFirstNumberForMath(1, outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse1, response1);
         Assert.AreEqual(expectedResponse2, response2);
      }

      [TestMethod]
      public void DetermineSecondNumberForMath_NonEmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { 1m, 18m, 42m, 21m };
         int outputWindowListCount = list.Count;
         var expectedResponse = 21m;

         //Act
         var response = Settings.DetermineSecondNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void DetermineSecondNumberForMath_EmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse = 0;

         //Act
         var response = Settings.DetermineSecondNumberForMath(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void FoootToDecimalButtonClick_EmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse = 0;

         //Act
         var response = Settings.FootToDecimalButtonClick(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void FootToDecimalButtonClick_NonEmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { 1.0204m, 2.0608m, 3.1112m};
         int outputWindowListCount = list.Count;
         var expectedResponse = 3.9792m;

         //Act
         var response = Settings.FootToDecimalButtonClick(outputWindowListCount, list);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DecimalToFoot_EmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { };
         int outputWindowListCount = list.Count;
         var expectedResponse = 0;

         //Act
         var response = Settings.DecimalToFootButtonClick(outputWindowListCount, list);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void DecimalToFoot_NonEmptyList_UnitTest()
      {
         //Arrange
         var list = new List<decimal> { 13.2154m, 16.5m, 21.0208m };
         int outputWindowListCount = list.Count;
         var expectedResponse = 21.0004m;

         //Act
         var response = Settings.DecimalToFootButtonClick(outputWindowListCount, list);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_b2s__Standard_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2s";
         bool isDetailingMathMethod = false;
         var expectedResponse = 1.0518m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_b2r__Standard_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2r";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.2551m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2b__Standard_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2b";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.9899m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2r__Standard_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2r";
         bool isDetailingMathMethod = false;
         var expectedResponse = 0.2475m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2b__Standard_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2b";
         bool isDetailingMathMethod = false;
         var expectedResponse = 4.0816m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2s__Standard_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2s";
         bool isDetailingMathMethod = false;
         var expectedResponse = 4.2072m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }


      [TestMethod]
      public void TrigFunctionButtonClick_b2s__Detailing_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2s";
         bool isDetailingMathMethod = true;
         var expectedResponse = 1.0211m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_b2r__Detailing_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "b2r";
         bool isDetailingMathMethod = true;
         var expectedResponse = 0.0309m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2b__Detailing_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2b";
         bool isDetailingMathMethod = true;
         var expectedResponse = 1.0113m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_s2r__Detailing_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "s2r";
         bool isDetailingMathMethod = true;
         var expectedResponse = 0.0307m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2b__Detailing_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2b";
         bool isDetailingMathMethod = true;
         var expectedResponse = 4.09m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void TrigFunctionButtonClick_r2s__Detailing_UnitTest()
      {
         //Arrange
         var num = 1.0204m;
         var angle = 14.036243m;
         string function = "r2s";
         bool isDetailingMathMethod = true;
         var expectedResponse = 4.1012m;

         //Act
         var response = Settings.TrigFunctionButtonClick(num, angle, function, isDetailingMathMethod);
         response = Math.Round(response, 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }
   }
}
