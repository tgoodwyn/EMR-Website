using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class medical_strings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentMedications",
                table: "MedicalHistory");

            migrationBuilder.DropColumn(
                name: "IllnessesAndConditions",
                table: "MedicalHistory");

            migrationBuilder.DropColumn(
                name: "PastTreatments",
                table: "MedicalHistory");

            migrationBuilder.DropColumn(
                name: "PlannedTreatments",
                table: "MedicalHistory");

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
                name: "IX_MedicalString_MedicalHistoryID",
                table: "MedicalString",
                column: "MedicalHistoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalString");

            migrationBuilder.AddColumn<string>(
                name: "CurrentMedications",
                table: "MedicalHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IllnessesAndConditions",
                table: "MedicalHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastTreatments",
                table: "MedicalHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlannedTreatments",
                table: "MedicalHistory",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
