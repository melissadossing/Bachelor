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
    public class ChartPieTest
    {
        [Fact]
        public async Task ChartPie_IsNotNull_AfterCreation()
        {
            // Arrange
            var pie = new ChartPie();

            // Act

            // Assert
            Assert.NotNull(pie);
        }
    
    }
}
