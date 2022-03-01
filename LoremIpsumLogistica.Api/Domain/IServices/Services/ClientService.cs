using LoremIpsumLogistica.Api.Domain.Arguments.Client;
using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Domain.Enums;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories;
using System.ComponentModel.DataAnnotations;

namespace LoremIpsumLogistica.Api.Domain.IServices.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ClientResponse> CreateAsync(CreateClientRequest request)
        {
            var cliente = new Client(
                  request.FirstName,
                  request.LastName,
                  request.BirthDate,
                   ValidationGenre(request.Genre)
                  );
            var result = await _clientRepository.Create(cliente);
            return (ClientResponse)result;
        }

        public async Task<IEnumerable<ClientResponse>> GetAllAsync()
        {
            var result = await _clientRepository.GetAll();

            return result.Select(x => (ClientResponse)x).ToList();
        }

        public async Task<IEnumerable<ClientResponse>> GetAllPaginationAsync(int page, int size)
        {
            var pageSize = (size < 1) ? 10 : size;
            var offset = page > 0 ? (page - 1) * pageSize : 0;

            var result = _clientRepository.GetAllPaginationAsync(pageSize, offset);

            return result.Select(x => (ClientResponse)x).ToList();
        }

        public async Task<ClientResponse> GetByIdAsync(Guid id)
        {
            var client = await ExistClientAsync(id);
            return (ClientResponse)client;
        }

        public async Task<IEnumerable<ClientResponse>> GetByNameAsync(string firstName, string lastName)
        {
            var result = _clientRepository.GetByName(firstName, lastName);
            if (result == null) return null;
            return result.Select(x => (ClientResponse)x).ToList();
        }

        public async Task<ClientResponse> UpdateAsync(UpdateClientRequest request)
        {
            var client = await ExistClientAsync(request.Id);
            client.Update(
                request.FirstName,
                request.LastName,
                request.BirthDate,
                ValidationGenre(request.Genre));

            var result = await _clientRepository.Update(client);
            return (ClientResponse)result;
        }
        public async Task DeleteByIAsync(Guid id)
        {
            var client = await ExistClientAsync(id);
            await _clientRepository.DeleteClientAndAddress(client);
        }
        public async Task<Client> ExistClientAsync(Guid id)
        {
            var client = await _clientRepository.GetById(id);

            if (client == null) throw new ValidationException("Id Client not Found!");
            return client;
        }
        private Genre ValidationGenre(string genre)
        {
            var result = Genre.Unidentified;
            if (genre.ToUpper().Equals(Genre.Male.ToString().ToUpper())) result = Genre.Male;
            if (genre.ToUpper().Equals(Genre.Female.ToString().ToUpper())) result = Genre.Female;
            return result;
        }
    }
}
