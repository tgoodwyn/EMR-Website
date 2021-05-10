using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class new_va111111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisualAck",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    distanceOrNear = table.Column<int>(type: "int", nullable: false),
                    measurement = table.Column<int>(type: "int", nullable: false),
                    correctorsUsed = table.Column<bool>(type: "bit", nullable: false),
                    pinholeUsed = table.Column<bool>(type: "bit", nullable: false),
                    pinholeMeasurement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisualAck", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisualAck");
        }
    }
}
