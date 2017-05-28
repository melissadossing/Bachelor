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
    public class ViewModelMapperTest
    {
        [Fact]
        public async Task ViewModelMapper_IsNotNull_AfterCreation()
        {
            // Arrange
            var vmmapper = new ViewModelMapper();

            // Act

            // Assert
            Assert.NotNull(vmmapper);
        }
    }
}
