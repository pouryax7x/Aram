﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSQL;

namespace Aram.DA.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20190305164230_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Aram.Model.Inventory", b =>
                {
                    b.Property<int>("inventoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("checkOutDateTime");

                    b.Property<int>("cost");

                    b.Property<DateTime?>("deliverDateTime");

                    b.Property<string>("discription")
                        .HasMaxLength(250);

                    b.Property<int?>("kindID");

                    b.Property<string>("name")
                        .HasMaxLength(25);

                    b.Property<DateTime?>("readyDateTime");

                    b.Property<DateTime>("registerDateTime");

                    b.Property<int?>("statusID");

                    b.Property<string>("tel")
                        .HasMaxLength(11);

                    b.Property<int?>("userID");

                    b.HasKey("inventoryID");

                    b.HasIndex("kindID");

                    b.HasIndex("statusID");

                    b.HasIndex("userID");

                    b.ToTable("inventory");
                });

            modelBuilder.Entity("Aram.Model.Kind", b =>
                {
                    b.Property<int>("kindID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .HasMaxLength(15);

                    b.HasKey("kindID");

                    b.ToTable("kind");
                });

            modelBuilder.Entity("Aram.Model.Problem", b =>
                {
                    b.Property<int>("problemID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .HasMaxLength(15);

                    b.HasKey("problemID");

                    b.ToTable("problem");
                });

            modelBuilder.Entity("Aram.Model.ProblemInventory", b =>
                {
                    b.Property<int>("problemInventoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("inventoryID");

                    b.Property<int?>("problemID");

                    b.HasKey("problemInventoryID");

                    b.HasIndex("inventoryID");

                    b.HasIndex("problemID");

                    b.ToTable("problemInventory");
                });

            modelBuilder.Entity("Aram.Model.Status", b =>
                {
                    b.Property<int>("statusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name")
                        .HasMaxLength(15);

                    b.HasKey("statusID");

                    b.ToTable("status");
                });

            modelBuilder.Entity("Aram.Model.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("password");

                    b.Property<string>("username");

                    b.HasKey("userID");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Aram.Model.Inventory", b =>
                {
                    b.HasOne("Aram.Model.Kind", "kind")
                        .WithMany()
                        .HasForeignKey("kindID");

                    b.HasOne("Aram.Model.Status", "status")
                        .WithMany()
                        .HasForeignKey("statusID");

                    b.HasOne("Aram.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("Aram.Model.ProblemInventory", b =>
                {
                    b.HasOne("Aram.Model.Inventory", "inventory")
                        .WithMany("problemInventories")
                        .HasForeignKey("inventoryID");

                    b.HasOne("Aram.Model.Problem", "problem")
                        .WithMany()
                        .HasForeignKey("problemID");
                });
#pragma warning restore 612, 618
        }
    }
}
