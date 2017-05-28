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
    public class PatientControllerTests
    {
        [Fact]
        public async Task Index_ReturnsAViewResult_WithoutArguments()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task SelectQuestoinnaire_ReturnsAViewResult_WithAListOfQuestionnaireViewModel()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.SelectQuestionnaire();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Questionnaire>>(
                viewResult.ViewData.Model);
        }

        [Fact]
        public async Task SelectQuestoinnaire_ReturnsARedirect_WithAListOfStrings()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.SelectQuestionnaire();

            // Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<string>>(
                redirect.ViewData.Model);
        }

        [Fact]
        public async Task Participant_ReturnsAViewResult_WithNoArguments()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.Participant();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Participant_Redirect_WithStrings()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.Participant();

            // Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<string>>(
    redirect.ViewData.Model);
        }
        
        [Fact]
        public async Task Participant_Redirect_WithStrings()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.Participant();

            // Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<string>>(
    redirect.ViewData.Model);
        }

        [Fact]
        public async Task Succes_ReturnsViewresult_WithoutArguments()
        {
            // Arrange
            var controller = new PatientController();

            // Act
            var result = await controller.Succes();

            // Assert
            var redirect = Assert.IsType<ViewResult>(result);
        }
    }
}
