using LoremIpsumLogistica.Api.Domain.Arguments.Client;
using LoremIpsumLogistica.Api.Domain.Entities;
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

        public async Task<ClientResponse> Create(CreateClientRequest request)
        {
            var cliente = new Client(
                request.FirstName,
                request.LastName,
                DateTime.Parse(request.BirthDate),
                request.Genre
                );
            var result = await _clientRepository.Create(cliente);
            return (ClientResponse)result;
        }

        public async Task<IEnumerable<ClientResponse>> GetAll(int page, int size)
        {
            var pageSize = (size < 1) ? 10 : size;
            var offset = page > 0 ? (page - 1) * pageSize : 0;

            string query = @"select * from client ";
            query += $" limit {size} offset {offset}";

            var result = _clientRepository.GetAll(query);

            return (IEnumerable<ClientResponse>)result;
        }

        public async Task<ClientResponse> GetById(Guid id)
        {
            var client = await ExistClient(id);
            return (ClientResponse)client;
        }

        public async Task<IEnumerable<ClientResponse>> GetByName(string firstName, string lastName)
        {
            return (IEnumerable<ClientResponse>)_clientRepository.GetByName(firstName, lastName);
        }

        public async Task<ClientResponse> Update(UpdateClientRequest request)
        {
            var client = await ExistClient(request.Id);
            client.Update(
                request.FirstName,
                request.LastName,
                DateTime.Parse(request.BirthDate),
                request.Genre);

            var result = await _clientRepository.Update(client);
            return (ClientResponse)result;
        }
        public async Task DeleteByI(Guid id)
        {
            var client = await ExistClient(id);
           await _clientRepository.DeleteClientAndAddress(client);
        }
        public async Task<Client> ExistClient(Guid id)
        {
            var client = await _clientRepository.GetById(id);
            if (client == null) throw new ValidationException("Id Client not Found!");
            return null;
        }
    }
}
