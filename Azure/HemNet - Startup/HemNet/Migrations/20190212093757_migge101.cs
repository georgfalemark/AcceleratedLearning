﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HemNet.Migrations
{
    public partial class migge101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Apartments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Apartments");
        }
    }
}