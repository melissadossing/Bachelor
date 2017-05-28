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
    public class AccountControllerTests
    {
        [Fact]
        public async Task Login_ReturnsViewResult_WithALockContext()
        {
            // Arrange
            var controller = new AccountController();

            // Act
            var result = await controller.Login();

            // Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<LockContext>>(
    redirect.ViewData.Model);
        }
        [Fact]
        public async Task Logout_Redirect_WithStrings()
        {
            // Arrange
            var controller = new AccountController();

            // Act
            var result = await controller.Logout();

            // Assert
            var redirect = Assert.IsType<Task>(result);
        }
        [Fact]
        public async Task Claims_ReturnsViewResult_WithoutArguments()
        {
            // Arrange
            var controller = new AccountController();

            // Act
            var result = await controller.Claims();

            // Assert
            var redirect = Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
