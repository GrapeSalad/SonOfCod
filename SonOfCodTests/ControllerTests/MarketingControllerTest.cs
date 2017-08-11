using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCodTests.ControllerTests
{
    [Collection("SonOfCodTests")]
    public class MarketingControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
             
            //Arrange
            MarketingController controller = new MarketingController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
