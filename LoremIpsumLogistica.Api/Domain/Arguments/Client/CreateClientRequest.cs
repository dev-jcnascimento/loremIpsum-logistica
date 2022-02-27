using LoremIpsumLogistica.Api.Domain.Enums;

namespace LoremIpsumLogistica.Api.Domain.Arguments.Client
{
    public class CreateClientRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Genre { get; set; }
    }
}
