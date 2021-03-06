﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _30082020v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsKey",
                table: "Dispatchers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsKey",
                table: "Dispatchers");
        }
    }
}
