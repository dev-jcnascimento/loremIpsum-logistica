using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Abstractions;

namespace LoremIpsumLogistica.Test
{
    public class ClientFixture
    {
        public Client client => new Client("First Name","Last Name",DateTime.Parse("01/01/1980"), Genre.Male);
    }
    public class ClientTests : IClassFixture<ClientFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ClientFixture _fixture;

        public ClientTests(ITestOutputHelper testOutputHelper, ClientFixture clientFixture)
        {
            _testOutputHelper = testOutputHelper;
            _fixture = clientFixture;
            _testOutputHelper.WriteLine("Constructor");
        }

        [Fact]
        public void ClientTest_FirstName_BiggerThen3charLess60_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Check_BiggerThen3charLess60");
            var name = _fixture.client.FirstName.Length;
            Assert.True(name < 60 && name > 3);
        }
        [Fact]
        public void ClientTest_FirstName_IsNullOrEmpty_ReturnFalse()
        {
            _testOutputHelper.WriteLine("Ckeck_IsNullOrEmpty");
            Assert.False(string.IsNullOrEmpty(_fixture.client.FirstName));
        }
        [Fact]
        public void ClientTest_LastFirst_BiggerThen3charLess60_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Check_BiggerThen3charLess60");
            var name = _fixture.client.LastName.Length;
            Assert.True(name < 60 && name > 3);
        }
        [Fact]
        public void ClientTest_LastName_IsNullOrEmpty_ReturnFalse()
        {
            _testOutputHelper.WriteLine("Ckeck_IsNullOrEmpty");
            Assert.False(string.IsNullOrEmpty(_fixture.client.LastName));
        }
        [Fact]
        public void ClientTest_FirstName_BiggerThen3Char_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() => 
            new Client(MakeString(2), "Last Name", DateTime.Parse("01/01/1980"), Genre.Male));
            Assert.Equal("The FirstName must contain more than 3 characters and less than 60", nameException.Message);
        }
        [Fact]
        public void ClientTest_FirstName_Less60Char_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Client(MakeString(80), "Last Name", DateTime.Parse("01/01/1980"), Genre.Male));
            Assert.Equal("The FirstName must contain more than 3 characters and less than 60", nameException.Message);
        }
        [Fact]
        public void ClientTest_LastName_BiggerThen3Char_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Client("First Name", MakeString(2), DateTime.Parse("01/01/1980"), Genre.Male));
            Assert.Equal("The LastName must contain more than 3 characters and less than 60", nameException.Message);
        }
        [Fact]
        public void ClientTest_LastName_Less60Char_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Client("First Name", MakeString(80), DateTime.Parse("01/01/1980"), Genre.Male));
            Assert.Equal("The LastName must contain more than 3 characters and less than 60", nameException.Message);
        }
        public static string MakeString(int length)
        {
            var result = "";
            for (int i = 1; i <= length; i++)
            {
                result += "a";
            }
            return result;
        }
    }
}
