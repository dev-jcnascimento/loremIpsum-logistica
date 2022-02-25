namespace LoremIpsumLogistica.Api.Domain.IServices.Services
{
    public class ClientService : IClientService
    {
        public Task<ClientResponse> Create(CreateClientRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientResponse>> GetAll(int page, int size)
        {
            throw new NotImplementedException();
        }

        public Task<ClientResponse> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientResponse>> GetByName(int page, int size, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public Task<ClientResponse> Update(Guid id, UpdateClientRequest request)
        {
            throw new NotImplementedException();
        }
        public Task DeleteByI(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
