using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tabledemande : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Demande",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    EmployeFonctionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeDemande = table.Column<int>(type: "int", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurCreation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurModification = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demande", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Demande_EmployeFonction_EmployeFonctionId",
                        column: x => x.EmployeFonctionId,
                        principalTable: "EmployeFonction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Demande_EmployeFonctionId",
                table: "Demande",
                column: "EmployeFonctionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demande");
        }
    }
}
