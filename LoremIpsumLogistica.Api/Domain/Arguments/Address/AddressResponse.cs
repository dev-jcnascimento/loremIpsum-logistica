using LoremIpsumLogistica.Api.Domain.Arguments.Hateoas;

namespace LoremIpsumLogistica.Api.Domain.Arguments.Address
{
    public class AddressResponse : Recurso
    {
        public string Id { get; set; }
        public string TypeAddress { get;  set; }
        public int ZipCode { get;  set; }
        public string Place { get;  set; }
        public int Number { get;  set; }
        public string Complement { get;  set; }
        public string District { get;  set; }
        public string State { get;  set; }
        public string ClientId { get; set; }
    }
}
