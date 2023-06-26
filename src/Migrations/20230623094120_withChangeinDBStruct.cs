using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class withChangeinDBStruct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Appt_Db");

            migrationBuilder.RenameTable(
                name: "patient",
                schema: "Appointment_Db",
                newName: "patient",
                newSchema: "Appt_Db");

            migrationBuilder.RenameTable(
                name: "doctor",
                schema: "Appointment_Db",
                newName: "doctor",
                newSchema: "Appt_Db");

            migrationBuilder.RenameTable(
                name: "appointment",
                schema: "Appointment_Db",
                newName: "appointment",
                newSchema: "Appt_Db");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                schema: "Appt_Db",
                table: "appointment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "PatientId",
                schema: "Appt_Db",
                table: "appointment",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "PatientName",
                schema: "Appt_Db",
                table: "appointment",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoctorName",
                schema: "Appt_Db",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "PatientId",
                schema: "Appt_Db",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "PatientName",
                schema: "Appt_Db",
                table: "appointment");

            migrationBuilder.EnsureSchema(
                name: "Appointment_Db");

            migrationBuilder.RenameTable(
                name: "patient",
                schema: "Appt_Db",
                newName: "patient",
                newSchema: "Appointment_Db");

            migrationBuilder.RenameTable(
                name: "doctor",
                schema: "Appt_Db",
                newName: "doctor",
                newSchema: "Appointment_Db");

            migrationBuilder.RenameTable(
                name: "appointment",
                schema: "Appt_Db",
                newName: "appointment",
                newSchema: "Appointment_Db");
        }
    }
}
