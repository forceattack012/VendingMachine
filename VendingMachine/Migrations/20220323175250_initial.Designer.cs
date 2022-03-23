﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VendingMachine.Data;

#nullable disable

namespace VendingMachine.Migrations
{
    [DbContext(typeof(VendingMachineContext))]
    [Migration("20220323175250_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VendingMachine.Entities.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Address = "กรุงเทพ"
                        },
                        new
                        {
                            Id = "2",
                            Address = "ปทุมธานี"
                        },
                        new
                        {
                            Id = "3",
                            Address = "พระรามสาม"
                        });
                });

            modelBuilder.Entity("VendingMachine.Entities.Machine", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("LocationId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Machines");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            LocationId = "1",
                            Name = "M1"
                        },
                        new
                        {
                            Id = "2",
                            LocationId = "1",
                            Name = "M2"
                        },
                        new
                        {
                            Id = "3",
                            LocationId = "2",
                            Name = "C1"
                        },
                        new
                        {
                            Id = "4",
                            LocationId = "3",
                            Name = "C2"
                        },
                        new
                        {
                            Id = "5",
                            LocationId = "3",
                            Name = "C2"
                        });
                });

            modelBuilder.Entity("VendingMachine.Entities.MachineInventory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("MachineId")
                        .HasColumnType("text");

                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<int>("Quality")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.HasIndex("ProductId");

                    b.ToTable("MachineInventory");

                    b.HasData(
                        new
                        {
                            Id = "db443e71-f762-4f04-9d76-6e05589a4488",
                            MachineId = "1",
                            ProductId = "P1",
                            Quality = 12
                        },
                        new
                        {
                            Id = "72139610-0781-4689-8c95-84f7fd4929e3",
                            MachineId = "1",
                            ProductId = "P2",
                            Quality = 10
                        },
                        new
                        {
                            Id = "ee1870b3-fbf1-4398-a430-f6a51cc66108",
                            MachineId = "1",
                            ProductId = "C1",
                            Quality = 20
                        },
                        new
                        {
                            Id = "b0dfa2a7-de19-4d22-a523-d77d159c567d",
                            MachineId = "1",
                            ProductId = "C2",
                            Quality = 14
                        },
                        new
                        {
                            Id = "9eeeee19-d8f5-4450-9496-fe0545e7ec9d",
                            MachineId = "2",
                            ProductId = "C2",
                            Quality = 11
                        },
                        new
                        {
                            Id = "6bdee265-513f-4b34-8bac-f9c5b0bb5ab0",
                            MachineId = "3",
                            ProductId = "C1",
                            Quality = 11
                        },
                        new
                        {
                            Id = "6f052dc7-e591-4e92-bed5-699df3609389",
                            MachineId = "3",
                            ProductId = "P1",
                            Quality = 10
                        },
                        new
                        {
                            Id = "46ce688f-4fd1-4b13-8d63-77ec80f8b133",
                            MachineId = "4",
                            ProductId = "P1",
                            Quality = 12
                        });
                });

            modelBuilder.Entity("VendingMachine.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "P1",
                            Name = "Coke",
                            Price = 20.0
                        },
                        new
                        {
                            Id = "P2",
                            Name = "Pepsi",
                            Price = 10.0
                        },
                        new
                        {
                            Id = "C1",
                            Name = "Coffee",
                            Price = 60.0
                        },
                        new
                        {
                            Id = "C2",
                            Name = "Coke",
                            Price = 0.0
                        });
                });

            modelBuilder.Entity("VendingMachine.Entities.Machine", b =>
                {
                    b.HasOne("VendingMachine.Entities.Location", "Location")
                        .WithMany("Machines")
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("VendingMachine.Entities.MachineInventory", b =>
                {
                    b.HasOne("VendingMachine.Entities.Machine", "Machine")
                        .WithMany("MachineInventories")
                        .HasForeignKey("MachineId");

                    b.HasOne("VendingMachine.Entities.Product", "Product")
                        .WithMany("MachineInventories")
                        .HasForeignKey("ProductId");

                    b.Navigation("Machine");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("VendingMachine.Entities.Location", b =>
                {
                    b.Navigation("Machines");
                });

            modelBuilder.Entity("VendingMachine.Entities.Machine", b =>
                {
                    b.Navigation("MachineInventories");
                });

            modelBuilder.Entity("VendingMachine.Entities.Product", b =>
                {
                    b.Navigation("MachineInventories");
                });
#pragma warning restore 612, 618
        }
    }
}