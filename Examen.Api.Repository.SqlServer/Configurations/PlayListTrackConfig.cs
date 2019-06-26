using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class PlayListTrackConfig : IEntityTypeConfiguration<PlaylistTrack>
    {
        public void Configure(EntityTypeBuilder<PlaylistTrack> builder)
        {
            builder.ToTable("PlaylistTrack")
                .HasKey(c => new { c.PlaylistId, c.TrackId })
                .HasName("PK_PlaylistTrack");

            builder.Property(e => e.PlaylistId)
                .HasColumnName("PlaylistId")
                .IsRequired();

            builder.Property(e => e.TrackId)
                .HasColumnName("TrackId")
                .IsRequired();
        }
    }
}
