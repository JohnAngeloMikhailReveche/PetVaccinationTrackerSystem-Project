using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddedNavigationInVaccAndPet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "PetID",
                table: "VaccinationList");

            migrationBuilder.DropColumn(
                name: "VaccinationID",
                table: "PetList");
        }
    }
}
