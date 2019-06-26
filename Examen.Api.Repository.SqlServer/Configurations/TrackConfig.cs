using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class TrackConfig : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.ToTable("Track")
                .HasKey(c => c.Id)
                .HasName("PK_Track");

            builder.HasIndex(e => e.Id)
                .HasName("IFK_TrackId");

            builder.Property(e => e.Id)
                .HasColumnName("TrackId")
                .UseSqlServerIdentityColumn();      

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(40);

            builder.Property(e => e.AlbumId)
                .HasColumnName("AlbumId");

            builder.Property(e => e.MediaTypeId)
                .HasColumnName("MediaTypeId");

            builder.Property(e => e.GenreId)
                .HasColumnName("GenreId");

            builder.Property(e => e.Milliseconds)
                .HasColumnName("Milliseconds");

            builder.Property(e => e.Bytes)
                .HasColumnName("Bytes");

            builder.Property(e => e.Composer)
                .HasColumnName("Composer")
                .HasMaxLength(40);            

            builder.Property(e => e.UnitPrice)
                .HasColumnName("UnitPrice")
                .IsRequired();     
        }
    }
}
