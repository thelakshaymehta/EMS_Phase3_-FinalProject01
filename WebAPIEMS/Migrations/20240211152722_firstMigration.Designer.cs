﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIEMS.Data;

#nullable disable

namespace WebAPIEMS.Migrations
{
    [DbContext(typeof(EMSDbContext))]
    [Migration("20240211152722_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPIEMS.Models.DeptMaster", b =>
                {
                    b.Property<int>("DeptCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptCode"), 1L, 1);

                    b.Property<string>("DeptName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptCode");

                    b.ToTable("DeptMaster");

                    b.HasData(
                        new
                        {
                            DeptCode = 1,
                            DeptName = "Human Resources"
                        },
                        new
                        {
                            DeptCode = 2,
                            DeptName = "Finance"
                        },
                        new
                        {
                            DeptCode = 3,
                            DeptName = "IT"
                        },
                        new
                        {
                            DeptCode = 4,
                            DeptName = "Marketing"
                        },
                        new
                        {
                            DeptCode = 5,
                            DeptName = "Sales"
                        });
                });

            modelBuilder.Entity("WebAPIEMS.Models.EmpProfile", b =>
                {
                    b.Property<int>("EmpCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpCode"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeptCode")
                        .HasColumnType("int");

                    b.Property<int?>("DeptMasterDeptCode")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpCode");

                    b.HasIndex("DeptMasterDeptCode");

                    b.ToTable("EmpProfile");

                    b.HasData(
                        new
                        {
                            EmpCode = 101,
                            DateOfBirth = new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptCode = 1,
                            Email = "johndoe@example.com",
                            EmpName = "John Doe"
                        },
                        new
                        {
                            EmpCode = 102,
                            DateOfBirth = new DateTime(1990, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptCode = 2,
                            Email = "janedoe@example.com",
                            EmpName = "Jane Doe"
                        },
                        new
                        {
                            EmpCode = 103,
                            DateOfBirth = new DateTime(1988, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptCode = 3,
                            Email = "jimbeam@example.com",
                            EmpName = "Jim Beam"
                        },
                        new
                        {
                            EmpCode = 104,
                            DateOfBirth = new DateTime(1992, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptCode = 4,
                            Email = "jackdaniels@example.com",
                            EmpName = "Jack Daniels"
                        },
                        new
                        {
                            EmpCode = 105,
                            DateOfBirth = new DateTime(1986, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptCode = 5,
                            Email = "josecuervo@example.com",
                            EmpName = "Jose Cuervo"
                        });
                });

            modelBuilder.Entity("WebAPIEMS.Models.EmpProfile", b =>
                {
                    b.HasOne("WebAPIEMS.Models.DeptMaster", "DeptMaster")
                        .WithMany("EmpProfiles")
                        .HasForeignKey("DeptMasterDeptCode");

                    b.Navigation("DeptMaster");
                });

            modelBuilder.Entity("WebAPIEMS.Models.DeptMaster", b =>
                {
                    b.Navigation("EmpProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
