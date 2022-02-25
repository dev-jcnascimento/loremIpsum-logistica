using LoremIpsumLogistica.Api.Domain.Enums;

namespace LoremIpsumLogistica.Api.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Genre Genre { get; private set; }
        private Client()
        {}

        public Client(string firstName, string lastName, DateTime birthDate, Genre genre)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Genre = genre;
        }
    }

}
