using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuiviCompresseur.Gestion.Responsable.Data.Migrations
{
    public partial class tet1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filiales",
                columns: table => new
                {
                    FilialeID = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiales", x => x.FilialeID);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    UtilisateurID = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Mail_Lotus = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: false),
                    MotDePasse = table.Column<string>(nullable: false),
                    Date_Ajout = table.Column<DateTime>(nullable: false),
                    FilialeID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.UtilisateurID);
                    table.ForeignKey(
                        name: "FK_Utilisateurs_Filiales_FilialeID",
                        column: x => x.FilialeID,
                        principalTable: "Filiales",
                        principalColumn: "FilialeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateurs_FilialeID",
                table: "Utilisateurs",
                column: "FilialeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Filiales");
        }
    }
}
