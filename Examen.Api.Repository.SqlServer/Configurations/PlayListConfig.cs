using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class PlayListConfig : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.ToTable("Playlist")
                .HasKey(c => c.Id)
                .HasName("PK_Playlist");

            builder.Property(e => e.Id)
                .HasColumnName("PlaylistId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(120);
        }
    }
}
