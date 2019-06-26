using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class MediaTypeConfig : IEntityTypeConfiguration<MediaType>
    {
        public void Configure(EntityTypeBuilder<MediaType> builder)
        {
            builder.ToTable("MediaType")
                .HasKey(c => c.Id)
                .HasName("PK_MediaType");

            builder.Property(e => e.Id)
                .HasColumnName("MediaTypeId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(120);
        }
    }
}
