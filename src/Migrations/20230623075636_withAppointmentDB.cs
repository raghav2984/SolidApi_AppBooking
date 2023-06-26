using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Migrations
{
    /// <inheritdoc />
    public partial class withAppointmentDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_patient",
                schema: "Appt_Db",
                table: "patient");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "Appt_Db",
                table: "patient");

            migrationBuilder.DropColumn(
                name: "BookingDate",
                schema: "Appt_Db",
                table: "patient");

            migrationBuilder.DropColumn(
                name: "SlotId",
                schema: "Appt_Db",
                table: "patient");

            migrationBuilder.DropColumn(
                name: "BookingId",
                schema: "Appt_Db",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Cost",
                schema: "Appt_Db",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "IsReservedDescription",
                schema: "Appt_Db",
                table: "doctor");

            migrationBuilder.DropColumn(
                name: "Time",
                schema: "Appt_Db",
                table: "doctor");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_patient",
                schema: "Appointment_Db",
                table: "patient",
                column: "PatientId");

            migrationBuilder.CreateTable(
                name: "appointment",
                schema: "Appointment_Db",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uuid", nullable: false),
                    Start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsReservedDescription = table.Column<bool>(type: "boolean", nullable: false),
                    Cost = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.BookingId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointment",
                schema: "Appointment_Db");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patient",
                schema: "Appointment_Db",
                table: "patient");

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

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                schema: "Appt_Db",
                table: "patient",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "BookingDate",
                schema: "Appt_Db",
                table: "patient",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "SlotId",
                schema: "Appt_Db",
                table: "patient",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                schema: "Appt_Db",
                table: "doctor",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "Cost",
                schema: "Appt_Db",
                table: "doctor",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsReservedDescription",
                schema: "Appt_Db",
                table: "doctor",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                schema: "Appt_Db",
                table: "doctor",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_patient",
                schema: "Appt_Db",
                table: "patient",
                column: "Id");
        }
    }
}
