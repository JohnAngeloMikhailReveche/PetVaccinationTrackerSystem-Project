using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddedSentPasswordRequestandIsActiveBooleanstoUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "UserList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SentPasswordRequest",
                table: "UserList",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "UserList");

            migrationBuilder.DropColumn(
                name: "SentPasswordRequest",
                table: "UserList");
        }
    }
}
