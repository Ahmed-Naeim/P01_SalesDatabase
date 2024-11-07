using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.Data
{

    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.;DataBase=P01_SalesDatabase; Integrated Security = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<Customer>()
                .Property(p => p.Name)
                .HasColumnType("NVARCHAR(50)");
            modelBuilder.Entity<Customer>()
                .Property(p => p.Email)
                .HasColumnType("VARCHAR(50)");
            modelBuilder.Entity<Store>()
                .Property(p => p.Name)
                .HasColumnType("NVARCHAR(50)");
            
            modelBuilder.Entity<Product>()
                .Property<string>("Description");

            modelBuilder.Entity<Sale>()
                .Property<DateOnly>("Date");
        }
    }
}
