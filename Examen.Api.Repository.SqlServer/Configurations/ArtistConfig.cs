using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist")
                .HasKey(c => c.Id)
                .HasName("PK_Artist");

            builder.Property(e => e.Id)
                .HasColumnName("ArtistId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(120);         
        }
    }
}
