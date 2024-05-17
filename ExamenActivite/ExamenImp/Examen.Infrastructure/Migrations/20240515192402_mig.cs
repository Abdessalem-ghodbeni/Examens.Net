using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acitivites",
                columns: table => new
                {
                    AcitiviteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zone_Ville = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Zone_Pays = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Prix = table.Column<double>(type: "float", nullable: false),
                    TypeService = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acitivites", x => x.AcitiviteId);
                });

            migrationBuilder.CreateTable(
                name: "Conseillers",
                columns: table => new
                {
                    ConseillerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conseillers", x => x.ConseillerId);
                });

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    PackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NbPlaces = table.Column<int>(type: "int", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duree = table.Column<int>(type: "int", nullable: false),
                    IntitulePack = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.PackId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ConseillerFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Identifiant);
                    table.ForeignKey(
                        name: "FK_Clients_Conseillers_ConseillerFK",
                        column: x => x.ConseillerFK,
                        principalTable: "Conseillers",
                        principalColumn: "ConseillerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcitivitePack",
                columns: table => new
                {
                    AcitiviteListAcitiviteId = table.Column<int>(type: "int", nullable: false),
                    PacksPackId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcitivitePack", x => new { x.AcitiviteListAcitiviteId, x.PacksPackId });
                    table.ForeignKey(
                        name: "FK_AcitivitePack_Acitivites_AcitiviteListAcitiviteId",
                        column: x => x.AcitiviteListAcitiviteId,
                        principalTable: "Acitivites",
                        principalColumn: "AcitiviteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcitivitePack_Packs_PacksPackId",
                        column: x => x.PacksPackId,
                        principalTable: "Packs",
                        principalColumn: "PackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    DateReservation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientFk = table.Column<int>(type: "int", nullable: false),
                    PackFk = table.Column<int>(type: "int", nullable: false),
                    NbPersonnes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => new { x.PackFk, x.ClientFk, x.DateReservation });
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_ClientFk",
                        column: x => x.ClientFk,
                        principalTable: "Clients",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Packs_PackFk",
                        column: x => x.PackFk,
                        principalTable: "Packs",
                        principalColumn: "PackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcitivitePack_PacksPackId",
                table: "AcitivitePack",
                column: "PacksPackId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ConseillerFK",
                table: "Clients",
                column: "ConseillerFK");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ClientFk",
                table: "Reservations",
                column: "ClientFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcitivitePack");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Acitivites");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Packs");

            migrationBuilder.DropTable(
                name: "Conseillers");
        }
    }
}
