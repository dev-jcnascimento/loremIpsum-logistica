using LoremIpsumLogistica.Api.Domain.Arguments.Client;

namespace LoremIpsumLogistica.Api.Domain.IServices
{
    public interface IClientService
    {
        Task<ClientResponse> Create(CreateClientRequest request);
        Task<IEnumerable<ClientResponse>> GetAll(int page, int size);
        Task<ClientResponse> GetById(Guid id);
        Task<IEnumerable<ClientResponse>> GetByName(string firstName, string lastName);
        Task<ClientResponse> Update(UpdateClientRequest request);
        Task DeleteByI(Guid id);
    }
}
