using LoremIpsumLogistica.Api.Domain.Arguments.Hateoas;

namespace LoremIpsumLogistica.Api.Domain.Arguments.Client
{
    public class ClientResponse : Recurso
    {
        public string Id { get; set; }
        public string FullName { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get;  set; }
        public string BirthDateString { get;  set; }
        public string Genre { get;  set; }

        public static explicit operator ClientResponse(Entities.Client entity)
        {
            return new ClientResponse()
            {
                Id = entity.Id.ToString(),
                FullName = entity.ToString(),
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                BirthDate = entity.BirthDate,
                BirthDateString = entity.BirthDate.ToString("dd/MM/yyyy"),
                Genre = entity.Genre.ToString(),
            };
        }
    }
}
