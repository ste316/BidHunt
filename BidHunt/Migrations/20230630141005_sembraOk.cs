using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BidHunt.Migrations
{
    /// <inheritdoc />
    public partial class sembraOk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome_prodotto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione_prodotto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezzo_iniziale_prod = table.Column<float>(type: "real", nullable: false),
                    fk_utente_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "offerte",
                columns: table => new
                {
                    id_offerta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: true),
                    offertaPrezzo = table.Column<float>(type: "real", nullable: false),
                    fk_asta_id = table.Column<int>(type: "int", nullable: false),
                    fk_utente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offerte", x => x.id_offerta);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayPal_mail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asta");

            migrationBuilder.DropTable(
                name: "offerte");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
