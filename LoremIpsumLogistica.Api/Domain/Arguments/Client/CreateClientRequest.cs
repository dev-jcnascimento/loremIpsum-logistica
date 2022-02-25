using LoremIpsumLogistica.Api.Domain.Enums;

namespace LoremIpsumLogistica.Api.Domain.Arguments.Client
{
    public class CreateClientRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public Genre Genre { get; set; }
    }
}
