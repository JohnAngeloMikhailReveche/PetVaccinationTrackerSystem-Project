using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class EnhancedDbinVaccination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "VaccinationList");

            migrationBuilder.RenameColumn(
                name: "VaccineDesc",
                table: "VaccinationList",
                newName: "AdministeredBy");

            migrationBuilder.AddColumn<string>(
                name: "BatchNo",
                table: "VaccinationList",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdministered",
                table: "VaccinationList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NextDueDate",
                table: "VaccinationList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "VaccinationList",
                type: "nvarchar(300)",
                maxLength: 300,
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "BatchNo",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "DateAdministered",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "NextDueDate",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "PetID",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "VaccinationID",
                table: "PetList");

            migrationBuilder.RenameColumn(
                name: "AdministeredBy",
                table: "VaccinationList",
                newName: "VaccineDesc");

            migrationBuilder.AddColumn<float>(
                name: "Frequency",
                table: "VaccinationList",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
