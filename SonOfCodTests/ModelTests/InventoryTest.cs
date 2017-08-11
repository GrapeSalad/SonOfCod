using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class PlayerTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var inventoryItem = new Inventory();
            inventoryItem.Description = "Dude this thing can break your finger. Watch out.";
            inventoryItem.Name = "Mantis Shrimp";
            inventoryItem.Cost = 12.99M;

            //Act
            var result = inventoryItem.Description;
            var namez = inventoryItem.Name;
            var cawst = inventoryItem.Cost;

            //Assert
            Assert.Equal("Dude this thing can break your finger. Watch out.", result);
            Assert.Equal("Mantis Shrimp", namez);
            Assert.Equal(12.99M, cawst);
        }
    }
}
