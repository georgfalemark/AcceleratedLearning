using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint06.Migrations
{
    public partial class sss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ravioliId",
                table: "spaceShips",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_spaceShips_ravioliId",
                table: "spaceShips",
                column: "ravioliId");

            migrationBuilder.AddForeignKey(
                name: "FK_spaceShips_raviolis_ravioliId",
                table: "spaceShips",
                column: "ravioliId",
                principalTable: "raviolis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_spaceShips_raviolis_ravioliId",
                table: "spaceShips");

            migrationBuilder.DropIndex(
                name: "IX_spaceShips_ravioliId",
                table: "spaceShips");

            migrationBuilder.DropColumn(
                name: "ravioliId",
                table: "spaceShips");
        }
    }
}
