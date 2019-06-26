﻿// <auto-generated />
using System;
using Examen.Api.Repository.SqlServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamenNetCoreApi.Migrations
{
    [DbContext(typeof(ExamenDbContext))]
    partial class ExamenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exman.Api.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AlbumId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnName("ArtistId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasMaxLength(160);

                    b.HasKey("Id")
                        .HasName("PK_Album");

                    b.HasIndex("ArtistId")
                        .HasName("IFK_ArtistId");

                    b.ToTable("Album");
                });

            modelBuilder.Entity("Exman.Api.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ArtistId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(120);

                    b.HasKey("Id")
                        .HasName("PK_Artist");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("Exman.Api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasMaxLength(40);

                    b.Property<string>("City")
                        .HasColumnName("City")
                        .HasMaxLength(40);

                    b.Property<string>("Company")
                        .HasColumnName("Company")
                        .HasMaxLength(80);

                    b.Property<string>("Country")
                        .HasColumnName("Country")
                        .HasMaxLength(40);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasMaxLength(60);

                    b.Property<int?>("EmployeeId");

                    b.Property<string>("Fax")
                        .HasColumnName("Fax")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasColumnName("Phone")
                        .HasMaxLength(20);

                    b.Property<string>("PostalCode")
                        .HasColumnName("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .HasColumnName("State")
                        .HasMaxLength(40);

                    b.Property<int>("SupportRepId")
                        .HasColumnName("SupportRepId");

                    b.HasKey("Id")
                        .HasName("PK_Customer");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SupportRepId")
                        .HasName("IFK_CustomerSupportRepId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Exman.Api.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasMaxLength(40);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnName("BirthDate");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<int?>("EmployeeId")
                        .HasColumnName("EmployeeId1");

                    b.Property<string>("Fax");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasMaxLength(40);

                    b.Property<DateTime>("HireDate")
                        .HasColumnName("HireDate");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasMaxLength(40);

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<int>("ReportsTo")
                        .HasColumnName("ReportsTo");

                    b.Property<string>("State");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasMaxLength(80);

                    b.HasKey("Id")
                        .HasName("PK_Employee");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReportsTo")
                        .HasName("IFK_EmployeeReportsTo");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Exman.Api.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GenreId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(120);

                    b.HasKey("Id")
                        .HasName("PK_Genre");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Exman.Api.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InvoiceId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BillingAddress")
                        .HasColumnName("BillingAddress")
                        .HasMaxLength(40);

                    b.Property<string>("BillingCity")
                        .HasColumnName("BillingCity")
                        .HasMaxLength(40);

                    b.Property<string>("BillingCountry")
                        .HasColumnName("BillingCountry")
                        .HasMaxLength(40);

                    b.Property<string>("BillingPostalCode")
                        .HasColumnName("BillingState")
                        .HasMaxLength(40);

                    b.Property<string>("BillingState")
                        .HasColumnName("BillingState")
                        .HasMaxLength(40);

                    b.Property<int>("CustomerId")
                        .HasColumnName("CustomerId");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnName("InvoiceDate");

                    b.Property<float>("Total")
                        .HasColumnName("Total");

                    b.HasKey("Id")
                        .HasName("PK_Invoice");

                    b.HasIndex("CustomerId")
                        .HasName("IFK_InvoiceCustomerId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Exman.Api.Models.InvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("InvoiceItemId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId")
                        .HasColumnName("InvoiceId");

                    b.Property<int>("Quantity")
                        .HasColumnName("Quantity");

                    b.Property<int>("TrackId")
                        .HasColumnName("TrackId");

                    b.Property<float>("UnitPrice")
                        .HasColumnName("UnitPrice");

                    b.HasKey("Id")
                        .HasName("PK_InvoiceItem");

                    b.HasIndex("InvoiceId")
                        .HasName("IFK_InvoiceId");

                    b.HasIndex("TrackId");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("Exman.Api.Models.MediaType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MediaTypeId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(120);

                    b.HasKey("Id")
                        .HasName("PK_MediaType");

                    b.ToTable("MediaType");
                });

            modelBuilder.Entity("Exman.Api.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PlaylistId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(120);

                    b.HasKey("Id")
                        .HasName("PK_Playlist");

                    b.ToTable("Playlist");
                });

            modelBuilder.Entity("Exman.Api.Models.PlaylistTrack", b =>
                {
                    b.Property<int>("PlaylistId")
                        .HasColumnName("PlaylistId");

                    b.Property<int>("TrackId")
                        .HasColumnName("TrackId");

                    b.HasKey("PlaylistId", "TrackId")
                        .HasName("PK_PlaylistTrack");

                    b.HasIndex("TrackId");

                    b.ToTable("PlaylistTrack");
                });

            modelBuilder.Entity("Exman.Api.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TrackId")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnName("AlbumId");

                    b.Property<int>("Bytes")
                        .HasColumnName("Bytes");

                    b.Property<string>("Composer")
                        .HasColumnName("Composer")
                        .HasMaxLength(40);

                    b.Property<int>("GenreId")
                        .HasColumnName("GenreId");

                    b.Property<int>("MediaTypeId")
                        .HasColumnName("MediaTypeId");

                    b.Property<int>("Milliseconds")
                        .HasColumnName("Milliseconds");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasMaxLength(40);

                    b.Property<float>("UnitPrice")
                        .HasColumnName("UnitPrice");

                    b.HasKey("Id")
                        .HasName("PK_Track");

                    b.HasIndex("AlbumId");

                    b.HasIndex("GenreId");

                    b.HasIndex("Id")
                        .HasName("IFK_TrackId");

                    b.HasIndex("MediaTypeId");

                    b.ToTable("Track");
                });

            modelBuilder.Entity("Exman.Api.Models.Album", b =>
                {
                    b.HasOne("Exman.Api.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exman.Api.Models.Customer", b =>
                {
                    b.HasOne("Exman.Api.Models.Employee", "Employee")
                        .WithMany("Customers")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Exman.Api.Models.Employee", b =>
                {
                    b.HasOne("Exman.Api.Models.Employee", null)
                        .WithMany("EmployeesRelated")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("Exman.Api.Models.Invoice", b =>
                {
                    b.HasOne("Exman.Api.Models.Customer", null)
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exman.Api.Models.InvoiceItem", b =>
                {
                    b.HasOne("Exman.Api.Models.Invoice", "Invoice")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exman.Api.Models.Track", "Track")
                        .WithMany("InvoiceItems")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exman.Api.Models.PlaylistTrack", b =>
                {
                    b.HasOne("Exman.Api.Models.Playlist", "Playlist")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exman.Api.Models.Track", "Track")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Exman.Api.Models.Track", b =>
                {
                    b.HasOne("Exman.Api.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exman.Api.Models.Genre", "Genre")
                        .WithMany("Tracks")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exman.Api.Models.MediaType", "MediaType")
                        .WithMany("Tracks")
                        .HasForeignKey("MediaTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}