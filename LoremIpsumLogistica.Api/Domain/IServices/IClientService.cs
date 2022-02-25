namespace LoremIpsumLogistica.Api.Domain.IServices
{
    public interface IClientService
    {
        Task<ClientResponse> Create(CreateClientRequest request);
        Task<IEnumerable<ClientResponse>> GetAll(int page, int size);
        Task<ClientResponse> GetById(Guid id);
        Task<IEnumerable<ClientResponse>> GetByName(int page, int size,string firstName, string lastName);
        Task<ClientResponse> Update(Guid id, UpdateClientRequest request);
        Task DeleteByI(Guid id);
    }
}
