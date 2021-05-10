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
    [Migration("20210226011117_first_round_va_prescripts2")]
    partial class first_round_va_prescripts2
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

                    b.Property<string>("dateOfTest")
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

            modelBuilder.Entity("EMR_HSV.Models.Prescription", b =>
                {
                    b.HasBaseType("EMR_HSV.Models.EyeTest");

                    b.Property<float>("add")
                        .HasColumnType("real");

                    b.Property<float>("axis")
                        .HasColumnType("real");

                    b.Property<float>("cylinder")
                        .HasColumnType("real");

                    b.Property<int>("detailDistanceFar")
                        .HasColumnType("int");

                    b.Property<int>("detailDistanceNear")
                        .HasColumnType("int");

                    b.Property<float>("prism")
                        .HasColumnType("real");

                    b.Property<float>("prismBase")
                        .HasColumnType("real");

                    b.Property<int>("specificEye")
                        .HasColumnType("int");

                    b.Property<float>("sphere")
                        .HasColumnType("real");

                    b.Property<int>("viewDistanceFar")
                        .HasColumnType("int");

                    b.Property<int>("viewDistanceNear")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Prescription");
                });

            modelBuilder.Entity("EMR_HSV.Models.VisualAcuity", b =>
                {
                    b.HasBaseType("EMR_HSV.Models.EyeTest");

                    b.Property<bool>("correctorsUsed")
                        .HasColumnType("bit");

                    b.Property<int>("detailDistanceFar")
                        .HasColumnType("int")
                        .HasColumnName("VisualAcuity_detailDistanceFar");

                    b.Property<int>("detailDistanceNear")
                        .HasColumnType("int")
                        .HasColumnName("VisualAcuity_detailDistanceNear");

                    b.Property<int>("detailDistancePinhole")
                        .HasColumnType("int");

                    b.Property<int>("eyeTested")
                        .HasColumnType("int");

                    b.Property<bool>("pinholeUsed")
                        .HasColumnType("bit");

                    b.Property<int>("viewDistanceFar")
                        .HasColumnType("int")
                        .HasColumnName("VisualAcuity_viewDistanceFar");

                    b.Property<int>("viewDistanceNear")
                        .HasColumnType("int")
                        .HasColumnName("VisualAcuity_viewDistanceNear");

                    b.Property<int>("viewDistancePinhole")
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
