using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class y : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuoteTypeId",
                table: "Samurais");

            migrationBuilder.AddColumn<int>(
                name: "SamuraiId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes",
                column: "SamuraiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes",
                column: "SamuraiId",
                principalTable: "Samurais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Samurais_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_SamuraiId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "SamuraiId",
                table: "Quotes");

            migrationBuilder.AddColumn<int>(
                name: "QuoteTypeId",
                table: "Samurais",
                nullable: false,
                defaultValue: 0);
        }
    }
}
