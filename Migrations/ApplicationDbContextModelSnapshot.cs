﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using To_Do_List.Data;

#nullable disable

namespace To_Do_List.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("To_Do_List.Models.Entity.TaskWrapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RecievedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tasks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DueDate = new DateTime(2023, 12, 1, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1766),
                            IsCompleted = false,
                            RecievedTime = new DateTime(2023, 11, 1, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1726),
                            task = "Do the laundry"
                        },
                        new
                        {
                            Id = 2,
                            DueDate = new DateTime(2023, 11, 8, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1772),
                            IsCompleted = false,
                            RecievedTime = new DateTime(2023, 11, 1, 23, 10, 15, 347, DateTimeKind.Local).AddTicks(1770),
                            task = "Watch all episodes of One Piece"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
