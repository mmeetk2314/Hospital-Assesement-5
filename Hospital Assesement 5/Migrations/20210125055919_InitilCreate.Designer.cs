﻿// <auto-generated />
using System;
using Hospital_Assesement_5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hospital_Assesement_5.Migrations
{
    [DbContext(typeof(Hospital_Assesement_5Context))]
    [Migration("20210125055919_InitilCreate")]
    partial class InitilCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hospital_Assesement_5.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HospitalID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorID");

                    b.HasIndex("HospitalID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Hospital_Assesement_5.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HospitalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalBranch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HospitalFloor")
                        .HasColumnType("int");

                    b.Property<string>("HospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HospitalOpeningDate")
                        .HasColumnType("datetime2");

                    b.HasKey("HospitalID");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("Hospital_Assesement_5.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HospitalID")
                        .HasColumnType("int");

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("MedicineID");

                    b.HasIndex("HospitalID");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("Hospital_Assesement_5.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContactNumber")
                        .HasColumnType("int");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("PatientAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("Hospital_Assesement_5.Models.Doctor", b =>
                {
                    b.HasOne("Hospital_Assesement_5.Models.Hospital", "Hospital_ID")
                        .WithMany()
                        .HasForeignKey("HospitalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital_Assesement_5.Models.Medicine", b =>
                {
                    b.HasOne("Hospital_Assesement_5.Models.Hospital", "Hospital_ID")
                        .WithMany()
                        .HasForeignKey("HospitalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital_Assesement_5.Models.Patient", b =>
                {
                    b.HasOne("Hospital_Assesement_5.Models.Doctor", "Doctor_ID")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
