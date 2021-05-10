﻿// <auto-generated />
using System;
using EMR_HSV.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMR_HSV.Migrations
{
    [DbContext(typeof(EMR_HSVContext))]
    [Migration("20210226001051_modified_va_enum")]
    partial class modified_va_enum
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMR_HSV.Models.EyeTest", b =>
                {
                    b.Property<int>("EyeTestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("TestName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EyeTestID");

                    b.HasIndex("PatientId");

                    b.ToTable("EyeTest");

                    b.HasDiscriminator<string>("Discriminator").HasValue("EyeTest");
                });

            modelBuilder.Entity("EMR_HSV.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyContactCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyContactFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyContactPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyContactSecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyContactState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyContactStreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilyContactZipCode")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleInitial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientGender")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberPrimary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumberSecondary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.VisualAcuity", b =>
                {
                    b.HasBaseType("EMR_HSV.Models.EyeTest");

                    b.Property<int>("eyeTested")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("VisualAcuity");
                });

            modelBuilder.Entity("EMR_HSV.Models.EyeTest", b =>
                {
                    b.HasOne("EMR_HSV.Models.Patient", "Patient")
                        .WithMany("PatientTestResults")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.Patient", b =>
                {
                    b.Navigation("PatientTestResults");
                });
#pragma warning restore 612, 618
        }
    }
}
