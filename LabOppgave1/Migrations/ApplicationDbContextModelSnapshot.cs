﻿// <auto-generated />
using System;
using LabOppgave1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabOppgave1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LabOppgave1.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Elektronikk er en samlebetegnelse for alle produkter som er basert på elektriske komponenter",
                            Name = "Elektronikk"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Kjøretøy er et fremkomstmiddel som kan transportere mennesker eller gods",
                            Name = "Kjøretøy"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Hvitevarer er en fellesbetegnelse på elektriske husholdningsapparater",
                            Name = "Hvitevarer"
                        });
                });

            modelBuilder.Entity("LabOppgave1.Models.Entities.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturer", (string)null);

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            Address = "20863 Stevens Creek Blvd., (Building 3, Suite C) in Cupertino, California",
                            Description = "Apple er en stor produsent av elektronikk",
                            Name = "Apple"
                        },
                        new
                        {
                            ManufacturerId = 2,
                            Address = "Petuelring 130, 80809 München, Tyskland",
                            Description = "BMW er en stor produsent av biler",
                            Name = "BMW"
                        },
                        new
                        {
                            ManufacturerId = 3,
                            Address = "Werner-von-Siemens-Straße 1, 80333 München, Tyskland",
                            Description = "Siemens er en stor produsent av hvitevarer",
                            Name = "Siemens"
                        });
                });

            modelBuilder.Entity("LabOppgave1.Models.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "iPhone 12 er en smarttelefon utviklet av Apple",
                            ManufacturerId = 1,
                            Name = "iPhone 12",
                            Price = 9999.99m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "iPhone 12 Pro er en smarttelefon utviklet av Apple",
                            ManufacturerId = 1,
                            Name = "iPhone 12 Pro",
                            Price = 12999.99m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "iPhone 12 Pro Max er en smarttelefon utviklet av Apple",
                            ManufacturerId = 1,
                            Name = "iPhone 12 Pro Max",
                            Price = 14999.99m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "iPhone 12 Mini er en smarttelefon utviklet av Apple",
                            ManufacturerId = 1,
                            Name = "iPhone 12 Mini"
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            ManufacturerId = 1,
                            Name = "iPhone SE",
                            Price = 4999.99m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Description = "BMW 1-serie er en bil utviklet av BMW",
                            ManufacturerId = 2,
                            Name = "BMW 1-serie",
                            Price = 300000m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2,
                            Description = "BMW 2-serie er en bil utviklet av BMW",
                            ManufacturerId = 2,
                            Name = "BMW 2-serie"
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2,
                            ManufacturerId = 2,
                            Name = "BMW 3-serie",
                            Price = 500000m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2,
                            Description = "BMW 4-serie er en bil utviklet av BMW",
                            ManufacturerId = 2,
                            Name = "BMW 4-serie"
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 2,
                            Description = "BMW 5-serie er en bil utviklet av BMW",
                            ManufacturerId = 2,
                            Name = "BMW 5-serie",
                            Price = 700000m
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 3,
                            Description = "Siemens EQ.9 plus connect er en kaffemaskin utviklet av Siemens",
                            ManufacturerId = 3,
                            Name = "Siemens EQ.9 plus connect"
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 3,
                            Description = "Siemens EQ.6 plus s700 er en kaffemaskin utviklet av Siemens",
                            ManufacturerId = 3,
                            Name = "Siemens EQ.6 plus s700",
                            Price = 15000m
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 3,
                            Description = "Siemens EQ.500 integral er en kaffemaskin utviklet av Siemens",
                            ManufacturerId = 3,
                            Name = "Siemens EQ.500 integral"
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 3,
                            ManufacturerId = 3,
                            Name = "Siemens EQ.300",
                            Price = 5000m
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 3,
                            Description = "Siemens EQ.200 er en kaffemaskin utviklet av Siemens",
                            ManufacturerId = 3,
                            Name = "Siemens EQ.200",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("LabOppgave1.Models.Entities.Product", b =>
                {
                    b.HasOne("LabOppgave1.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabOppgave1.Models.Entities.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("LabOppgave1.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("LabOppgave1.Models.Entities.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
