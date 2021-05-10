using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class ocex_on_its_own_now_take_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OcularExam_AppointmentID",
                table: "OcularExam",
                column: "AppointmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_OcularExam_Appointment_AppointmentID",
                table: "OcularExam",
                column: "AppointmentID",
                principalTable: "Appointment",
                principalColumn: "AppointmentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OcularExam_Appointment_AppointmentID",
                table: "OcularExam");

            migrationBuilder.DropIndex(
                name: "IX_OcularExam_AppointmentID",
                table: "OcularExam");
        }
    }
}
