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
    [Migration("20210406001537_new_va1111111")]
    partial class new_va1111111
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
                        .HasColumnType("Date");

                    b.Property<double>("ArrivalTime")
                        .HasColumnType("float");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<bool>("hasArrived")
                        .HasColumnType("bit");

                    b.Property<bool>("hasBeenCheckedIn")
                        .HasColumnType("bit");

                    b.Property<bool>("isFinished")
                        .HasColumnType("bit");

                    b.Property<bool>("isWithDoctor")
                        .HasColumnType("bit");

                    b.HasKey("AppointmentID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PatientID");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("EMR_HSV.Models.Doctor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("EMR_HSV.Models.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Copay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("Date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PatientId")
                        .IsUnique();

                    b.ToTable("Insurance");
                });

            modelBuilder.Entity("EMR_HSV.Models.OcularExam", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ARMD")
                        .HasColumnType("int");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<bool>("DeepLaminaOD")
                        .HasColumnType("bit");

                    b.Property<bool>("DeepLaminaOS")
                        .HasColumnType("bit");

                    b.Property<int>("DiabeticEval")
                        .HasColumnType("int");

                    b.Property<int>("DilatingAgent")
                        .HasColumnType("int");

                    b.Property<int>("FovealReflexOD")
                        .HasColumnType("int");

                    b.Property<int>("FovealReflexOS")
                        .HasColumnType("int");

                    b.Property<int>("FundusDilation")
                        .HasColumnType("int");

                    b.Property<bool>("FundusEvaluation20D")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusEvaluation78D")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusEvaluation90D")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusEvaluationDirect")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusEvaluationOther")
                        .HasColumnType("bit");

                    b.Property<string>("FundusEvaluationOtherString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FundusEvaluationPR")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusEvaluationScleral")
                        .HasColumnType("bit");

                    b.Property<int>("FundusMethod")
                        .HasColumnType("int");

                    b.Property<bool>("FundusNotesAdvised")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesContraindicated")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesDeclined")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesNotIndicated")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesPerformed")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesRecent")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesRefused")
                        .HasColumnType("bit");

                    b.Property<bool>("FundusNotesRescheduled")
                        .HasColumnType("bit");

                    b.Property<bool>("GlialRemnantsOD")
                        .HasColumnType("bit");

                    b.Property<bool>("GlialRemnantsOS")
                        .HasColumnType("bit");

                    b.Property<int>("HTNEval")
                        .HasColumnType("int");

                    b.Property<int>("Macula")
                        .HasColumnType("int");

                    b.Property<int>("MiscRetina")
                        .HasColumnType("int");

                    b.Property<bool>("MuyelinationOD")
                        .HasColumnType("bit");

                    b.Property<bool>("MuyelinationOS")
                        .HasColumnType("bit");

                    b.Property<int>("NerveFiberLayer")
                        .HasColumnType("int");

                    b.Property<float>("ODSliderHorizontal")
                        .HasColumnType("real");

                    b.Property<float>("ODSliderVertical")
                        .HasColumnType("real");

                    b.Property<float>("OSSliderHorizontal")
                        .HasColumnType("real");

                    b.Property<float>("OSSliderVertical")
                        .HasColumnType("real");

                    b.Property<int>("OpticNerve")
                        .HasColumnType("int");

                    b.Property<bool>("OpticPitOD")
                        .HasColumnType("bit");

                    b.Property<bool>("OpticPitOS")
                        .HasColumnType("bit");

                    b.Property<bool>("OvalOD")
                        .HasColumnType("bit");

                    b.Property<bool>("OvalOS")
                        .HasColumnType("bit");

                    b.Property<bool>("PeripapAtrophyOD")
                        .HasColumnType("bit");

                    b.Property<bool>("PeripapAtrophyOS")
                        .HasColumnType("bit");

                    b.Property<int>("PeripheralRetina")
                        .HasColumnType("int");

                    b.Property<bool>("PigmentCresentOD")
                        .HasColumnType("bit");

                    b.Property<bool>("PigmentCresentOS")
                        .HasColumnType("bit");

                    b.Property<int>("PosteriorPole")
                        .HasColumnType("int");

                    b.Property<bool>("RoundOD")
                        .HasColumnType("bit");

                    b.Property<bool>("RoundOS")
                        .HasColumnType("bit");

                    b.Property<bool>("ScleralCresentOD")
                        .HasColumnType("bit");

                    b.Property<bool>("ScleralCresentOS")
                        .HasColumnType("bit");

                    b.Property<bool>("ShallowOD")
                        .HasColumnType("bit");

                    b.Property<bool>("ShallowOS")
                        .HasColumnType("bit");

                    b.Property<int>("SpontaneousVenousPulsationOD")
                        .HasColumnType("int");

                    b.Property<int>("SpontaneousVenousPulsationOS")
                        .HasColumnType("int");

                    b.Property<bool>("TempSlopingOD")
                        .HasColumnType("bit");

                    b.Property<bool>("TempSlopingOS")
                        .HasColumnType("bit");

                    b.Property<bool>("UnderminingOD")
                        .HasColumnType("bit");

                    b.Property<bool>("UnderminingOS")
                        .HasColumnType("bit");

                    b.Property<int>("Vasculature")
                        .HasColumnType("int");

                    b.Property<int>("Vitreous")
                        .HasColumnType("int");

                    b.Property<int>("custom1")
                        .HasColumnType("int");

                    b.Property<int>("custom2")
                        .HasColumnType("int");

                    b.Property<int>("custom3")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("AppointmentID");

                    b.ToTable("OcularExam");
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

            modelBuilder.Entity("EMR_HSV.Models.VisualAck", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("appointmentID")
                        .HasColumnType("int");

                    b.Property<bool>("correctorsUsed")
                        .HasColumnType("bit");

                    b.Property<int>("distanceOrNear")
                        .HasColumnType("int");

                    b.Property<int>("measurement")
                        .HasColumnType("int");

                    b.Property<int>("pinholeMeasurement")
                        .HasColumnType("int");

                    b.Property<bool>("pinholeUsed")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("appointmentID");

                    b.ToTable("VisualAck");
                });

            modelBuilder.Entity("EMR_HSV.Models.VisualAcuity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ID");

                    b.ToTable("VisualAcuity");
                });

            modelBuilder.Entity("EMR_HSV.Models.Appointment", b =>
                {
                    b.HasOne("EMR_HSV.Models.Doctor", "DoctorToSee")
                        .WithMany("doctorsAppointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EMR_HSV.Models.Patient", "Patient")
                        .WithMany("MedicalHistory")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorToSee");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.Insurance", b =>
                {
                    b.HasOne("EMR_HSV.Models.Patient", "Patient")
                        .WithOne("Insurance")
                        .HasForeignKey("EMR_HSV.Models.Insurance", "PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.OcularExam", b =>
                {
                    b.HasOne("EMR_HSV.Models.Appointment", null)
                        .WithMany("OcularExamTests")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EMR_HSV.Models.VisualAck", b =>
                {
                    b.HasOne("EMR_HSV.Models.Appointment", "Appointment")
                        .WithMany("VisualAcuityTests")
                        .HasForeignKey("appointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("EMR_HSV.Models.Appointment", b =>
                {
                    b.Navigation("OcularExamTests");

                    b.Navigation("VisualAcuityTests");
                });

            modelBuilder.Entity("EMR_HSV.Models.Doctor", b =>
                {
                    b.Navigation("doctorsAppointments");
                });

            modelBuilder.Entity("EMR_HSV.Models.Patient", b =>
                {
                    b.Navigation("Insurance");

                    b.Navigation("MedicalHistory");
                });
#pragma warning restore 612, 618
        }
    }
}