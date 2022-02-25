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
    }
}
