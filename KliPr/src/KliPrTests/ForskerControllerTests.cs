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
    public class ForskerControllerTests
    {
        [Fact]
        public async Task ShowChart_ReturnsAViewResult_WithAQuestionnaire()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.ShowChart();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Questionnaire>>(
                viewResult.ViewData.Model);
        }

        [Fact]
        public async Task Create_ReturnsAViewResult_WithNoArguments()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.Create();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public async Task Dashboard_ReturnsAViewResult_WithAListOfQuestionnaires()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.Dashboard();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<IEnumerable<Questionnaire>>(
                viewResult.ViewData.Model);
        }

        [Fact]
        public async Task Create_ReturnsARedirect_WithStrings()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.Create();

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Create", redirectToActionResult.ActionName);
        }

        [Fact]
        public async Task Delete_ReturnsAViewResult_WithAQuestionnaireListViewModel()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.Delete();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<QuestionnaireListViewModel>>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task Delete_RedirectToActionResult_WithStrings()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.Delete();

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Delete", redirectToActionResult.ActionName);
        }

        [Fact]
        public async Task SetActive_ReturnsAViewResult_WithAListOfQuestionnaireListViewModel()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.SetActive();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<QuestionnaireListViewModel>>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task SetActive_ReturnsARedirect_WithStrings()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.SetActive();

            // Assert
            var redirectResult = Assert.IsType< RedirectToActionResult(result);
            var model = Assert.IsAssignableFrom<IEnumerable<String>>(redirectResult.ViewData.Model);
        }

        [Fact]
        public async Task ChooseForChart_ReturnsAViewResult_WithAListOfQuestionnaireListViewModel()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.ChooseForChart();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<QuestionnaireListViewModel>>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task ChooseForChart_ReturnsAViewResult_WithAListOfBrainstormSessions()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.ChooseForChart();

            // Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<string>>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task ChooseForExport_ReturnsAViewResult_WithAListOfQuestionnaireListViewModel()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.ChooseForExport();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<QuestionaireListViewModel>>(viewResult.ViewData.Model);
        }

        [Fact]
        public async Task ChooseForExport_ReturnsARedirect_WithStrings()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.ChooseForExport();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task DownloadQFile_ReturnsAFile()
        {
            // Arrange
            var controller = new ForskerController();

            // Act
            var result = await controller.DownloadQFile();

            // Assert
            var viewResult = Assert.IsType<string>(result);
            Assert.Null(viewResult.ControllerName);
            Assert.Equal("DownloadQFile", viewResult.ActionName);
        }


    }
}



