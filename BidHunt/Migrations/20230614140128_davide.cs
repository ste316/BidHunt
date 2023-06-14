using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BidHunt.Migrations
{
    /// <inheritdoc />
    public partial class davide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "offerte",
                columns: table => new
                {
                    id_offerta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    offerta = table.Column<float>(type: "real", nullable: false),
                    fk_asta_id = table.Column<int>(type: "int", nullable: false),
                    fk_utente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offerte", x => x.id_offerta);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "offerte");
        }
    }
}
