﻿// <auto-generated />
using System;
using JournalCar.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JournalCar.API.Migrations
{
    [DbContext(typeof(JournalCarDbContext))]
    [Migration("20230807224239_Create db")]
    partial class Createdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JournalCar.API.Model.Domain.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryActivityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryActivityId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("StatusId");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.CategoryActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoryActivity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("610ad829-6b4a-4927-91a9-c52f70ac6db0"),
                            Description = "Actions that involve keep your vehicles 'healthy'.",
                            Name = "Maintenance"
                        },
                        new
                        {
                            Id = new Guid("da56996d-a238-4b2a-a015-a46b0fd70bdc"),
                            Description = "Mandatory activities from your goverment laws.",
                            Name = "Legal"
                        });
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isMainOwner")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Status", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9fb41a8c-8304-42f4-953f-ce442f211064"),
                            Name = "Complete"
                        },
                        new
                        {
                            Id = new Guid("a6c133b0-86de-4ca5-9878-4ed7ad0b00f1"),
                            Name = "Pending"
                        });
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.TypeDoc", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeDoc");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b2e4078-261a-458e-84de-d23e08a67354"),
                            Code = "CC",
                            Name = "Cédula de ciudadania"
                        },
                        new
                        {
                            Id = new Guid("00483259-ae07-48fe-b3f1-9497f64189a6"),
                            Code = "CE",
                            Name = "Cedula de extranjeria"
                        });
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.TypeVehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IconUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeVehicle");

                    b.HasData(
                        new
                        {
                            Id = new Guid("804d8b9e-3911-4cae-abeb-aff3418ab20d"),
                            Name = "Moto"
                        },
                        new
                        {
                            Id = new Guid("9e6dfad4-a366-4a18-8bd3-af66cf09e4d0"),
                            Name = "Carro"
                        });
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeDocId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TypeDocId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Model")
                        .HasColumnType("int");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TypeVehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TypeVehicleId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Activity", b =>
                {
                    b.HasOne("JournalCar.API.Model.Domain.CategoryActivity", "CategoryActivity")
                        .WithMany()
                        .HasForeignKey("CategoryActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JournalCar.API.Model.Domain.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JournalCar.API.Model.Domain.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryActivity");

                    b.Navigation("Owner");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Owner", b =>
                {
                    b.HasOne("JournalCar.API.Model.Domain.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JournalCar.API.Model.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Users", b =>
                {
                    b.HasOne("JournalCar.API.Model.Domain.TypeDoc", "TypeDoc")
                        .WithMany()
                        .HasForeignKey("TypeDocId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeDoc");
                });

            modelBuilder.Entity("JournalCar.API.Model.Domain.Vehicle", b =>
                {
                    b.HasOne("JournalCar.API.Model.Domain.TypeVehicle", "TypeVehicle")
                        .WithMany()
                        .HasForeignKey("TypeVehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeVehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
