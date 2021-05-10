using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class prescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescription",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ODifTrue_OSifFalse = table.Column<bool>(type: "bit", nullable: false),
                    sphere = table.Column<float>(type: "real", nullable: false),
                    cylinder = table.Column<float>(type: "real", nullable: false),
                    axis = table.Column<float>(type: "real", nullable: false),
                    add = table.Column<float>(type: "real", nullable: false),
                    prism = table.Column<float>(type: "real", nullable: false),
                    prismBase = table.Column<float>(type: "real", nullable: false),
                    nearMeasurement = table.Column<int>(type: "int", nullable: false),
                    farMeasurement = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_patientID",
                table: "Prescription",
                column: "patientID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescription");
        }
    }
}
