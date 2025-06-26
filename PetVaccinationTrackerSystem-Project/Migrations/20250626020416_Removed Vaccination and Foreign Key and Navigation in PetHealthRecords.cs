using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class RemovedVaccinationandForeignKeyandNavigationinPetHealthRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetHealthRecordsList_VaccinationList_VaccinationID",
                table: "PetHealthRecordsList");

            migrationBuilder.DropTable(
                name: "VaccinationList");

            migrationBuilder.DropIndex(
                name: "IX_PetHealthRecordsList_VaccinationID",
                table: "PetHealthRecordsList");

            migrationBuilder.DropColumn(
                name: "VaccinationID",
                table: "PetHealthRecordsList");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VaccinationID",
                table: "PetHealthRecordsList",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VaccinationList",
                columns: table => new
                {
                    VaccinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicableSpecies = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BatchNumber = table.Column<int>(type: "int", maxLength: 300, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    VaccineDescription = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    VaccineName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationList", x => x.VaccinationID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetHealthRecordsList_VaccinationID",
                table: "PetHealthRecordsList",
                column: "VaccinationID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetHealthRecordsList_VaccinationList_VaccinationID",
                table: "PetHealthRecordsList",
                column: "VaccinationID",
                principalTable: "VaccinationList",
                principalColumn: "VaccinationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
