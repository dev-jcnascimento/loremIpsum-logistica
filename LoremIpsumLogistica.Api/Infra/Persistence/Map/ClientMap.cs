using LoremIpsumLogistica.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoremIpsumLogistica.Api.Infra.Persistence.Map
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(x => x.Id);
            builder.Property(p => p.FirstName)
                .HasColumnName("FistName")
                .IsRequired()
                .HasColumnType("varchar(60)");
            builder.Property(p => p.LastName)
               .HasColumnName("LastName")
               .IsRequired()
               .HasColumnType("varchar(60)");
            builder.Property(p => p.BirthDate)
            .HasColumnName("BirthDate")
            .IsRequired();
            builder.Property(x => x.Genre)
                .HasColumnName("Genre")
                .HasConversion<string>();
            builder.HasMany(x => x.Addresses);
        }
    }
}
