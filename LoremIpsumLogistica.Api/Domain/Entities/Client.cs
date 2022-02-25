using LoremIpsumLogistica.Api.Domain.Entities.Base;
using LoremIpsumLogistica.Api.Domain.Enums;
using LoremIpsumLogistica.Api.Domain.Extensions.Validations;

namespace LoremIpsumLogistica.Api.Domain.Entities
{
    public class Client : EntityBase
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Genre Genre { get; private set; }
        public ICollection<Address> Addresses { get; private set; }
        private Client()
        {}
        public Client(string firstName, string lastName, DateTime birthDate, Genre genre)
        {
            FirstName = StringValidator.Validating("FirstName", firstName,3,60);
            LastName = StringValidator.Validating("LastName", lastName, 3, 60);
            BirthDate = birthDate;
            Genre = genre;
        }
        public void Update(string firstName, string lastName, DateTime birthDate, Genre genre)
        {
            FirstName = StringValidator.Validating("FirstName", firstName, 3, 60);
            LastName = StringValidator.Validating("LastName", lastName, 3, 60);
            BirthDate = birthDate;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

}
