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
    public class ChartPreparerTest
    {
        [Fact]
        public async Task ChartPreparer_IsNotNull_AfterCreation()
        {
            // Arrange
            var cprepper = new ChartPreparer();

            // Act

            // Assert
            Assert.NotNull(cprepper);
        }
    }
}
