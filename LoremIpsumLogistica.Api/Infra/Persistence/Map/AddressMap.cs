using LoremIpsumLogistica.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LoremIpsumLogistica.Api.Infra.Persistence.Map
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TypeAddress)
                .HasColumnName("TypeAddress")
                .HasConversion<string>();
            builder.Property(x => x.ZipCode)
                .HasColumnName("ZipCode");
            builder.Property(p => p.Place)
                .HasColumnName("Place")
                .IsRequired()
                .HasColumnType("varchar(150)");
            builder.Property(p => p.Number)
               .HasColumnName("Number")
               .IsRequired();
            builder.Property(p => p.Complement)
            .HasColumnName("Complement")
            .HasColumnType("varchar(150)");
            builder.Property(p => p.District)
            .HasColumnName("District")
            .HasColumnType("varchar(80)");
            builder.Property(p => p.State)
            .HasColumnName("State")
            .HasColumnType("varchar(2)");
            builder.Property(p => p.ClientId)
                .HasColumnName("ClientId")
                .IsRequired();

        }
    }
}
