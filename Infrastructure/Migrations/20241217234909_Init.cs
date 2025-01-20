using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Prenom = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Telephone = table.Column<string>(type: "Varchar(15)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurCreation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurModification = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fonction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Code = table.Column<string>(type: "Varchar(20)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurCreation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurModification = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fonction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Libelle = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Code = table.Column<string>(type: "Varchar(20)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurCreation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurModification = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeFonction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FonctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurCreation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurModification = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeFonction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeFonction_Employes_EmployeId",
                        column: x => x.EmployeId,
                        principalTable: "Employes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeFonction_Fonction_FonctionId",
                        column: x => x.FonctionId,
                        principalTable: "Fonction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeFonction_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeFonction_EmployeId",
                table: "EmployeFonction",
                column: "EmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeFonction_FonctionId",
                table: "EmployeFonction",
                column: "FonctionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeFonction_ServiceId",
                table: "EmployeFonction",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeFonction");

            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "Fonction");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
