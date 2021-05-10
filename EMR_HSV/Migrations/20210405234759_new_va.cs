using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class new_va : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisualAcuity_Appointment_AppointmentID",
                table: "VisualAcuity");

            migrationBuilder.DropTable(
                name: "EyeTest");

            migrationBuilder.DropColumn(
                name: "correctorsUsed",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "detailDistanceFar",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "detailDistanceNear",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "detailDistancePinhole",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "pinholeUsed",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "viewDistanceFar",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "viewDistanceNear",
                table: "VisualAcuity");

            migrationBuilder.DropColumn(
                name: "viewDistancePinhole",
                table: "VisualAcuity");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentID",
                table: "VisualAcuity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_VisualAcuity_Appointment_AppointmentID",
                table: "VisualAcuity",
                column: "AppointmentID",
                principalTable: "Appointment",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisualAcuity_Appointment_AppointmentID",
                table: "VisualAcuity");

            migrationBuilder.AlterColumn<int>(
                name: "AppointmentID",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "correctorsUsed",
                table: "VisualAcuity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "detailDistanceFar",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "detailDistanceNear",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "detailDistancePinhole",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "pinholeUsed",
                table: "VisualAcuity",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "viewDistanceFar",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "viewDistanceNear",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "viewDistancePinhole",
                table: "VisualAcuity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EyeTest",
                columns: table => new
                {
                    EyeTestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    dateOfTest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    add = table.Column<float>(type: "real", nullable: true),
                    axis = table.Column<float>(type: "real", nullable: true),
                    cylinder = table.Column<float>(type: "real", nullable: true),
                    detailDistanceFar = table.Column<int>(type: "int", nullable: true),
                    detailDistanceNear = table.Column<int>(type: "int", nullable: true),
                    prism = table.Column<float>(type: "real", nullable: true),
                    prismBase = table.Column<float>(type: "real", nullable: true),
                    specificEye = table.Column<int>(type: "int", nullable: true),
                    sphere = table.Column<float>(type: "real", nullable: true),
                    viewDistanceFar = table.Column<int>(type: "int", nullable: true),
                    viewDistanceNear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EyeTest", x => x.EyeTestID);
                    table.ForeignKey(
                        name: "FK_EyeTest_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EyeTest_PatientId",
                table: "EyeTest",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisualAcuity_Appointment_AppointmentID",
                table: "VisualAcuity",
                column: "AppointmentID",
                principalTable: "Appointment",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
