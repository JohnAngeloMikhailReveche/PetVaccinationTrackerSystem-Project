using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class FixedPetHealthRecordAndVaccineList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetList_VaccinationList_VaccinationID",
                table: "PetList");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccinationList_PetList_PetID",
                table: "VaccinationList");

            migrationBuilder.DropIndex(
                name: "IX_VaccinationList_PetID",
                table: "VaccinationList");

            migrationBuilder.DropIndex(
                name: "IX_PetList_VaccinationID",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "AdministeredBy",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "BatchNo",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "PetID",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "VaccinationID",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "PetHealthRecordsList");

            migrationBuilder.RenameColumn(
                name: "NextDueDate",
                table: "VaccinationList",
                newName: "ManufactureDate");

            migrationBuilder.RenameColumn(
                name: "DateAdministered",
                table: "VaccinationList",
                newName: "ExpiryDate");

            migrationBuilder.AddColumn<string>(
                name: "ApplicableSpecies",
                table: "VaccinationList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BatchNumber",
                table: "VaccinationList",
                type: "int",
                maxLength: 300,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "VaccinationList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineDescription",
                table: "VaccinationList",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RecordID",
                table: "PetList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VaccinationID",
                table: "PetHealthRecordsList",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "AdministeredBy",
                table: "PetHealthRecordsList",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BatchNo",
                table: "PetHealthRecordsList",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "PetHealthRecordsList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdministered",
                table: "PetHealthRecordsList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "PetHealthRecordsList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "NextDueDate",
                table: "PetHealthRecordsList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "PetHealthRecordsList",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PetName",
                table: "PetHealthRecordsList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "PetHealthRecordsList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaccineName",
                table: "PetHealthRecordsList",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicableSpecies",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "BatchNumber",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "VaccineDescription",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "RecordID",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "AdministeredBy",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "BatchNo",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "Breed",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "DateAdministered",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "NextDueDate",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "PetName",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "Species",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "VaccineName",
                table: "PetHealthRecordsList");

            migrationBuilder.RenameColumn(
                name: "ManufactureDate",
                table: "VaccinationList",
                newName: "NextDueDate");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "VaccinationList",
                newName: "DateAdministered");

            migrationBuilder.AddColumn<string>(
                name: "AdministeredBy",
                table: "VaccinationList",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BatchNo",
                table: "VaccinationList",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PetID",
                table: "VaccinationList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VaccinationID",
                table: "PetList",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VaccinationID",
                table: "PetHealthRecordsList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "PetHealthRecordsList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "PetHealthRecordsList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "PetHealthRecordsList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VaccinationList_PetID",
                table: "VaccinationList",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_PetList_VaccinationID",
                table: "PetList",
                column: "VaccinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetList_VaccinationList_VaccinationID",
                table: "PetList",
                column: "VaccinationID",
                principalTable: "VaccinationList",
                principalColumn: "VaccinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccinationList_PetList_PetID",
                table: "VaccinationList",
                column: "PetID",
                principalTable: "PetList",
                principalColumn: "PetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
