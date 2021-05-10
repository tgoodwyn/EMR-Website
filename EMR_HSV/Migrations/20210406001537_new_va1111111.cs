using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class new_va1111111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "appointmentID",
                table: "VisualAck",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VisualAck_appointmentID",
                table: "VisualAck",
                column: "appointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisualAck_Appointment_appointmentID",
                table: "VisualAck",
                column: "appointmentID",
                principalTable: "Appointment",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisualAck_Appointment_appointmentID",
                table: "VisualAck");

            migrationBuilder.DropIndex(
                name: "IX_VisualAck_appointmentID",
                table: "VisualAck");

            migrationBuilder.DropColumn(
                name: "appointmentID",
                table: "VisualAck");
        }
    }
}
