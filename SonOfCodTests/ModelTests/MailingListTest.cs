using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCod.Models;
using Xunit;

namespace SonOfCodTests.ModelTests
{
    public class PlayerTest
    {
        [Fact]
        public void Verify_MailingListEntry_Test()
        {
            //Arrange
            var mailingListEntry = new MailingList();
            mailingListEntry.FirstName = "Kronk";
            mailingListEntry.LastName = "Just Kronk";
            mailingListEntry.Email = "squeakSqueakerSqueakin@gmail.com";

            //Act
            var fName = mailingListEntry.FirstName;
            var lName = mailingListEntry.LastName;
            var email = mailingListEntry.Email;

            //Assert
            Assert.Equal("Kronk", fName);
            Assert.Equal("Just Kronk", lName);
            Assert.Equal("squeakSqueakerSqueakin@gmail.com", email);
        }
    }
}
