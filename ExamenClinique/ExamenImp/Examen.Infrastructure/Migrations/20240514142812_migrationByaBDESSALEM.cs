using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    public partial class migrationByaBDESSALEM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliniques",
                columns: table => new
                {
                    CliniqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacite = table.Column<int>(type: "int", nullable: false),
                    NumTel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliniques", x => x.CliniqueId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    CIN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AdresseEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomComplet_Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomComplet_Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDossier = table.Column<int>(type: "int", nullable: false),
                    NumTel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Chambres",
                columns: table => new
                {
                    NumeroChambre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    TypeChambre = table.Column<int>(type: "int", nullable: false),
                    CliniqueFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambres", x => x.NumeroChambre);
                    table.ForeignKey(
                        name: "FK_Chambres_Cliniques_CliniqueFK",
                        column: x => x.CliniqueFK,
                        principalTable: "Cliniques",
                        principalColumn: "CliniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admissions",
                columns: table => new
                {
                    DateAdmission = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChambreFk = table.Column<int>(type: "int", nullable: false),
                    PatientFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MotifAdmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NbJours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admissions", x => new { x.ChambreFk, x.PatientFk, x.DateAdmission });
                    table.ForeignKey(
                        name: "FK_Admissions_Chambres_ChambreFk",
                        column: x => x.ChambreFk,
                        principalTable: "Chambres",
                        principalColumn: "NumeroChambre",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Admissions_Patients_PatientFk",
                        column: x => x.PatientFk,
                        principalTable: "Patients",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admissions_PatientFk",
                table: "Admissions",
                column: "PatientFk");

            migrationBuilder.CreateIndex(
                name: "IX_Chambres_CliniqueFK",
                table: "Chambres",
                column: "CliniqueFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admissions");

            migrationBuilder.DropTable(
                name: "Chambres");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Cliniques");
        }
    }
}
