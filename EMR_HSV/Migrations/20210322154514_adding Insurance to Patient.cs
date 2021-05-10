using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMR_HSV.Migrations
{
    public partial class addingInsurancetoPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Insurance_PatientId",
                table: "Insurance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Insurance",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_PatientId",
                table: "Insurance",
                column: "PatientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Insurance_PatientId",
                table: "Insurance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EffectiveDate",
                table: "Insurance",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_PatientId",
                table: "Insurance",
                column: "PatientId");
        }
    }
}
