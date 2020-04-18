﻿// <auto-generated />
using System;
using MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200418120816_InitialDatabase")]
    partial class InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MVC.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ClassId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("MVC.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MVC.Models.Student", b =>
                {
                    b.HasOne("MVC.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
