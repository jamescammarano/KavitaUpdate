﻿// <auto-generated />
using System;
using KavitaUpdate.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KavitaUpdate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210701013223_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateEntity", b =>
                {
                    b.Property<int>("UpdateEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Branch")
                        .HasColumnType("TEXT");

                    b.Property<string>("FixedStr")
                        .HasColumnType("TEXT")
                        .HasColumnName("Fixed");

                    b.Property<string>("NewStr")
                        .HasColumnType("TEXT")
                        .HasColumnName("New");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UpdateEntityId");

                    b.HasIndex("Branch", "Version")
                        .IsUnique();

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateFileEntity", b =>
                {
                    b.Property<int>("UpdateEntityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OperatingSystem")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Architecture")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Runtime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Filename")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("UpdateEntityId", "OperatingSystem", "Architecture", "Runtime");

                    b.ToTable("UpdateFiles");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateFileEntity", b =>
                {
                    b.HasOne("LidarrAPI.Database.Models.UpdateEntity", "Update")
                        .WithMany("UpdateFiles")
                        .HasForeignKey("UpdateEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Update");
                });

            modelBuilder.Entity("LidarrAPI.Database.Models.UpdateEntity", b =>
                {
                    b.Navigation("UpdateFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
