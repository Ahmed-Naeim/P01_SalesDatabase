﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P01_SalesDatabase.Data;

#nullable disable

namespace P01_SalesDatabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241107225158_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P01_SalesDatabase.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CreaditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("SalesSaleId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("SalesSaleId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SalesSaleId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SalesSaleId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.HasKey("SaleId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("SalesSaleId")
                        .HasColumnType("int");

                    b.HasKey("StoreId");

                    b.HasIndex("SalesSaleId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Customer", b =>
                {
                    b.HasOne("P01_SalesDatabase.Models.Sale", "Sales")
                        .WithMany("Customers")
                        .HasForeignKey("SalesSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Product", b =>
                {
                    b.HasOne("P01_SalesDatabase.Models.Sale", "Sales")
                        .WithMany("Products")
                        .HasForeignKey("SalesSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Store", b =>
                {
                    b.HasOne("P01_SalesDatabase.Models.Sale", "Sales")
                        .WithMany("Stores")
                        .HasForeignKey("SalesSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("P01_SalesDatabase.Models.Sale", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Products");

                    b.Navigation("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}
