// <auto-generated />
using System;
using LoremIpsumLogistica.Api.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoremIpsumLogistica.Api.Migrations
{
    [DbContext(typeof(LoremIpsumLogisticaContext))]
    partial class LoremIpsumLogisticaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LoremIpsumLogistica.Api.Domain.Entities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ClientId");

                    b.Property<string>("Complement")
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Complement");

                    b.Property<string>("District")
                        .HasColumnType("varchar(80)")
                        .HasColumnName("District");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasColumnName("Number");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Place");

                    b.Property<string>("State")
                        .HasColumnType("varchar(2)")
                        .HasColumnName("State");

                    b.Property<string>("TypeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TypeAddress");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int")
                        .HasColumnName("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("LoremIpsumLogistica.Api.Domain.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("BirthDate");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Genre");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasColumnName("LastName");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("LoremIpsumLogistica.Api.Domain.Entities.Address", b =>
                {
                    b.HasOne("LoremIpsumLogistica.Api.Domain.Entities.Client", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("LoremIpsumLogistica.Api.Domain.Entities.Client", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
