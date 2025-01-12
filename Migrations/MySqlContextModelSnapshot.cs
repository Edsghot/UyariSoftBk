﻿// <auto-generated />
using System;
using UyariSoftBk.Configuration.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace UyariSoftBk.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Product.Domain.Entity.ProductEntity", b =>
                {
                    b.Property<int>("IdAttendance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int?>("GuestId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("IdAttendance");

                    b.HasIndex("EventId");

                    b.HasIndex("GuestId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Event.Domain.Entity.EventEntity", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("AllGuest")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AllStudent")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("AllTeacher")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("EndTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("EventTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Location")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdEvent");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Event.Domain.Entity.GuestEntity", b =>
                {
                    b.Property<int>("IdGuest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("IdGuest");

                    b.ToTable("Guest", (string)null);
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Student.Domain.Entity.StudentEntity", b =>
                {
                    b.Property<int>("IdStudent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Mail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdStudent");

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Teacher.Domain.Entity.TeacherEntity", b =>
                {
                    b.Property<int>("IdTeacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dni")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Mail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdTeacher");

                    b.ToTable("Teacher", (string)null);
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Product.Domain.Entity.ProductEntity", b =>
                {
                    b.HasOne("AttendanceEpiisBk.Modules.Event.Domain.Entity.EventEntity", "Event")
                        .WithMany("Attendances")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AttendanceEpiisBk.Modules.Event.Domain.Entity.GuestEntity", "Guest")
                        .WithMany("Attendances")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AttendanceEpiisBk.Modules.Student.Domain.Entity.StudentEntity", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AttendanceEpiisBk.Modules.Teacher.Domain.Entity.TeacherEntity", "Teacher")
                        .WithMany("Attendances")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Event");

                    b.Navigation("Guest");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Event.Domain.Entity.EventEntity", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Event.Domain.Entity.GuestEntity", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Student.Domain.Entity.StudentEntity", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("AttendanceEpiisBk.Modules.Teacher.Domain.Entity.TeacherEntity", b =>
                {
                    b.Navigation("Attendances");
                });
#pragma warning restore 612, 618
        }
    }
}