using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheckPoint06.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PackDate",
                table: "spaceShips",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PackDate",
                table: "spaceShips",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
