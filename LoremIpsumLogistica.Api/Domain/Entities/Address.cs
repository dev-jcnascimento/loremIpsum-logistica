using LoremIpsumLogistica.Api.Domain.Enums;
using LoremIpsumLogistica.Api.Domain.Extensions.Validations;
using System.ComponentModel.DataAnnotations;

namespace LoremIpsumLogistica.Api.Domain.Entities
{
    public class Address
    {
        public Guid Id { get; private set; }
        public TypeAddress TypeAddress { get; private set; }
        public int ZipCode { get; private set; }
        public string Place { get; private set; }
        public int Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string State { get; private set; }
        private Address()
        {}
        public Address(TypeAddress typeAddress, int zipCode, string place, int number, string complement, string district, string state)
        {
            TypeAddress = typeAddress;
            ZipCode = ZipCodeValidator(zipCode);
            Place = StringValidator.Validating("Place", place, 5, 150);
            Number = NumberValidator(number);
            Complement = complement;
            District = district;
            State = StateValidator.Validating(state);
        }
        private int ZipCodeValidator(int zipCode)
        {
            if (zipCode.ToString().Length > 8 ) throw new ValidationException("Zip Code must contain 8 numbers");
            return zipCode;
        }
        private int NumberValidator(int number)
        {
            if (number <= 0) throw new ValidationException("Number must be greater than zero");
            return number;
        }
    }
}
