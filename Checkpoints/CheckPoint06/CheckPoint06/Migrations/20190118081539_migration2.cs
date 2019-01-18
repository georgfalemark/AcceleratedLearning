using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint06.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfCans",
                table: "spaceShips",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PackDate",
                table: "spaceShips",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCans",
                table: "spaceShips");

            migrationBuilder.DropColumn(
                name: "PackDate",
                table: "spaceShips");
        }
    }
}
