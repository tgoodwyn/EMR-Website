// <auto-generated />
using System;
using EMR_HSV.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMR_HSV.Migrations
{
    [DbContext(typeof(EMR_HSVContext))]
    partial class EMR_HSVContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("reasonForVisit")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("EMR_HSV.Models.MedicalHistory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("PrimaryCareDoctor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PatientID")
                        .IsUnique();

                    b.ToTable("MedicalHistory");
                });

            modelBuilder.Entity("EMR_HSV.Models.MedicalString", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MedicalHistoryID")
                        .HasColumnType("int");

                    b.Property<int>("fieldRef")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MedicalHistoryID");

                    b.ToTable("MedicalString");
                });

            modelBuilder.Entity("EMR_HSV.Models.OcularExam", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ARMD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<bool>("DeepLaminaOD")
                        .HasColumnType("bit");

                    b.Property<bool>("DeepLaminaOS")
                        .HasColumnType("bit");

                    b.Property<string>("DiabeticEval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DilatingAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FovealReflexOD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FovealReflexOS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FundusDilation")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("HTNEval")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Macula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiscRetina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MuyelinationOD")
                        .HasColumnType("bit");

                    b.Property<bool>("MuyelinationOS")
                        .HasColumnType("bit");

                    b.Property<string>("NerveFiberLayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ODSliderHorizontal")
                        .HasColumnType("real");

                    b.Property<float>("ODSliderVertical")
                        .HasColumnType("real");

                    b.Property<float>("OSSliderHorizontal")
                        .HasColumnType("real");

                    b.Property<float>("OSSliderVertical")
                        .HasColumnType("real");

                    b.Property<string>("OpticNerve")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PeripheralRetina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PigmentCresentOD")
                        .HasColumnType("bit");

                    b.Property<bool>("PigmentCresentOS")
                        .HasColumnType("bit");

                    b.Property<string>("PosteriorPole")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("SpontaneousVenousPulsationOD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpontaneousVenousPulsationOS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TempSlopingOD")
                        .HasColumnType("bit");

                    b.Property<bool>("TempSlopingOS")
                        .HasColumnType("bit");

                    b.Property<bool>("UnderminingOD")
                        .HasColumnType("bit");

                    b.Property<bool>("UnderminingOS")
                        .HasColumnType("bit");

                    b.Property<string>("Vasculature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vitreous")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("custom3")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PatientGender")
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("EMR_HSV.Models.Prescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("addOD")
                        .HasColumnType("real");

                    b.Property<float>("addOS")
                        .HasColumnType("real");

                    b.Property<float>("axisOD")
                        .HasColumnType("real");

                    b.Property<float>("axisOS")
                        .HasColumnType("real");

                    b.Property<float>("cylinderOD")
                        .HasColumnType("real");

                    b.Property<float>("cylinderOS")
                        .HasColumnType("real");

                    b.Property<int>("farMeasurementOD")
                        .HasColumnType("int");

                    b.Property<int>("farMeasurementOS")
                        .HasColumnType("int");

                    b.Property<int>("nearMeasurementOD")
                        .HasColumnType("int");

                    b.Property<int>("nearMeasurementOS")
                        .HasColumnType("int");

                    b.Property<int>("patientID")
                        .HasColumnType("int");

                    b.Property<float>("prismBaseOD")
                        .HasColumnType("real");

                    b.Property<float>("prismBaseOS")
                        .HasColumnType("real");

                    b.Property<float>("prismOD")
                        .HasColumnType("real");

                    b.Property<float>("prismOS")
                        .HasColumnType("real");

                    b.Property<float>("sphereOD")
                        .HasColumnType("real");

                    b.Property<float>("sphereOS")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("patientID")
                        .IsUnique();

                    b.ToTable("Prescription");
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

                    b.Property<string>("finalResultString")
                        .HasColumnType("nvarchar(max)");

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
                        .WithMany("PastAppointments")
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

            modelBuilder.Entity("EMR_HSV.Models.MedicalHistory", b =>
                {
                    b.HasOne("EMR_HSV.Models.Patient", "Patient")
                        .WithOne("MedicalHistory")
                        .HasForeignKey("EMR_HSV.Models.MedicalHistory", "PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("EMR_HSV.Models.MedicalString", b =>
                {
                    b.HasOne("EMR_HSV.Models.MedicalHistory", "MedicalHistoryContainer")
                        .WithMany("MedicalStrings")
                        .HasForeignKey("MedicalHistoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalHistoryContainer");
                });

            modelBuilder.Entity("EMR_HSV.Models.OcularExam", b =>
                {
                    b.HasOne("EMR_HSV.Models.Appointment", "Appointment")
                        .WithMany("OcularExamTests")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("EMR_HSV.Models.Prescription", b =>
                {
                    b.HasOne("EMR_HSV.Models.Patient", "Patient")
                        .WithOne("Prescription")
                        .HasForeignKey("EMR_HSV.Models.Prescription", "patientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
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

            modelBuilder.Entity("EMR_HSV.Models.MedicalHistory", b =>
                {
                    b.Navigation("MedicalStrings");
                });

            modelBuilder.Entity("EMR_HSV.Models.Patient", b =>
                {
                    b.Navigation("Insurance");

                    b.Navigation("MedicalHistory");

                    b.Navigation("PastAppointments");

                    b.Navigation("Prescription");
                });
#pragma warning restore 612, 618
        }
    }
}
