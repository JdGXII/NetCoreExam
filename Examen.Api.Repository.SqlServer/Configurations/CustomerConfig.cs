using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer")
                .HasKey(c => c.Id)
                .HasName("PK_Customer");


            builder.HasIndex(e => e.SupportRepId)
                .HasName("IFK_CustomerSupportRepId");

            builder.Property(e => e.Id)
                .HasColumnName("CustomerId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasColumnName("FirstName")
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasColumnName("LastName")
                .HasMaxLength(40)
                .IsRequired(); 

            builder.Property(e => e.Company)
                .HasColumnName("Company")
                .HasMaxLength(80);

            builder.Property(e => e.Address)
                .HasColumnName("Address")
                .HasMaxLength(40);

            builder.Property(e => e.City)
                .HasColumnName("City")
                .HasMaxLength(40);

            builder.Property(e => e.State)
                .HasColumnName("State")
                .HasMaxLength(40);

            builder.Property(e => e.Country)
                .HasColumnName("Country")
                .HasMaxLength(40);

            builder.Property(e => e.PostalCode)
                .HasColumnName("PostalCode")
                .HasMaxLength(10);

            builder.Property(e => e.Fax)
                .HasColumnName("Fax")
                .HasMaxLength(10); 

            builder.Property(e => e.Phone)
                .HasColumnName("Phone")
                .HasMaxLength(20);

            builder.Property(e => e.Email)
                .HasColumnName("Email")
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(e => e.SupportRepId)
                .HasColumnName("SupportRepId");
        }
    }
}
