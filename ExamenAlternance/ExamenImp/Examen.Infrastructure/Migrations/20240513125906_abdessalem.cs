using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    public partial class abdessalem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ctegories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ctegories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    Identifiant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.Identifiant);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateProd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategorieFk = table.Column<int>(type: "int", nullable: false),
                    TypeProduit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Composition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomLab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.ProduitId);
                    table.ForeignKey(
                        name: "FK_Produits_Ctegories_CategorieFk",
                        column: x => x.CategorieFk,
                        principalTable: "Ctegories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    FournisseursIdentifiant = table.Column<int>(type: "int", nullable: false),
                    ProduitListProduitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => new { x.FournisseursIdentifiant, x.ProduitListProduitId });
                    table.ForeignKey(
                        name: "FK_Facture_Fournisseurs_FournisseursIdentifiant",
                        column: x => x.FournisseursIdentifiant,
                        principalTable: "Fournisseurs",
                        principalColumn: "Identifiant",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facture_Produits_ProduitListProduitId",
                        column: x => x.ProduitListProduitId,
                        principalTable: "Produits",
                        principalColumn: "ProduitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facture_ProduitListProduitId",
                table: "Facture",
                column: "ProduitListProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_CategorieFk",
                table: "Produits",
                column: "CategorieFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Fournisseurs");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Ctegories");
        }
    }
}
