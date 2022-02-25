using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic;

namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories
{
    public interface IClientRepository : IBaseRepository<Client,Guid>
    {
        List<Client> GetByName(string firstName, string lastName);
        List<Client> GetAllClient(int pageSize, int offset);
        Task DeleteClientAndAddress(Client client);
    }
}
