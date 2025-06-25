using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddedSentAccountDeletionforUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SentAccountDeletion",
                table: "UserList",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PetList",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentAccountDeletion",
                table: "UserList");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PetList");
        }
    }
}
