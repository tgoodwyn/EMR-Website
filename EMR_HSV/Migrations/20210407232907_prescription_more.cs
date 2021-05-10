using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class prescription_more : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ODifTrue_OSifFalse",
                table: "Prescription");

            migrationBuilder.RenameColumn(
                name: "sphere",
                table: "Prescription",
                newName: "sphereOS");

            migrationBuilder.RenameColumn(
                name: "prismBase",
                table: "Prescription",
                newName: "sphereOD");

            migrationBuilder.RenameColumn(
                name: "prism",
                table: "Prescription",
                newName: "prismOS");

            migrationBuilder.RenameColumn(
                name: "nearMeasurement",
                table: "Prescription",
                newName: "nearMeasurementOS");

            migrationBuilder.RenameColumn(
                name: "farMeasurement",
                table: "Prescription",
                newName: "nearMeasurementOD");

            migrationBuilder.RenameColumn(
                name: "cylinder",
                table: "Prescription",
                newName: "prismOD");

            migrationBuilder.RenameColumn(
                name: "axis",
                table: "Prescription",
                newName: "prismBaseOS");

            migrationBuilder.RenameColumn(
                name: "add",
                table: "Prescription",
                newName: "prismBaseOD");

            migrationBuilder.AddColumn<float>(
                name: "addOD",
                table: "Prescription",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "addOS",
                table: "Prescription",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "axisOD",
                table: "Prescription",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "axisOS",
                table: "Prescription",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cylinderOD",
                table: "Prescription",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "cylinderOS",
                table: "Prescription",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "farMeasurementOD",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "farMeasurementOS",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "addOD",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "addOS",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "axisOD",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "axisOS",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "cylinderOD",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "cylinderOS",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "farMeasurementOD",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "farMeasurementOS",
                table: "Prescription");

            migrationBuilder.RenameColumn(
                name: "sphereOS",
                table: "Prescription",
                newName: "sphere");

            migrationBuilder.RenameColumn(
                name: "sphereOD",
                table: "Prescription",
                newName: "prismBase");

            migrationBuilder.RenameColumn(
                name: "prismOS",
                table: "Prescription",
                newName: "prism");

            migrationBuilder.RenameColumn(
                name: "prismOD",
                table: "Prescription",
                newName: "cylinder");

            migrationBuilder.RenameColumn(
                name: "prismBaseOS",
                table: "Prescription",
                newName: "axis");

            migrationBuilder.RenameColumn(
                name: "prismBaseOD",
                table: "Prescription",
                newName: "add");

            migrationBuilder.RenameColumn(
                name: "nearMeasurementOS",
                table: "Prescription",
                newName: "nearMeasurement");

            migrationBuilder.RenameColumn(
                name: "nearMeasurementOD",
                table: "Prescription",
                newName: "farMeasurement");

            migrationBuilder.AddColumn<bool>(
                name: "ODifTrue_OSifFalse",
                table: "Prescription",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
