using Microsoft.AspNetCore.Mvc;
using KliPr.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using KliPr.Models;
using System.Text;
using KliPr.DAL;
using KliPr.Helpers;
using System;
using Xunit;
using Moq;

namespace KliPrTests
{
    public class IntegrationTest
    {
        [Fact]
        public async Task ShowChart_ReturnsAViewResult_WithAQuestionnaire()
        {
            // Arrange
            var AController = new AccountController();
            var PController = new PatientController();
            var FController = new ForskerController();

            // Act
            var result1 = await FController.ShowChart();
            var result2 = await AController.Claims();
            var result3 = await PController.SelectQuestionnaire();

            // Assert

            var redirect2 = Assert.IsType<RedirectToActionResult>(result2);
            var viewResult1 = Assert.IsType<ViewResult>(result1);
            var viewResult3 = Assert.IsType<ViewResult>(result3);
        }
    }
}
