namespace LoremIpsumLogistica.Api.Domain.Arguments.Hateoas
{
    public abstract class Recurso
    {
        public List<LinkDTO> Links { get; set; } = new List<LinkDTO>();
    }
}
