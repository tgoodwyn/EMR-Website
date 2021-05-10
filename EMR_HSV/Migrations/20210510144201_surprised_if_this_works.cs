using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class surprised_if_this_works : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleInitial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<int>(type: "int", nullable: false),
                    PatientGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    PhoneNumberPrimary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberSecondary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactSecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyContactZipCode = table.Column<int>(type: "int", nullable: false),
                    appointmentTimeSlot = table.Column<int>(type: "int", nullable: false),
                    hasAppointmentToday = table.Column<bool>(type: "bit", nullable: false),
                    hasArrived = table.Column<bool>(type: "bit", nullable: false),
                    hasBeenCheckedIn = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VisualAcuity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualAcuity", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ArrivalTime = table.Column<double>(type: "float", nullable: false),
                    reasonForVisit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hasArrived = table.Column<bool>(type: "bit", nullable: false),
                    hasBeenCheckedIn = table.Column<bool>(type: "bit", nullable: false),
                    isWithDoctor = table.Column<bool>(type: "bit", nullable: false),
                    isFinished = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointment_Doctor_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimaryCareDoctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MedicalHistory_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sphereOD = table.Column<float>(type: "real", nullable: false),
                    sphereOS = table.Column<float>(type: "real", nullable: false),
                    cylinderOD = table.Column<float>(type: "real", nullable: false),
                    cylinderOS = table.Column<float>(type: "real", nullable: false),
                    axisOD = table.Column<float>(type: "real", nullable: false),
                    axisOS = table.Column<float>(type: "real", nullable: false),
                    addOD = table.Column<float>(type: "real", nullable: false),
                    addOS = table.Column<float>(type: "real", nullable: false),
                    prismOD = table.Column<float>(type: "real", nullable: false),
                    prismOS = table.Column<float>(type: "real", nullable: false),
                    prismBaseOD = table.Column<float>(type: "real", nullable: false),
                    prismBaseOS = table.Column<float>(type: "real", nullable: false),
                    nearMeasurementOD = table.Column<int>(type: "int", nullable: false),
                    nearMeasurementOS = table.Column<int>(type: "int", nullable: false),
                    farMeasurementOD = table.Column<int>(type: "int", nullable: false),
                    farMeasurementOS = table.Column<int>(type: "int", nullable: false),
                    patientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescription", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescription_Patient_patientID",
                        column: x => x.patientID,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcularExam",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vitreous = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Macula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vasculature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosteriorPole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeripheralRetina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscRetina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiabeticEval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HTNEval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ARMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custom1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custom2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    custom3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpontaneousVenousPulsationOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpontaneousVenousPulsationOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FovealReflexOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FovealReflexOS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundusMethod = table.Column<int>(type: "int", nullable: false),
                    FundusDilation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DilatingAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundusEvaluation78D = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluation90D = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluation20D = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationPR = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationScleral = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationDirect = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationOther = table.Column<bool>(type: "bit", nullable: false),
                    FundusEvaluationOtherString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundusNotesAdvised = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesRescheduled = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesDeclined = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesPerformed = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesRefused = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesNotIndicated = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesContraindicated = table.Column<bool>(type: "bit", nullable: false),
                    FundusNotesRecent = table.Column<bool>(type: "bit", nullable: false),
                    ODSliderHorizontal = table.Column<float>(type: "real", nullable: false),
                    OSSliderHorizontal = table.Column<float>(type: "real", nullable: false),
                    ODSliderVertical = table.Column<float>(type: "real", nullable: false),
                    OSSliderVertical = table.Column<float>(type: "real", nullable: false),
                    OpticNerve = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NerveFiberLayer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeepLaminaOD = table.Column<bool>(type: "bit", nullable: false),
                    ShallowOD = table.Column<bool>(type: "bit", nullable: false),
                    RoundOD = table.Column<bool>(type: "bit", nullable: false),
                    OvalOD = table.Column<bool>(type: "bit", nullable: false),
                    TempSlopingOD = table.Column<bool>(type: "bit", nullable: false),
                    UnderminingOD = table.Column<bool>(type: "bit", nullable: false),
                    PeripapAtrophyOD = table.Column<bool>(type: "bit", nullable: false),
                    ScleralCresentOD = table.Column<bool>(type: "bit", nullable: false),
                    PigmentCresentOD = table.Column<bool>(type: "bit", nullable: false),
                    OpticPitOD = table.Column<bool>(type: "bit", nullable: false),
                    MuyelinationOD = table.Column<bool>(type: "bit", nullable: false),
                    GlialRemnantsOD = table.Column<bool>(type: "bit", nullable: false),
                    DeepLaminaOS = table.Column<bool>(type: "bit", nullable: false),
                    ShallowOS = table.Column<bool>(type: "bit", nullable: false),
                    RoundOS = table.Column<bool>(type: "bit", nullable: false),
                    OvalOS = table.Column<bool>(type: "bit", nullable: false),
                    TempSlopingOS = table.Column<bool>(type: "bit", nullable: false),
                    UnderminingOS = table.Column<bool>(type: "bit", nullable: false),
                    PeripapAtrophyOS = table.Column<bool>(type: "bit", nullable: false),
                    ScleralCresentOS = table.Column<bool>(type: "bit", nullable: false),
                    PigmentCresentOS = table.Column<bool>(type: "bit", nullable: false),
                    OpticPitOS = table.Column<bool>(type: "bit", nullable: false),
                    MuyelinationOS = table.Column<bool>(type: "bit", nullable: false),
                    GlialRemnantsOS = table.Column<bool>(type: "bit", nullable: false),
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcularExam", x => x.id);
                    table.ForeignKey(
                        name: "FK_OcularExam_Appointment_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointment",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisualAck",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    distanceOrNear = table.Column<int>(type: "int", nullable: false),
                    measurement = table.Column<int>(type: "int", nullable: false),
                    correctorsUsed = table.Column<bool>(type: "bit", nullable: false),
                    pinholeUsed = table.Column<bool>(type: "bit", nullable: false),
                    pinholeMeasurement = table.Column<int>(type: "int", nullable: false),
                    finalResultString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    appointmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualAck", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VisualAck_Appointment_appointmentID",
                        column: x => x.appointmentID,
                        principalTable: "Appointment",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalString",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fieldRef = table.Column<int>(type: "int", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicalHistoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalString", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MedicalString_MedicalHistory_MedicalHistoryID",
                        column: x => x.MedicalHistoryID,
                        principalTable: "MedicalHistory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DoctorID",
                table: "Appointment",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_PatientId",
                table: "Insurance",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistory_PatientID",
                table: "MedicalHistory",
                column: "PatientID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalString_MedicalHistoryID",
                table: "MedicalString",
                column: "MedicalHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OcularExam_AppointmentID",
                table: "OcularExam",
                column: "AppointmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_patientID",
                table: "Prescription",
                column: "patientID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisualAck_appointmentID",
                table: "VisualAck",
                column: "appointmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "MedicalString");

            migrationBuilder.DropTable(
                name: "OcularExam");

            migrationBuilder.DropTable(
                name: "Prescription");

            migrationBuilder.DropTable(
                name: "VisualAck");

            migrationBuilder.DropTable(
                name: "VisualAcuity");

            migrationBuilder.DropTable(
                name: "MedicalHistory");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
