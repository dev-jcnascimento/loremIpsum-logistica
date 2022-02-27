using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic;

namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Repositories
{
    public class ClientRepository : BaseRepository<Client,Guid>, IClientRepository
    {
        protected readonly LoremIpsumLogisticaContext _loremIpsumLogisticaContext;
        public ClientRepository(LoremIpsumLogisticaContext context) : base(context)
        {
            _loremIpsumLogisticaContext = context;
        }
        public List<Client> GetByName(string firstName, string lastName)
        {
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return _loremIpsumLogisticaContext.Clients.Where(
                    p => p.FirstName.Contains(firstName)
                    && p.LastName.Contains(lastName)).ToList();
            }
            else if (string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                return _loremIpsumLogisticaContext.Clients.Where(
                    p => p.LastName.Contains(lastName)).ToList();
            }
            else if (!string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
            {
                return _loremIpsumLogisticaContext.Clients.Where(
                    p => p.FirstName.Contains(firstName)).ToList();
            }
            return null;
        }
        public async Task DeleteClientAndAddress(Client client)
        {
            var addressList = _loremIpsumLogisticaContext.Addresses
                .Where(x => x.ClientId == client.Id)
                .ToList();
            _loremIpsumLogisticaContext.Addresses.RemoveRange(addressList);
            _loremIpsumLogisticaContext.Clients.Remove(client);
            await _loremIpsumLogisticaContext.SaveChangesAsync();
        }
        public List<Client> GetAllPaginationAsync(int pageSize, int offset)
        {
            return _loremIpsumLogisticaContext.Clients
                .OrderBy(x => x.FirstName)
                .Skip(offset)
                .Take(pageSize)
                .ToList();
        }

    }
}
