using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class créationdelatablevaliationss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Validation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeValidateurId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DemandeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateValidation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurCreation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UtilisateurModification = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstActif = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Validation_Demande_DemandeId",
                        column: x => x.DemandeId,
                        principalTable: "Demande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Validation_Employes_EmployeValidateurId",
                        column: x => x.EmployeValidateurId,
                        principalTable: "Employes",
                        principalColumn: "Id"//,
                        /*onDelete: ReferentialAction.Cascade*/);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Validation_DemandeId",
                table: "Validation",
                column: "DemandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Validation_EmployeValidateurId",
                table: "Validation",
                column: "EmployeValidateurId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Validation");
        }
    }
}
