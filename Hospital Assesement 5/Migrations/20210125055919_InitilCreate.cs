using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_Assesement_5.Migrations
{
    public partial class InitilCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    HospitalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(nullable: true),
                    HospitalBranch = table.Column<string>(nullable: true),
                    HospitalOpeningDate = table.Column<DateTime>(nullable: false),
                    HospitalAddress = table.Column<string>(nullable: true),
                    HospitalFloor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.HospitalID);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    ContactNumber = table.Column<int>(nullable: false),
                    EmailId = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorID);
                    table.ForeignKey(
                        name: "FK_Doctor_Hospital_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospital",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    MedicineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    HospitalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.MedicineID);
                    table.ForeignKey(
                        name: "FK_Medicine_Hospital_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospital",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<int>(nullable: false),
                    PatientAddress = table.Column<string>(nullable: true),
                    DoctorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patient_Doctor_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctor",
                        principalColumn: "DoctorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_HospitalID",
                table: "Doctor",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_HospitalID",
                table: "Medicine",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorID",
                table: "Patient",
                column: "DoctorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
