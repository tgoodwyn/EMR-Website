using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class AddingArrivalTimedouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeOfArrival",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<double>(
                name: "ArrivalTime",
                table: "Appointment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArrivalTime",
                table: "Appointment");

            migrationBuilder.AlterColumn<double>(
                name: "TimeOfArrival",
                table: "Appointment",
                type: "float",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            }
    }
}
