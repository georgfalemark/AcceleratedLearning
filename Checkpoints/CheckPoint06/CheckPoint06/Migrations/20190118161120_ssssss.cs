using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint06.Migrations
{
    public partial class ssssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCans",
                table: "spaceShips");

            migrationBuilder.DropColumn(
                name: "PackDate",
                table: "spaceShips");

            migrationBuilder.CreateTable(
                name: "raviolis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberOfCans = table.Column<int>(nullable: false),
                    PackDate = table.Column<string>(nullable: true),
                    SpaceShipId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raviolis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_raviolis_spaceShips_SpaceShipId",
                        column: x => x.SpaceShipId,
                        principalTable: "spaceShips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_raviolis_SpaceShipId",
                table: "raviolis",
                column: "SpaceShipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "raviolis");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfCans",
                table: "spaceShips",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PackDate",
                table: "spaceShips",
                nullable: true);
        }
    }
}
