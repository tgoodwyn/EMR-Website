using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class first_round_va_prescripts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "correctorsUsed",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "detailDistanceFar",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "detailDistanceNear",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "detailDistancePinhole",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "pinholeUsed",
                table: "EyeTest",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "viewDistanceFar",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "viewDistanceNear",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "viewDistancePinhole",
                table: "EyeTest",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "correctorsUsed",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "detailDistanceFar",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "detailDistanceNear",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "detailDistancePinhole",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "pinholeUsed",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "viewDistanceFar",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "viewDistanceNear",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "viewDistancePinhole",
                table: "EyeTest");
        }
    }
}
