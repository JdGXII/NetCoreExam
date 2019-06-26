using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre")
                .HasKey(c => c.Id)
                .HasName("PK_Genre");

            builder.Property(e => e.Id)
                .HasColumnName("GenreId")
                .UseSqlServerIdentityColumn();

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(120);
        }
    }
}
