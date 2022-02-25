using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Abstractions;

namespace LoremIpsumLogistica.Test
{
    public class AddressFixture
    {
        public Client client => new Client("First Name", "Last Name", DateTime.Parse("01/01/1980"), Genre.Male);
        public Address addressPassed => new Address(client.Id, TypeAddress.Residential, 78655548, "Rua Afonso Pena", 568, "A", "Palmira", "RJ");
        public Address addressFailed => new Address(client.Id, TypeAddress.Residential, 0, " ", 0, "A", "Palmira", " ");
    }
    public class AddressTests : IClassFixture<AddressFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly AddressFixture _fixture;

        public AddressTests(ITestOutputHelper testOutputHelper, AddressFixture addressFixture)
        {
            _testOutputHelper = testOutputHelper;
            _fixture = addressFixture;
            _testOutputHelper.WriteLine("Constructor");
        }
        [Fact]
        public void AddressTest_ZipCode_Equals8Numbers_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Equals8Number");
            var cep = _fixture.addressPassed.ZipCode;
            Assert.True(cep.ToString().Length == 8);
        }
        [Fact]
        public void AddressTest_ZipCode_Different8Numbers_ReturnFalse()
        {
            _testOutputHelper.WriteLine("Different8Number");
            var cep = _fixture.addressPassed.ZipCode;
            Assert.False(cep.ToString().Length != 8);
        }
        [Fact]
        public void AddressTest_ZipCodeValidator_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 0, MakeString(40), 568, "A", "Palmira", "RJ"));
            Assert.Equal("Zip Code must contain 8 numbers", nameException.Message);
        }
        [Fact]
        public void AddressTest_Place_BiggerThen5charLess150_ReturnTrue()
        {
            _testOutputHelper.WriteLine("BiggerThen5charLess150");
            var place = _fixture.addressPassed.Place.Length;
            Assert.True(place < 150 && place > 5);
        }
        [Fact]
        public void AddressTest_Place_IsNullOrEmpty_ReturnFalse()
        {
            _testOutputHelper.WriteLine("Ckeck_IsNullOrEmpty");
            Assert.False(string.IsNullOrEmpty(_fixture.addressPassed.Place));
        }
        [Fact]
        public void AddressTest_Place_Null_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, "", 568, "A", "Palmira", "RJ"));
            Assert.Equal("The Place cannot be empty!", nameException.Message);
        }
        [Fact]
        public void AddressTest_Place_BiggerThen5charLess150_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(1), 568, "A", "Palmira", "RJ"));
            Assert.Equal("The Place must contain more than 5 characters and less than 150", nameException.Message);
        }
        [Fact]
        public void AddressTest_Number_Bigger0_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Bigger0");
            var number = _fixture.addressPassed.Number;
            Assert.True(number > 0);
        }
        [Fact]
        public void AddressTest_NumberValidator_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(40), 0, "A", "Palmira", "RJ"));
            Assert.Equal("Number must be greater than zero", nameException.Message);
        }
        [Fact]
        public void AddressTest_State_Equals2Char_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Equals2Char");
            var state = _fixture.addressPassed.State.Length;
            Assert.True(state == 2);
        }
        [Fact]
        public void AddressTest_State_Validating_Null_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(40), 52, "A", "Palmira", ""));
            Assert.Equal("State cannot be empty", nameException.Message);
        }
        [Fact]
        public void AddressTest_State_Validating_Equals2Char_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(40), 52, "A", "Palmira", "M"));
            Assert.Equal("State must contain 2 characters", nameException.Message);
        }
        [Fact]
        public void AddressTest_State_Validating_ContainNumbers_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(40), 56, "A", "Palmira", "M2"));
            Assert.Equal("State cannot contain numbers and special characters", nameException.Message);
        }
        [Fact]
        public void AddressTest_State_Validating_ContainSpecialCharacters_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(40), 56, "A", "Palmira", "M$"));
            Assert.Equal("State cannot contain numbers and special characters", nameException.Message);
        }
        [Fact]
        public void AddressTest_State_Validating_ContainWhiteSpace_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(_fixture.client.Id, TypeAddress.Residential, 78655548, MakeString(40), 59, "A", "Palmira", "M "));
            Assert.Equal("State cannot contain numbers and special characters", nameException.Message);
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
