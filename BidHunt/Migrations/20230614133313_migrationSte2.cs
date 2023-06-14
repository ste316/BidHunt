using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BidHunt.Migrations
{
    /// <inheritdoc />
    public partial class migrationSte2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MetodoPagamento_Metodo_pagamentoId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Metodo_pagamentoId",
                table: "Users",
                newName: "MetodoPagamentoRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Metodo_pagamentoId",
                table: "Users",
                newName: "IX_Users_MetodoPagamentoRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MetodoPagamento_MetodoPagamentoRefId",
                table: "Users",
                column: "MetodoPagamentoRefId",
                principalTable: "MetodoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MetodoPagamento_MetodoPagamentoRefId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "MetodoPagamentoRefId",
                table: "Users",
                newName: "Metodo_pagamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_MetodoPagamentoRefId",
                table: "Users",
                newName: "IX_Users_Metodo_pagamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MetodoPagamento_Metodo_pagamentoId",
                table: "Users",
                column: "Metodo_pagamentoId",
                principalTable: "MetodoPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
