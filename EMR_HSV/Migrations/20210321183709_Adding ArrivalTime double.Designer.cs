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
    [Migration("20210321183709_Adding ArrivalTime double")]
    partial class AddingArrivalTimedouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMR_HSV.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ArrivalTime")
                        .HasColumnType("float");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfArrival")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentID");

                    b.HasIndex("PatientID");

                    b.ToTable("Appointment");
                });

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

                    b.Property<int>("appointmentTimeSlot")
                        .HasColumnType("int");

                    b.Property<bool>("hasAppointmentToday")
                        .HasColumnType("bit");

                    b.Property<bool>("hasArrived")
                        .HasColumnType("bit");

                    b.Property<bool>("hasBeenCheckedIn")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.VisualAcuity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<bool>("correctorsUsed")
                        .HasColumnType("bit");

                    b.Property<int>("detailDistanceFar")
                        .HasColumnType("int");

                    b.Property<int>("detailDistanceNear")
                        .HasColumnType("int");

                    b.Property<int>("detailDistancePinhole")
                        .HasColumnType("int");

                    b.Property<bool>("pinholeUsed")
                        .HasColumnType("bit");

                    b.Property<int>("viewDistanceFar")
                        .HasColumnType("int");

                    b.Property<int>("viewDistanceNear")
                        .HasColumnType("int");

                    b.Property<int>("viewDistancePinhole")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AppointmentID");

                    b.ToTable("VisualAcuity");
                });

            modelBuilder.Entity("EMR_HSV.Models.OcularExam", b =>
                {
                    b.HasBaseType("EMR_HSV.Models.EyeTest");

                    b.Property<int>("ARMD")
                        .HasColumnType("int");

                    b.Property<int>("C1")
                        .HasColumnType("int");

                    b.Property<int>("C2")
                        .HasColumnType("int");

                    b.Property<int>("C3")
                        .HasColumnType("int");

                    b.Property<int>("DE")
                        .HasColumnType("int");

                    b.Property<int>("HTN")
                        .HasColumnType("int");

                    b.Property<int>("MACU")
                        .HasColumnType("int");

                    b.Property<int>("MR")
                        .HasColumnType("int");

                    b.Property<int>("ODFR")
                        .HasColumnType("int");

                    b.Property<int>("ODSVP")
                        .HasColumnType("int");

                    b.Property<int>("OSFR")
                        .HasColumnType("int");

                    b.Property<int>("OSSVP")
                        .HasColumnType("int");

                    b.Property<int>("PP")
                        .HasColumnType("int");

                    b.Property<int>("PR")
                        .HasColumnType("int");

                    b.Property<int>("VASC")
                        .HasColumnType("int");

                    b.Property<int>("VITR")
                        .HasColumnType("int");

                    b.Property<int>("chosenDilationAgent")
                        .HasColumnType("int");

                    b.Property<int>("chosenDilationQuantity")
                        .HasColumnType("int");

                    b.Property<int>("chosenEvaluationTool")
                        .HasColumnType("int");

                    b.Property<int>("chosenNotes")
                        .HasColumnType("int");

                    b.Property<int>("chosenTechnique")
                        .HasColumnType("int");

                    b.Property<string>("conditions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("cpdrODH")
                        .HasColumnType("real");

                    b.Property<float>("cpdrODV")
                        .HasColumnType("real");

                    b.Property<float>("cpdrOSH")
                        .HasColumnType("real");

                    b.Property<float>("cpdrOSV")
                        .HasColumnType("real");

                    b.Property<string>("dilationAgentOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dilationQuantityOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dilationTechniqueOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("evaluationToolOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("indications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("nflayer")
                        .HasColumnType("real");

                    b.Property<string>("notesOptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ondchoices")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("onerve")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("OcularExam");
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

            modelBuilder.Entity("EMR_HSV.Models.Appointment", b =>
                {
                    b.HasOne("EMR_HSV.Models.Patient", null)
                        .WithMany("MedicalHistory")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMR_HSV.Models.EyeTest", b =>
                {
                    b.HasOne("EMR_HSV.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.VisualAcuity", b =>
                {
                    b.HasOne("EMR_HSV.Models.Appointment", null)
                        .WithMany("VisualAcuityTests")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMR_HSV.Models.Appointment", b =>
                {
                    b.Navigation("VisualAcuityTests");
                });

            modelBuilder.Entity("EMR_HSV.Models.Patient", b =>
                {
                    b.Navigation("MedicalHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
