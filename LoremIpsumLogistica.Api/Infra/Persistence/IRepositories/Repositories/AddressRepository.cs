using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic;

namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Repositories
{
    public class AddressRepository : BaseRepository<Address, Guid>, IAddressRepository
    {
        protected readonly LoremIpsumLogisticaContext _loremIpsumLogisticaContext;
        public AddressRepository(LoremIpsumLogisticaContext context) : base(context)
        {
            _loremIpsumLogisticaContext = context;
        }
        public async Task<List<Address>> GetByClientId(Guid id)
        {
            var addressList = _loremIpsumLogisticaContext.Addresses
                .Where(a => a.ClientId.Equals(id))
                .ToList();
            return addressList;
        }
        public List<Address> GetAllAddress(int pageSize, int offset)
        {
            return _loremIpsumLogisticaContext.Addresses
                .OrderBy(x => x.ClientId)
                .Skip(offset)
                .Take(pageSize)
                .ToList();
        }
    }
}
