﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPTA.Models;

#nullable disable

namespace RPTA.Migrations
{
    [DbContext(typeof(RptaDbContext))]
    [Migration("20220712021651_ItemText2")]
    partial class ItemText2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RPTA.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharacterId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PronounsId")
                        .HasColumnType("int");

                    b.Property<int>("TextId")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("PronounsId");

                    b.HasIndex("TextId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("RPTA.Models.GameText", b =>
                {
                    b.Property<int>("TextId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TextId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TextId");

                    b.ToTable("GameText");
                });

            modelBuilder.Entity("RPTA.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryId"), 1L, 1);

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("ItemId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("RPTA.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"), 1L, 1);

                    b.Property<int>("Action")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<bool>("Equippable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TextId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.HasIndex("TextId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("RPTA.Models.Pronouns", b =>
                {
                    b.Property<int>("PronounsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PronounsId"), 1L, 1);

                    b.Property<string>("PossessiveNominative")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PossessiveObjective")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SingularNominative")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdObjective")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PronounsId");

                    b.ToTable("Pronouns");
                });

            modelBuilder.Entity("RPTA.Models.Character", b =>
                {
                    b.HasOne("RPTA.Models.Pronouns", "Pronouns")
                        .WithMany()
                        .HasForeignKey("PronounsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTA.Models.GameText", "Text")
                        .WithMany()
                        .HasForeignKey("TextId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pronouns");

                    b.Navigation("Text");
                });

            modelBuilder.Entity("RPTA.Models.Inventory", b =>
                {
                    b.HasOne("RPTA.Models.Character", "Character")
                        .WithMany("Items")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPTA.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("RPTA.Models.Item", b =>
                {
                    b.HasOne("RPTA.Models.GameText", "Text")
                        .WithMany()
                        .HasForeignKey("TextId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Text");
                });

            modelBuilder.Entity("RPTA.Models.Character", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}