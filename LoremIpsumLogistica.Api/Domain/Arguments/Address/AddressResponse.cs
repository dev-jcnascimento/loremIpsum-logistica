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

        public static explicit operator AddressResponse(Entities.Address entity)
        {
            return new AddressResponse()
            {
                Id = entity.Id.ToString(),
                TypeAddress = entity.TypeAddress.ToString(),
                ZipCode = entity.ZipCode,
                Place = entity.Place,
                Number = entity.Number,
                Complement = entity.Complement,
                District = entity.District,
                State = entity.State,
                ClientId = entity.ClientId.ToString()
            };
        }
    }
}
