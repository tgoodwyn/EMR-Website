using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class changed_va_split : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "eyes",
                table: "EyeTest",
                newName: "eyeTest2");

            migrationBuilder.AddColumn<int>(
                name: "eyeTest1",
                table: "EyeTest",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "eyeTest1",
                table: "EyeTest");

            migrationBuilder.RenameColumn(
                name: "eyeTest2",
                table: "EyeTest",
                newName: "eyes");
        }
    }
}
