﻿using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Generic;

namespace LoremIpsumLogistica.Api.Infra.Persistence.IRepositories.Repositories
{
    public class AddressRepository : BaseRepository<Address,Guid>, IAddressRepository
    {
        protected readonly LoremIpsumLogisticaContext _loremIpsumLogisticaContext;
        public AddressRepository(LoremIpsumLogisticaContext context) : base(context)
        {
            _loremIpsumLogisticaContext = context;
        }
    }
}