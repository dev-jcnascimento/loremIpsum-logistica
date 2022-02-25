using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Abstractions;

namespace LoremIpsumLogistica.Test
{
    public class AddressFixture
    {
        public Address addressPassed => new Address(TypeAddress.Residential, 78655548, "Rua Afonso Pena", 568, "A", "Palmira", "RJ");
        public Address addressFailed => new Address(TypeAddress.Residential, 0, " ", 0, "A", "Palmira", " ");
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
        public void AddressTest_Cep_Equals8Numbers_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Equals8Number");
            var cep = _fixture.addressFailed.Cep;
            Assert.True(cep == 8);
        }
        [Fact]
        public void AddressTest_Cep_Different8Numbers_ReturnFalse()
        {
            _testOutputHelper.WriteLine("Different8Number");
            var cep = _fixture.addressFailed.Cep;
            Assert.False(cep != 8);
        }
        [Fact]
        public void AddressTest_Place_BiggerThen5charLess150_ReturnTrue()
        {
            _testOutputHelper.WriteLine("BiggerThen5charLess150");
            var name = _fixture.addressFailed.Place.Length;
            Assert.True(name < 150 && name > 5);
        }
        [Fact]
        public void AddressTest_Place_IsNullOrEmpty_ReturnFalse()
        {
            _testOutputHelper.WriteLine("Ckeck_IsNullOrEmpty");
            Assert.False(string.IsNullOrEmpty(_fixture.addressFailed.Place));
        }
        [Fact]
        public void AddressTest_Place_BiggerThen5charLess150_Exception()
        {
            var nameException = Assert.Throws<ValidationException>(() =>
            new Address(TypeAddress.Residential, 78655548, MakeString(1), 568, "A", "Palmira", "RJ"));
            Assert.Equal("The Address must contain more than 5 characters and less than 150", nameException.Message);
        }
        [Fact]
        public void AddressTest_Number_Bigger0_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Bigger0");
            var number = _fixture.addressFailed.Number;
            Assert.True(number > 0);
        }
        [Fact]
        public void AddressTest_Uf_Equals2Char_ReturnTrue()
        {
            _testOutputHelper.WriteLine("Equals2Char");
            var uf = _fixture.addressFailed.Uf.Length;
            Assert.True(uf == 2);
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
