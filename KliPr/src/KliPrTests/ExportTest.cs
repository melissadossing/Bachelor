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
    public class ExportTest
    {

        [Fact]
        public async Task Export_IsNotNull_AfterCreation()
        {
            // Arrange
            ExportClient client = new ExportClient(new ExportCSV());

            // Act

            // Assert
            Assert.NotNull(client);
        }


    }
}
