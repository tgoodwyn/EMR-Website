using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class changed_va : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "correctorsUsed",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "detailDistancePinhole",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "eyeTested",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "pinholeUsed",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "viewDistancePinhole",
                table: "EyeTest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "correctorsUsed",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "detailDistancePinhole",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "eyeTested",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "pinholeUsed",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "viewDistancePinhole",
                table: "EyeTest",
                type: "int",
                nullable: true);
        }
    }
}
