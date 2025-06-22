using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetVaccinationTrackerSystem_Project.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClinicList",
                columns: table => new
                {
                    ClinicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    City = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    State = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicList", x => x.ClinicID);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationList",
                columns: table => new
                {
                    VaccinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    VaccineDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Frequency = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationList", x => x.VaccinationID);
                });

            migrationBuilder.CreateTable(
                name: "VeterinarianList",
                columns: table => new
                {
                    VetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClinicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeterinarianList", x => x.VetID);
                    table.ForeignKey(
                        name: "FK_VeterinarianList_ClinicList_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "ClinicList",
                        principalColumn: "ClinicID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserList",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserList", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserList_VeterinarianList_VetID",
                        column: x => x.VetID,
                        principalTable: "VeterinarianList",
                        principalColumn: "VetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetList",
                columns: table => new
                {
                    PetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerLastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Species = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetList", x => x.PetID);
                    table.ForeignKey(
                        name: "FK_PetList_UserList_UserID",
                        column: x => x.UserID,
                        principalTable: "UserList",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContactList",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactValue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContactList", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_UserContactList_UserList_UserID",
                        column: x => x.UserID,
                        principalTable: "UserList",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentList",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TimeOfAppointment = table.Column<TimeOnly>(type: "time", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PetID = table.Column<int>(type: "int", nullable: false),
                    VetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentList", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_AppointmentList_PetList_PetID",
                        column: x => x.PetID,
                        principalTable: "PetList",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentList_VeterinarianList_VetID",
                        column: x => x.VetID,
                        principalTable: "VeterinarianList",
                        principalColumn: "VetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PetHealthRecordsList",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    VaccinationID = table.Column<int>(type: "int", nullable: false),
                    VetID = table.Column<int>(type: "int", nullable: false),
                    PetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetHealthRecordsList", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK_PetHealthRecordsList_PetList_PetID",
                        column: x => x.PetID,
                        principalTable: "PetList",
                        principalColumn: "PetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetHealthRecordsList_VaccinationList_VaccinationID",
                        column: x => x.VaccinationID,
                        principalTable: "VaccinationList",
                        principalColumn: "VaccinationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PetHealthRecordsList_VeterinarianList_VetID",
                        column: x => x.VetID,
                        principalTable: "VeterinarianList",
                        principalColumn: "VetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentList_PetID",
                table: "AppointmentList",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentList_VetID",
                table: "AppointmentList",
                column: "VetID");

            migrationBuilder.CreateIndex(
                name: "IX_PetHealthRecordsList_PetID",
                table: "PetHealthRecordsList",
                column: "PetID");

            migrationBuilder.CreateIndex(
                name: "IX_PetHealthRecordsList_VaccinationID",
                table: "PetHealthRecordsList",
                column: "VaccinationID");

            migrationBuilder.CreateIndex(
                name: "IX_PetHealthRecordsList_VetID",
                table: "PetHealthRecordsList",
                column: "VetID");

            migrationBuilder.CreateIndex(
                name: "IX_PetList_UserID",
                table: "PetList",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserContactList_UserID",
                table: "UserContactList",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserList_VetID",
                table: "UserList",
                column: "VetID");

            migrationBuilder.CreateIndex(
                name: "IX_VeterinarianList_ClinicID",
                table: "VeterinarianList",
                column: "ClinicID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentList");

            migrationBuilder.DropTable(
                name: "PetHealthRecordsList");

            migrationBuilder.DropTable(
                name: "UserContactList");

            migrationBuilder.DropTable(
                name: "PetList");

            migrationBuilder.DropTable(
                name: "VaccinationList");

            migrationBuilder.DropTable(
                name: "UserList");

            migrationBuilder.DropTable(
                name: "VeterinarianList");

            migrationBuilder.DropTable(
                name: "ClinicList");
        }
    }
}
