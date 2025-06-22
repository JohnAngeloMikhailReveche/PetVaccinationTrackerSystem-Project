using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class fixedimagepath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "OwnerFirstName",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "OwnerLastName",
                table: "PetList");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "PetList",
                newName: "OwnerPhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "PetList",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorsAndMarkings",
                table: "PetList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "PetList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageRL",
                table: "PetList",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "PetList",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "PetList",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorsAndMarkings",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "ImageRL",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "PetList");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "PetList");

            migrationBuilder.RenameColumn(
                name: "OwnerPhoneNumber",
                table: "PetList",
                newName: "Year");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "PetList",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "PetList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "PetList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OwnerFirstName",
                table: "PetList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerLastName",
                table: "PetList",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
