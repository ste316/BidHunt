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
                name: "AstaId",
                table: "offerte");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Asta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AstaId",
                table: "offerte",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
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
    }
}
