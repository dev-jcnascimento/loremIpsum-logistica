namespace LoremIpsumLogistica.Api.Domain.Arguments.Hateoas
{
    public class LinkDTO
    {
        public string Href { get; private set; }
        public string Rel { get; private set; }
        public string Metodo { get; private set; }

        public LinkDTO(string href, string rel, string metodo)
        {
            Href = href;
            Rel = rel;
            Metodo = metodo;
        }
    }
}
