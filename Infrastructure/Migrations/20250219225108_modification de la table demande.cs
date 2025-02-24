using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modificationdelatabledemande : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demande_EmployeFonction_EmployeFonctionId",
                table: "Demande");

            migrationBuilder.RenameColumn(
                name: "EmployeFonctionId",
                table: "Demande",
                newName: "EmployeId");

            migrationBuilder.RenameIndex(
                name: "IX_Demande_EmployeFonctionId",
                table: "Demande",
                newName: "IX_Demande_EmployeId");

            migrationBuilder.AddColumn<string>(
                name: "Commentaire",
                table: "Demande",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateDebut",
                table: "Demande",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateFin",
                table: "Demande",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddForeignKey(
                name: "FK_Demande_Employes_EmployeId",
                table: "Demande",
                column: "EmployeId",
                principalTable: "Employes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Demande_Employes_EmployeId",
                table: "Demande");

            migrationBuilder.DropColumn(
                name: "Commentaire",
                table: "Demande");

            migrationBuilder.DropColumn(
                name: "DateDebut",
                table: "Demande");

            migrationBuilder.DropColumn(
                name: "DateFin",
                table: "Demande");

            migrationBuilder.RenameColumn(
                name: "EmployeId",
                table: "Demande",
                newName: "EmployeFonctionId");

            migrationBuilder.RenameIndex(
                name: "IX_Demande_EmployeId",
                table: "Demande",
                newName: "IX_Demande_EmployeFonctionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Demande_EmployeFonction_EmployeFonctionId",
                table: "Demande",
                column: "EmployeFonctionId",
                principalTable: "EmployeFonction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
