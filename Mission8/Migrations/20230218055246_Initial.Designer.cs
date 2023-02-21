﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission8.Models;

namespace Mission8.Migrations
{
    [DbContext(typeof(TaskContext))]
    [Migration("20230218055246_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission8.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission8.Models.TaskFormResponse", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryID")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryNameCategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryNameCategoryID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = "2",
                            Completed = false,
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 1,
                            TaskName = "Study for 404 midterm"
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = "2",
                            Completed = false,
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 2,
                            TaskName = "Mission 8 Assignment"
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = "1",
                            Completed = false,
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 3,
                            TaskName = "Call Mom"
                        },
                        new
                        {
                            TaskID = 4,
                            CategoryID = "1",
                            Completed = false,
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 4,
                            TaskName = "Therapy"
                        });
                });

            modelBuilder.Entity("Mission8.Models.TaskFormResponse", b =>
                {
                    b.HasOne("Mission8.Models.Category", "CategoryName")
                        .WithMany()
                        .HasForeignKey("CategoryNameCategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
