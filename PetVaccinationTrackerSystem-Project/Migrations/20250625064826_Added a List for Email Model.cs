using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddedaListforEmailModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Email_UserList_UserID",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "EmailList");

            migrationBuilder.RenameIndex(
                name: "IX_Email_UserID",
                table: "EmailList",
                newName: "IX_EmailList_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailList",
                table: "EmailList",
                column: "EmailID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailList_UserList_UserID",
                table: "EmailList",
                column: "UserID",
                principalTable: "UserList",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailList_UserList_UserID",
                table: "EmailList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailList",
                table: "EmailList");

            migrationBuilder.RenameTable(
                name: "EmailList",
                newName: "Email");

            migrationBuilder.RenameIndex(
                name: "IX_EmailList_UserID",
                table: "Email",
                newName: "IX_Email_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "EmailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Email_UserList_UserID",
                table: "Email",
                column: "UserID",
                principalTable: "UserList",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
