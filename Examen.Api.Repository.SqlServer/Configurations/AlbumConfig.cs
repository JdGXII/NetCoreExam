using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class AlbumConfig : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album")
                .HasKey(c => c.Id)
                .HasName("PK_Album");


            builder.HasIndex(e => e.ArtistId)
                .HasName("IFK_ArtistId");

            builder.Property(e => e.Id)
                .HasColumnName("AlbumId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.Title)
                .HasColumnName("Title")
                .HasMaxLength(160)
                .IsRequired();

            builder.Property(e => e.ArtistId)
                .HasColumnName("ArtistId")
                .IsRequired();
        }
    }
}
