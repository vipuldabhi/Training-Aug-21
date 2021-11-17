﻿// <auto-generated />
using System;
using Day12_13.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Day12_13.Migrations
{
    [DbContext(typeof(ToyContext))]
    partial class ToyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Day12_13.Models.CustomerDetails", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderDetailsOrderID")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.HasIndex("OrderDetailsOrderID");

                    b.ToTable("CustomerDetails");
                });

            modelBuilder.Entity("Day12_13.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Day12_13.Models.PlantsDetails", b =>
                {
                    b.Property<int>("PlantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PlantAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantID");

                    b.ToTable("PlantsDetails");
                });

            modelBuilder.Entity("Day12_13.Models.ToyCatageory", b =>
                {
                    b.Property<int>("CatageoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategeoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("PlantsDetailsPlantID")
                        .HasColumnType("int");

                    b.HasKey("CatageoryID");

                    b.HasIndex("PlantsDetailsPlantID");

                    b.ToTable("ToyCatageory");
                });

            modelBuilder.Entity("Day12_13.Models.ToysDetails", b =>
                {
                    b.Property<int>("ToyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderDetailsOrderID")
                        .HasColumnType("int");

                    b.Property<int?>("PlantsDetailsPlantID")
                        .HasColumnType("int");

                    b.Property<string>("ToyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToyPrice")
                        .HasColumnType("int");

                    b.HasKey("ToyID");

                    b.HasIndex("OrderDetailsOrderID");

                    b.HasIndex("PlantsDetailsPlantID");

                    b.ToTable("ToysDetails");
                });

            modelBuilder.Entity("Day12_13.Models.CustomerDetails", b =>
                {
                    b.HasOne("Day12_13.Models.OrderDetails", null)
                        .WithMany("Customers")
                        .HasForeignKey("OrderDetailsOrderID");
                });

            modelBuilder.Entity("Day12_13.Models.ToyCatageory", b =>
                {
                    b.HasOne("Day12_13.Models.PlantsDetails", null)
                        .WithMany("Catageories")
                        .HasForeignKey("PlantsDetailsPlantID");
                });

            modelBuilder.Entity("Day12_13.Models.ToysDetails", b =>
                {
                    b.HasOne("Day12_13.Models.OrderDetails", null)
                        .WithMany("Toys")
                        .HasForeignKey("OrderDetailsOrderID");

                    b.HasOne("Day12_13.Models.PlantsDetails", null)
                        .WithMany("Toys")
                        .HasForeignKey("PlantsDetailsPlantID");
                });
#pragma warning restore 612, 618
        }
    }
}
