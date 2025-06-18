using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class OwnerPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "PetList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "OwnerPhoneNumber",
                table: "PetList",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerPhoneNumber",
                table: "PetList");

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "PetList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
