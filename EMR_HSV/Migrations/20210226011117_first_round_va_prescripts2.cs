using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class first_round_va_prescripts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VisualAcuity_detailDistanceFar",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisualAcuity_detailDistanceNear",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisualAcuity_viewDistanceFar",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisualAcuity_viewDistanceNear",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "add",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "axis",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cylinder",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "prism",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "prismBase",
                table: "EyeTest",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "specificEye",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "sphere",
                table: "EyeTest",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisualAcuity_detailDistanceFar",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "VisualAcuity_detailDistanceNear",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "VisualAcuity_viewDistanceFar",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "VisualAcuity_viewDistanceNear",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "add",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "axis",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "cylinder",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "prism",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "prismBase",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "specificEye",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "sphere",
                table: "EyeTest");
        }
    }
}
