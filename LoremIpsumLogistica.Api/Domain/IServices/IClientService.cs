using LoremIpsumLogistica.Api.Domain.Arguments.Client;

namespace LoremIpsumLogistica.Api.Domain.IServices
{
    public interface IClientService
    {
        Task<ClientResponse> CreateAsync(CreateClientRequest request);
        Task<IEnumerable<ClientResponse>> GetAllAsync();
        Task<IEnumerable<ClientResponse>> GetAllPaginationAsync(int page, int size);
        Task<ClientResponse> GetByIdAsync(Guid id);
        Task<IEnumerable<ClientResponse>> GetByNameAsync(string firstName, string lastName);
        Task<ClientResponse> UpdateAsync(UpdateClientRequest request);
        Task DeleteByIAsync(Guid id);
    }
}
