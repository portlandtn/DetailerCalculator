﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DetailerCalculator;
using System;

namespace UnitTests
{
   [TestClass]
   public class SideSidesTrig_UnitTests
   {
      [TestMethod]
      public void BaseRiseToSlope_UnitTest()
      {
         //Arrange
         var bayse = 3m;
         var userRise = 4m;
         var expectedResponse = 5m;

         //Act
         var response = Math.Round(SidesTrig.BaseRiseToSlope(bayse, userRise), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);
      }

      [TestMethod]
      public void BaseToSlope_UnitTest()
      {
         //Arrange
         var bayse = 12m;
         var angle = 26.5651m;
         var expectedResponse = 13.4164m;

         //Act
         var response = Math.Round(SidesTrig.BaseToSlope(bayse, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void BaseToRise_UnitTest()
      {
         //Arrange
         var bayse = 4.21m;
         var angle = 26.5651m;
         var expectedResponse = 2.105m;

         //Act
         var response = Math.Round(SidesTrig.BaseToRise(bayse, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToBase_UnitTest()
      {
         //Arrange
         var slope = 5.418m;
         var angle = 26.5651m;
         var expectedResponse = 4.846m;

         //Act
         var response = Math.Round(SidesTrig.SlopeToBase(slope, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void SlopeToRise_UnitTest()
      {
         //Arrange
         var slope = 9.615m;
         var angle = 26.5651m;
         var expectedResponse = 4.3m;

         //Act
         var response = Math.Round(SidesTrig.SlopeToRise(slope, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RisetoSlope_UnitTest()
      {
         //Arrange
         var rise = 1.5m;
         var angle = 26.5651m;
         var expectedResponse = 3.3541m;

         //Act
         var response = Math.Round(SidesTrig.RiseToSlope(rise, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }

      [TestMethod]
      public void RiseToBase_UnitTest()
      {
         //Arrange
         var rise = 1.21m;
         var angle = 26.5651m;
         var expectedResponse = 2.42m;

         //Act
         var response = Math.Round(SidesTrig.RiseToBase(rise, angle), 4);

         //Assert
         Assert.AreEqual(expectedResponse, response);

      }
   }
}
