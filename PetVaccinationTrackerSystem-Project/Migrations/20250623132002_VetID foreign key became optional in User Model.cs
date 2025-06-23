using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class VetIDforeignkeybecameoptionalinUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserList_VeterinarianList_VetID",
                table: "UserList");

            migrationBuilder.AlterColumn<int>(
                name: "VetID",
                table: "UserList",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_UserList_VeterinarianList_VetID",
                table: "UserList",
                column: "VetID",
                principalTable: "VeterinarianList",
                principalColumn: "VetID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserList_VeterinarianList_VetID",
                table: "UserList");

            migrationBuilder.AlterColumn<int>(
                name: "VetID",
                table: "UserList",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserList_VeterinarianList_VetID",
                table: "UserList",
                column: "VetID",
                principalTable: "VeterinarianList",
                principalColumn: "VetID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
