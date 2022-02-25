using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic;

namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories
{
    public interface IAddressRepository : IBaseRepository<Address,Guid>
    {
    }
}
