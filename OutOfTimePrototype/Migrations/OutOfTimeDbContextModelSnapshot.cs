﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using OutOfTimePrototype.DAL;

#nullable disable

namespace OutOfTimePrototype.Migrations
{
    [DbContext(typeof(OutOfTimeDbContext))]
    partial class OutOfTimeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.CampusBuilding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CampusBuildings");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ClusterNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("EducatorId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LectureHallId")
                        .HasColumnType("uuid");

                    b.Property<int>("TimeSlotNumber")
                        .HasColumnType("integer");

                    b.Property<string>("TypeName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ClusterNumber");

                    b.HasIndex("EducatorId");

                    b.HasIndex("LectureHallId");

                    b.HasIndex("TimeSlotNumber");

                    b.HasIndex("TypeName");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.ClassType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("ClassTypes");

                    b.HasData(
                        new
                        {
                            Name = "Practice"
                        },
                        new
                        {
                            Name = "Lecture"
                        },
                        new
                        {
                            Name = "Seminar"
                        },
                        new
                        {
                            Name = "Laboratory"
                        },
                        new
                        {
                            Name = "Exam"
                        });
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.Cluster", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<string>("SuperClusterNumber")
                        .HasColumnType("text");

                    b.HasKey("Number");

                    b.HasIndex("SuperClusterNumber");

                    b.ToTable("Clusters");

                    b.HasData(
                        new
                        {
                            Number = "9721"
                        });
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.Educator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Educators");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b567b9e6-4c7d-4a28-970c-e2462512de57"),
                            FirstName = "Educator",
                            LastName = "Educatorov",
                            MiddleName = "Educatorovich"
                        },
                        new
                        {
                            Id = new Guid("74253563-1472-4fd8-9cc5-21e6120c8a45"),
                            FirstName = "Prepod",
                            LastName = "Prepodov",
                            MiddleName = "Prepodovich"
                        });
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.LectureHall", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<Guid>("HostBuildingId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HostBuildingId");

                    b.ToTable("LectureHalls");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.TimeSlot", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Number"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Number");

                    b.ToTable("TimeSlots");

                    b.HasData(
                        new
                        {
                            Number = 1,
                            EndTime = new DateTime(2023, 2, 22, 3, 20, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 1, 45, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Number = 2,
                            EndTime = new DateTime(2023, 2, 22, 5, 10, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 3, 35, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Number = 3,
                            EndTime = new DateTime(2023, 2, 22, 7, 0, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 5, 25, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Number = 4,
                            EndTime = new DateTime(2023, 2, 22, 9, 20, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 7, 45, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Number = 5,
                            EndTime = new DateTime(2023, 2, 22, 11, 10, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 9, 35, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Number = 6,
                            EndTime = new DateTime(2023, 2, 22, 13, 0, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 11, 25, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Number = 7,
                            EndTime = new DateTime(2023, 2, 22, 14, 50, 0, 0, DateTimeKind.Utc),
                            StartTime = new DateTime(2023, 2, 22, 13, 15, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("OutOfTimePrototype.Dal.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("OutOfTimePrototype.Dal.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccountType")
                        .HasColumnType("integer");

                    b.Property<int[]>("ClaimedRoles")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<string>("ClusterNumber")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("GradeBookNumber")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("ScheduleSelfId")
                        .HasColumnType("uuid");

                    b.Property<int[]>("VerifiedRoles")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.HasIndex("ClusterNumber");

                    b.HasIndex("ScheduleSelfId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.Class", b =>
                {
                    b.HasOne("OutOfTimePrototype.DAL.Models.Cluster", "Cluster")
                        .WithMany()
                        .HasForeignKey("ClusterNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfTimePrototype.DAL.Models.Educator", "Educator")
                        .WithMany()
                        .HasForeignKey("EducatorId");

                    b.HasOne("OutOfTimePrototype.DAL.Models.LectureHall", "LectureHall")
                        .WithMany()
                        .HasForeignKey("LectureHallId");

                    b.HasOne("OutOfTimePrototype.DAL.Models.TimeSlot", "TimeSlot")
                        .WithMany()
                        .HasForeignKey("TimeSlotNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfTimePrototype.DAL.Models.ClassType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeName");

                    b.Navigation("Cluster");

                    b.Navigation("Educator");

                    b.Navigation("LectureHall");

                    b.Navigation("TimeSlot");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.Cluster", b =>
                {
                    b.HasOne("OutOfTimePrototype.DAL.Models.Cluster", "SuperCluster")
                        .WithMany()
                        .HasForeignKey("SuperClusterNumber");

                    b.Navigation("SuperCluster");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.LectureHall", b =>
                {
                    b.HasOne("OutOfTimePrototype.DAL.Models.CampusBuilding", "HostBuilding")
                        .WithMany("LectureHalls")
                        .HasForeignKey("HostBuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HostBuilding");
                });

            modelBuilder.Entity("OutOfTimePrototype.Dal.Models.User", b =>
                {
                    b.HasOne("OutOfTimePrototype.DAL.Models.Cluster", "Cluster")
                        .WithMany()
                        .HasForeignKey("ClusterNumber");

                    b.HasOne("OutOfTimePrototype.DAL.Models.Educator", "ScheduleSelf")
                        .WithMany()
                        .HasForeignKey("ScheduleSelfId");

                    b.Navigation("Cluster");

                    b.Navigation("ScheduleSelf");
                });

            modelBuilder.Entity("OutOfTimePrototype.DAL.Models.CampusBuilding", b =>
                {
                    b.Navigation("LectureHalls");
                });
#pragma warning restore 612, 618
        }
    }
}
