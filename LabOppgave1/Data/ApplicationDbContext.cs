using LabOppgave1.Models;
using LabOppgave1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LabOppgave1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Manufacturer>().ToTable("Manufacturer");
            modelBuilder.Entity<Category>().ToTable("Category");

            // Seeding

            // Manufacturer
            modelBuilder.Entity<Manufacturer>().
                HasData(new Manufacturer
                {
                    ManufacturerId = 1,
                    Name = "Apple",
                    Description = "Apple er en stor produsent av elektronikk",
                    Address = "20863 Stevens Creek Blvd., (Building 3, Suite C) in Cupertino, California",
                });

            modelBuilder.Entity<Manufacturer>().
                HasData(new Manufacturer
                {
                    ManufacturerId = 2,
                    Name = "BMW",
                    Description = "BMW er en stor produsent av biler",
                    Address = "Petuelring 130, 80809 München, Tyskland",
                });
            modelBuilder.Entity<Manufacturer>().
                HasData(new Manufacturer
                {
                    ManufacturerId = 3,
                    Name = "Siemens",
                    Description = "Siemens er en stor produsent av hvitevarer",
                    Address = "Werner-von-Siemens-Straße 1, 80333 München, Tyskland",
                });

            // Category 
            modelBuilder.Entity<Category>()
                .HasData(new Category
                {
                    CategoryId = 1,
                    Name = "Elektronikk",
                    Description = "Elektronikk er en samlebetegnelse for alle produkter som er basert på elektriske komponenter",
                });
            modelBuilder.Entity<Category>()
                .HasData(new Category
                {
                    CategoryId = 2,
                    Name = "Kjøretøy",
                    Description = "Kjøretøy er et fremkomstmiddel som kan transportere mennesker eller gods",
                });
            modelBuilder.Entity<Category>()
                .HasData(new Category
                {
                    CategoryId = 3,
                    Name = "Hvitevarer",
                    Description = "Hvitevarer er en fellesbetegnelse på elektriske husholdningsapparater",
                });

            // Product
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 1,
                    Name = "iPhone 12",
                    Description = "iPhone 12 er en smarttelefon utviklet av Apple",
                    Price = 9999.99m,
                    CategoryId = 1,
                    ManufacturerId = 1
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 2,
                    Name = "iPhone 12 Pro",
                    Description = "iPhone 12 Pro er en smarttelefon utviklet av Apple",
                    Price = 12999.99m,
                    CategoryId = 1,
                    ManufacturerId = 1
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 3,
                    Name = "iPhone 12 Pro Max",
                    Description = "iPhone 12 Pro Max er en smarttelefon utviklet av Apple",
                    Price = 14999.99m,
                    CategoryId = 1,
                    ManufacturerId = 1
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 4,
                    Name = "iPhone 12 Mini",
                    Description = "iPhone 12 Mini er en smarttelefon utviklet av Apple",
                    Price = null,
                    CategoryId = 1,
                    ManufacturerId = 1
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 5,
                    Name = "iPhone SE",
                    Description = null,
                    Price = 4999.99m,
                    CategoryId = 1,
                    ManufacturerId = 1
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 6,
                    Name = "BMW 1-serie",
                    Description = "BMW 1-serie er en bil utviklet av BMW",
                    Price = 300000m,
                    CategoryId = 2,
                    ManufacturerId = 2
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 7,
                    Name = "BMW 2-serie",
                    Description = "BMW 2-serie er en bil utviklet av BMW",
                    Price = null,
                    CategoryId = 2,
                    ManufacturerId = 2
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 8,
                    Name = "BMW 3-serie",
                    Description = null,
                    Price = 500000m,
                    CategoryId = 2,
                    ManufacturerId = 2
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 9,
                    Name = "BMW 4-serie",
                    Description = "BMW 4-serie er en bil utviklet av BMW",
                    Price = null,
                    CategoryId = 2,
                    ManufacturerId = 2
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 10,
                    Name = "BMW 5-serie",
                    Price = 700000m,
                    Description = "BMW 5-serie er en bil utviklet av BMW",
                    CategoryId = 2,
                    ManufacturerId = 2
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 11,
                    Name = "Siemens EQ.9 plus connect",
                    Description = "Siemens EQ.9 plus connect er en kaffemaskin utviklet av Siemens",
                    Price = null,
                    CategoryId = 3,
                    ManufacturerId = 3
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 12,
                    Name = "Siemens EQ.6 plus s700",
                    Description = "Siemens EQ.6 plus s700 er en kaffemaskin utviklet av Siemens",
                    Price = 15000m,
                    CategoryId = 3,
                    ManufacturerId = 3
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 13,
                    Name = "Siemens EQ.500 integral",
                    Description = "Siemens EQ.500 integral er en kaffemaskin utviklet av Siemens",
                    Price = null,
                    CategoryId = 3,
                    ManufacturerId = 3
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 14,
                    Name = "Siemens EQ.300",
                    Description = null,
                    Price = 5000m,
                    CategoryId = 3,
                    ManufacturerId = 3
                });
            modelBuilder.Entity<Product>()
                .HasData(new Product
                {
                    ProductId = 15,
                    Name = "Siemens EQ.200",
                    Description = "Siemens EQ.200 er en kaffemaskin utviklet av Siemens",
                    Price = 3000m,
                    CategoryId = 3,
                    ManufacturerId = 3
                });
        }
    }
}
