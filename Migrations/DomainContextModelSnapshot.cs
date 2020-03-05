﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SharentAPI.Data;

namespace SharentAPI.Migrations
{
    [DbContext(typeof(DomainContext))]
    partial class DomainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SharentAPI.Domain.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SharentAPI.Domain.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("SharentAPI.Domain.Offer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Canceled");

                    b.Property<int>("CellTax");

                    b.Property<DateTime>("DateTimeBegin");

                    b.Property<int>("DateTimeCellCount");

                    b.Property<int>("DateTimeCellSize");

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid?>("RealtyId");

                    b.Property<bool>("ReserveApproveEnabled");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RealtyId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("SharentAPI.Domain.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("SharentAPI.Domain.Realty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<Guid?>("OwnerId");

                    b.Property<string>("PageUrl");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Realties");
                });

            modelBuilder.Entity("SharentAPI.Domain.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BeginDateTimeCell");

                    b.Property<Guid?>("ClientId");

                    b.Property<int>("DateTimeCellCount");

                    b.Property<bool>("IsApproved");

                    b.Property<bool>("IsCanceled");

                    b.Property<Guid?>("OfferId");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("OfferId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("SharentAPI.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<string>("VkClientId");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SharentAPI.Domain.Admin", b =>
                {
                    b.HasOne("SharentAPI.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SharentAPI.Domain.Client", b =>
                {
                    b.HasOne("SharentAPI.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SharentAPI.Domain.Offer", b =>
                {
                    b.HasOne("SharentAPI.Domain.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("SharentAPI.Domain.Realty", "Realty")
                        .WithMany()
                        .HasForeignKey("RealtyId");
                });

            modelBuilder.Entity("SharentAPI.Domain.Owner", b =>
                {
                    b.HasOne("SharentAPI.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SharentAPI.Domain.Realty", b =>
                {
                    b.HasOne("SharentAPI.Domain.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("SharentAPI.Domain.Reservation", b =>
                {
                    b.HasOne("SharentAPI.Domain.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("SharentAPI.Domain.Offer", "Offer")
                        .WithMany()
                        .HasForeignKey("OfferId");
                });
#pragma warning restore 612, 618
        }
    }
}
