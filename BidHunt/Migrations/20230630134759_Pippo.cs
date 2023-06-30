using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BidHunt.Migrations
{
    /// <inheritdoc />
    public partial class Pippo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MetodoPagamento_MetodoPagamentoRefId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "MetodoPagamento");

            migrationBuilder.DropIndex(
                name: "IX_Users_MetodoPagamentoRefId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MetodoPagamentoRefId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Fk_prodotto",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "fk_offerta",
                table: "Asta");

            migrationBuilder.RenameColumn(
                name: "offerta",
                table: "offerte",
                newName: "offertaPrezzo");

            migrationBuilder.RenameColumn(
                name: "TempoRimanente",
                table: "Asta",
                newName: "DataInizio");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Asta",
                newName: "Nome_prodotto");

            migrationBuilder.AddColumn<string>(
                name: "PayPal_mail",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AstaId",
                table: "offerte",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFine",
                table: "Asta",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Descrizione_prodotto",
                table: "Asta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Prezzo_iniziale_prod",
                table: "Asta",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Asta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fk_utente_id",
                table: "Asta",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_offerte_AstaId",
                table: "offerte",
                column: "AstaId");

            migrationBuilder.CreateIndex(
                name: "IX_Asta_UserId",
                table: "Asta",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asta_Users_UserId",
                table: "Asta",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_offerte_Asta_AstaId",
                table: "offerte",
                column: "AstaId",
                principalTable: "Asta",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asta_Users_UserId",
                table: "Asta");

            migrationBuilder.DropForeignKey(
                name: "FK_offerte_Asta_AstaId",
                table: "offerte");

            migrationBuilder.DropIndex(
                name: "IX_offerte_AstaId",
                table: "offerte");

            migrationBuilder.DropIndex(
                name: "IX_Asta_UserId",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "PayPal_mail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AstaId",
                table: "offerte");

            migrationBuilder.DropColumn(
                name: "DataFine",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "Descrizione_prodotto",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "Prezzo_iniziale_prod",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "fk_utente_id",
                table: "Asta");

            migrationBuilder.RenameColumn(
                name: "offertaPrezzo",
                table: "offerte",
                newName: "offerta");

            migrationBuilder.RenameColumn(
                name: "Nome_prodotto",
                table: "Asta",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "DataInizio",
                table: "Asta",
                newName: "TempoRimanente");

            migrationBuilder.AddColumn<int>(
                name: "MetodoPagamentoRefId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Fk_prodotto",
                table: "Asta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fk_offerta",
                table: "Asta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MetodoPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anno_scadenza = table.Column<int>(type: "int", nullable: false),
                    Mese_scadenza = table.Column<int>(type: "int", nullable: false),
                    Numero_carta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_MetodoPagamentoRefId",
                table: "Users",
                column: "MetodoPagamentoRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MetodoPagamento_MetodoPagamentoRefId",
                table: "Users",
                column: "MetodoPagamentoRefId",
                principalTable: "MetodoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
