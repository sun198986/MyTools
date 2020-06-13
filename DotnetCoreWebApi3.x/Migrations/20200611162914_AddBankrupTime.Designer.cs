﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Routine.Api.Data;

namespace Routine.Api.Migrations
{
    [DbContext(typeof(RoutineDbContext))]
    [Migration("20200611162914_AddBankrupTime")]
    partial class AddBankrupTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("Routine.Api.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BankruptTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Industry")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Product")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d8c6be7-e984-4ade-8997-8a1e67ea0c22"),
                            Country = "USA",
                            Industry = "Software",
                            Introduction = "Great Company",
                            Name = "Microsoft",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("6fa484b4-26aa-405a-a1f6-7f82092f66b6"),
                            Country = "USA",
                            Industry = "Internet",
                            Introduction = "Don't be evil",
                            Name = "Google",
                            Product = "Software"
                        },
                        new
                        {
                            Id = new Guid("658d4ed3-1505-4d02-b9ed-942e2a918e38"),
                            Country = "China",
                            Industry = "Internet",
                            Introduction = "Zz Company",
                            Name = "Ali papa",
                            Product = "Software"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e56d4dcc-313b-4310-928f-01cc293fd7da"),
                            CompanyId = new Guid("0d8c6be7-e984-4ade-8997-8a1e67ea0c22"),
                            DateOfBirth = new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G055",
                            FirstName = "Harry",
                            Gender = 1,
                            LastName = "Miko"
                        },
                        new
                        {
                            Id = new Guid("a68c7721-beb7-453d-b9f1-a661a2040ed4"),
                            CompanyId = new Guid("0d8c6be7-e984-4ade-8997-8a1e67ea0c22"),
                            DateOfBirth = new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G001",
                            FirstName = "Live",
                            Gender = 1,
                            LastName = "Mai"
                        },
                        new
                        {
                            Id = new Guid("2affcefc-9ae1-4bd5-bb6e-6100ab0b4faa"),
                            CompanyId = new Guid("6fa484b4-26aa-405a-a1f6-7f82092f66b6"),
                            DateOfBirth = new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G016",
                            FirstName = "Love",
                            Gender = 2,
                            LastName = "Pi"
                        },
                        new
                        {
                            Id = new Guid("124bcc74-7bc5-4a25-ad43-e43814014ef9"),
                            CompanyId = new Guid("6fa484b4-26aa-405a-a1f6-7f82092f66b6"),
                            DateOfBirth = new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G044",
                            FirstName = "Papa",
                            Gender = 2,
                            LastName = "Richardson"
                        },
                        new
                        {
                            Id = new Guid("267b4f39-1641-4387-9e2d-584f5fec4bfd"),
                            CompanyId = new Guid("658d4ed3-1505-4d02-b9ed-942e2a918e38"),
                            DateOfBirth = new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G003",
                            FirstName = "Marry",
                            Gender = 2,
                            LastName = "King"
                        },
                        new
                        {
                            Id = new Guid("4d143264-be9a-41e7-83d2-a6bd5a0c7e7d"),
                            CompanyId = new Guid("658d4ed3-1505-4d02-b9ed-942e2a918e38"),
                            DateOfBirth = new DateTime(1976, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeNo = "G004",
                            FirstName = "Kevin",
                            Gender = 1,
                            LastName = "Richardson"
                        });
                });

            modelBuilder.Entity("Routine.Api.Entities.Employee", b =>
                {
                    b.HasOne("Routine.Api.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
