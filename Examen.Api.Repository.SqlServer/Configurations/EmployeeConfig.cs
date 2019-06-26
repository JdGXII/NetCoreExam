using Exman.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Api.Repository.SqlServer.Configurations
{
    class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee")
                .HasKey(c => c.Id)
                .HasName("PK_Employee");


            builder.HasIndex(e => e.ReportsTo)
                .HasName("IFK_EmployeeReportsTo");

            builder.Property(e => e.Id)
                .HasColumnName("EmployeeId")
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

            builder.Property(e => e.Title)
                .HasColumnName("Title")
                .HasMaxLength(80);

            builder.Property(e => e.ReportsTo)
                .HasColumnName("ReportsTo");

            builder.Property(e => e.BirthDate)
                .HasColumnName("BirthDate");

            builder.Property(e => e.HireDate)
                .HasColumnName("HireDate");

            builder.Property(e => e.Address)
                .HasColumnName("Address")
                .HasMaxLength(40);
        }
    }
}
