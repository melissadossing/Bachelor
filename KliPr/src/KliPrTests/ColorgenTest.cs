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
    public class ColorgenTest
    {
        [Fact]
        public async Task Colorgen_IsNotNull_AfterCreation()
        {
            // Arrange
            var cgen = new Colorgen();

            // Act

            // Assert
            Assert.NotNull(cgen);
        }
    }
}
}
