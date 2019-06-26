using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class InvoiceConfig : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoice")
                .HasKey(c => c.Id)
                .HasName("PK_Invoice");            

            builder.HasIndex(e => e.CustomerId)
                .HasName("IFK_InvoiceCustomerId");

            builder.Property(e => e.Id)
                .HasColumnName("InvoiceId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerId")
                .IsRequired();

            builder.Property(e => e.InvoiceDate)
                .HasColumnName("InvoiceDate")
                .IsRequired();

            builder.Property(e => e.BillingAddress)
                .HasColumnName("BillingAddress")
                .HasMaxLength(40);

            builder.Property(e => e.BillingCity)
                .HasColumnName("BillingCity")
                .HasMaxLength(40);

            builder.Property(e => e.BillingCountry)
                .HasColumnName("BillingCountry")
                .HasMaxLength(40);

            builder.Property(e => e.BillingState)
                .HasColumnName("BillingState")
                .HasMaxLength(40);

            builder.Property(e => e.BillingPostalCode)
                .HasColumnName("BillingState")
                .HasMaxLength(40);

            builder.Property(e => e.Total)
                .HasColumnName("Total")
                .IsRequired();
        }
    }
}
