using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class altered_va : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "prescription",
                table: "EyeTest",
                newName: "chosenTechnique");

            migrationBuilder.RenameColumn(
                name: "eyeTest2",
                table: "EyeTest",
                newName: "chosenNotes");

            migrationBuilder.RenameColumn(
                name: "eyeTest1",
                table: "EyeTest",
                newName: "chosenEvaluationTool");

            migrationBuilder.RenameColumn(
                name: "correctors",
                table: "EyeTest",
                newName: "chosenDilationQuantity");

            migrationBuilder.AddColumn<int>(
                name: "ARMD",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "C1",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "C2",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "C3",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DE",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HTN",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MACU",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MR",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ODFR",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ODSVP",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OSFR",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OSSVP",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PP",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PR",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VASC",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VITR",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "chosenDilationAgent",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "conditions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cpdrODH",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cpdrODV",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cpdrOSH",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cpdrOSV",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dilationAgentOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dilationQuantityOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dilationTechniqueOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "evaluationToolOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "indications",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "nflayer",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notesOptions",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ondchoices",
                table: "EyeTest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "onerve",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeOfArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointment_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisualAcuity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    viewDistanceNear = table.Column<int>(type: "int", nullable: false),
                    detailDistanceNear = table.Column<int>(type: "int", nullable: false),
                    viewDistanceFar = table.Column<int>(type: "int", nullable: false),
                    detailDistanceFar = table.Column<int>(type: "int", nullable: false),
                    correctorsUsed = table.Column<bool>(type: "bit", nullable: false),
                    pinholeUsed = table.Column<bool>(type: "bit", nullable: false),
                    viewDistancePinhole = table.Column<int>(type: "int", nullable: false),
                    detailDistancePinhole = table.Column<int>(type: "int", nullable: false),
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualAcuity", x => x.id);
                    table.ForeignKey(
                        name: "FK_VisualAcuity_Appointment_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointment",
                        principalColumn: "AppointmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_PatientID",
                table: "Appointment",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_VisualAcuity_AppointmentID",
                table: "VisualAcuity",
                column: "AppointmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisualAcuity");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropColumn(
                name: "ARMD",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "C1",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "C2",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "C3",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "DE",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "HTN",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "MACU",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "MR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ODFR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ODSVP",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OSFR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "OSSVP",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PP",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "PR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "VASC",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "VITR",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "chosenDilationAgent",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "conditions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cpdrODH",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cpdrODV",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cpdrOSH",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cpdrOSV",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "dilationAgentOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "dilationQuantityOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "dilationTechniqueOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "evaluationToolOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "indications",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "nflayer",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "notesOptions",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "ondchoices",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "onerve",
                table: "EyeTest");

            migrationBuilder.RenameColumn(
                name: "chosenTechnique",
                table: "EyeTest",
                newName: "prescription");

            migrationBuilder.RenameColumn(
                name: "chosenNotes",
                table: "EyeTest",
                newName: "eyeTest2");

            migrationBuilder.RenameColumn(
                name: "chosenEvaluationTool",
                table: "EyeTest",
                newName: "eyeTest1");

            migrationBuilder.RenameColumn(
                name: "chosenDilationQuantity",
                table: "EyeTest",
                newName: "correctors");
        }
    }
}
