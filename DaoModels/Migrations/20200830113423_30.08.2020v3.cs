using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _30082020v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsKey",
                table: "Dispatchers");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Dispatchers");

            migrationBuilder.AddColumn<int>(
                name: "DispatcherId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_DispatcherId",
                table: "User",
                column: "DispatcherId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Dispatchers_DispatcherId",
                table: "User",
                column: "DispatcherId",
                principalTable: "Dispatchers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Dispatchers_DispatcherId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_DispatcherId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DispatcherId",
                table: "User");

            migrationBuilder.AddColumn<bool>(
                name: "IsKey",
                table: "Dispatchers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Dispatchers",
                nullable: true);
        }
    }
}
