﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231129120434_EmployeeChanges")]
    partial class EmployeeChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "John@gmail.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Hastings",
                            PhotoPath = "/Images/JohnJameson.jpg"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "Linda@gmail.com",
                            FirstName = "Linda",
                            Gender = 1,
                            LastName = "Mills",
                            PhotoPath = "/Images/JennyMarks.jpg"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "Harry@gmail.com",
                            FirstName = "Harry",
                            Gender = 0,
                            LastName = "Long",
                            PhotoPath = "/Images/MaleDefault.jpg"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 4,
                            Email = "Mary@gmail.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "Jane",
                            PhotoPath = "/Images/NoahRobinson.jpg"
                        },
                        new
                        {
                            EmployeeId = 5,
                            DateOfBirth = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "Eunice@gmail.com",
                            FirstName = "Eunice",
                            Gender = 1,
                            LastName = "Hepta",
                            PhotoPath = "/Images/OliviaMills.jpg"
                        },
                        new
                        {
                            EmployeeId = 6,
                            DateOfBirth = new DateTime(2002, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "Kelvin@gmail.com",
                            FirstName = "Kelvin",
                            Gender = 0,
                            LastName = "Pokemon",
                            PhotoPath = "/Images/Profile5_Woman.jpg"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.HasOne("EmployeeManagement.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
