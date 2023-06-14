using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BidHunt.Migrations
{
    /// <inheritdoc />
    public partial class ModificaColonne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Asta");

            migrationBuilder.AddColumn<int>(
                name: "Fk_prodotto",
                table: "Asta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "TempoRimanente",
                table: "Asta",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "fk_offerta",
                table: "Asta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fk_prodotto",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "TempoRimanente",
                table: "Asta");

            migrationBuilder.DropColumn(
                name: "fk_offerta",
                table: "Asta");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Asta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Asta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
