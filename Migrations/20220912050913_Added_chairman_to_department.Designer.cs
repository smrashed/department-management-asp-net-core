﻿// <auto-generated />
using System;
using DepartmentManagement.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepartmentManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220912050913_Added_chairman_to_department")]
    partial class Added_chairman_to_department
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Course", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ChairmanId2")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChairmanId2");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Student", b =>
                {
                    b.HasBaseType("DepartmentManagement.Models.Entity.Person");

                    b.Property<decimal?>("CGPA")
                        .HasColumnType("decimal(3,2)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Semister")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Session")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("DepartmentId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Teacher", b =>
                {
                    b.HasBaseType("DepartmentManagement.Models.Entity.Person");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("Teacher_DepartmentId");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoiningDate")
                        .HasColumnType("datetime2");

                    b.HasIndex("DepartmentId");

                    b.HasDiscriminator().HasValue("Teacher");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Chairman", b =>
                {
                    b.HasBaseType("DepartmentManagement.Models.Entity.Teacher");

                    b.Property<string>("TermEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Chairman");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Course", b =>
                {
                    b.HasOne("DepartmentManagement.Models.Entity.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("DepartmentManagement.Models.Entity.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Department");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Department", b =>
                {
                    b.HasOne("DepartmentManagement.Models.Entity.Chairman", "Chairman")
                        .WithMany()
                        .HasForeignKey("ChairmanId2");

                    b.Navigation("Chairman");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Student", b =>
                {
                    b.HasOne("DepartmentManagement.Models.Entity.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Teacher", b =>
                {
                    b.HasOne("DepartmentManagement.Models.Entity.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("DepartmentManagement.Models.Entity.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
