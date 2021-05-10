using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class added_scheduling_properties_to_Patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "appointmentTimeSlot",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "hasAppointmentToday",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasArrived",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "hasBeenCheckedIn",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "appointmentTimeSlot",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "hasAppointmentToday",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "hasArrived",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "hasBeenCheckedIn",
                table: "Patient");
        }
    }
}
