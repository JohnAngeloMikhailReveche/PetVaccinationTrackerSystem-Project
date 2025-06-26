using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class fiexedPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerPhoneNumber",
                table: "PetList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "OwnerPhoneNumber",
                table: "PetList",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
