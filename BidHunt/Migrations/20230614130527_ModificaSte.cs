using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BidHunt.Migrations
{
    /// <inheritdoc />
    public partial class ModificaSte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Asta");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Asta",
                newName: "fk_offerta");

            migrationBuilder.AddColumn<string>(
                name: "Cognome",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascita",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Metodo_pagamentoId",
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
                name: "TempoRimanente",
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
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_carta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mese_scadenza = table.Column<int>(type: "int", nullable: false),
                    Anno_scadenza = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodoPagamento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Metodo_pagamentoId",
                table: "Users",
                column: "Metodo_pagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MetodoPagamento_Metodo_pagamentoId",
                table: "Users",
                column: "Metodo_pagamentoId",
                principalTable: "MetodoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MetodoPagamento_Metodo_pagamentoId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "MetodoPagamento");

            migrationBuilder.DropIndex(
                name: "IX_Users_Metodo_pagamentoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Cognome",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DataNascita",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Metodo_pagamentoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Fk_prodotto",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "TempoRimanente",
                table: "Asta");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "fk_offerta",
                table: "Asta",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Asta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
