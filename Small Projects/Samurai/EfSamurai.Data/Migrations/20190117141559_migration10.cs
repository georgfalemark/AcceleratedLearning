using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfSamurai.Data.Migrations
{
    public partial class migration10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HairCutsId",
                table: "Samurais",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuoteTypeId",
                table: "Quotes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HairCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HairCuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuoteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuoteTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samurais_HairCutsId",
                table: "Samurais",
                column: "HairCutsId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_QuoteTypeId",
                table: "Quotes",
                column: "QuoteTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_QuoteTypes_QuoteTypeId",
                table: "Quotes",
                column: "QuoteTypeId",
                principalTable: "QuoteTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Samurais_HairCuts_HairCutsId",
                table: "Samurais",
                column: "HairCutsId",
                principalTable: "HairCuts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_QuoteTypes_QuoteTypeId",
                table: "Quotes");

            migrationBuilder.DropForeignKey(
                name: "FK_Samurais_HairCuts_HairCutsId",
                table: "Samurais");

            migrationBuilder.DropTable(
                name: "HairCuts");

            migrationBuilder.DropTable(
                name: "QuoteTypes");

            migrationBuilder.DropIndex(
                name: "IX_Samurais_HairCutsId",
                table: "Samurais");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_QuoteTypeId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "HairCutsId",
                table: "Samurais");

            migrationBuilder.DropColumn(
                name: "QuoteTypeId",
                table: "Quotes");
        }
    }
}
