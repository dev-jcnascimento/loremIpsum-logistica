using LoremIpsumLogistica.Api.Domain.Entities;
using LoremIpsumLogistica.Api.Infra.Persistence.Map;
using Microsoft.EntityFrameworkCore;

namespace LoremIpsumLogistica.Api.Infra.Persistence
{
    public class LoremIpsumLogisticaContext : DbContext
    {
        public LoremIpsumLogisticaContext(DbContextOptions<LoremIpsumLogisticaContext> options)
            : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new ClientMap());
            modelbuilder.ApplyConfiguration(new AddressMap());

            base.OnModelCreating(modelbuilder);
        }
    }
}
