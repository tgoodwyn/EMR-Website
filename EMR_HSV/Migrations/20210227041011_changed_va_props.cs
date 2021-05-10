using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class changed_va_props : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "correctors",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "eyes",
                table: "EyeTest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "prescription",
                table: "EyeTest",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "correctors",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "eyes",
                table: "EyeTest");

            migrationBuilder.DropColumn(
                name: "prescription",
                table: "EyeTest");
        }
    }
}
