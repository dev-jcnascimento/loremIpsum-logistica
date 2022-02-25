using LoremIpsumLogistica.Api.Domain.Arguments.Hateoas;

namespace LoremIpsumLogistica.Api.Domain.Arguments.Client
{
    public class ClientResponse : Recurso
    {
        public string Id { get; set; }
        public string FullName { get;  set; }
        public string BirthDate { get;  set; }
        public string Genre { get;  set; }

        public static explicit operator ClientResponse(Entities.Client entity)
        {
            return new ClientResponse()
            {
                Id = entity.Id.ToString(),
                FullName = entity.ToString(),
                BirthDate = entity.BirthDate.ToString(),
                Genre = entity.Genre.ToString(),
            };
        }
    }
}
