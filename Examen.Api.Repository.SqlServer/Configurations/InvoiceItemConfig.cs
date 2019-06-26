using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class InvoiceItemConfig : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.ToTable("InvoiceItem")
                .HasKey(c => c.Id)
                .HasName("PK_InvoiceItem");

            builder.HasIndex(e => e.InvoiceId)
                .HasName("IFK_InvoiceId");

            builder.Property(e => e.Id)
                .HasColumnName("InvoiceItemId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.InvoiceId)
                .HasColumnName("InvoiceId")
                .IsRequired();

            builder.Property(e => e.TrackId)
                .HasColumnName("TrackId")
                .IsRequired();

            builder.Property(e => e.UnitPrice)
                .HasColumnName("UnitPrice")
                .IsRequired();

            builder.Property(e => e.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();
        }
    }
}
