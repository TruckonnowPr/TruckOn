using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _10052020v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "Dispatchers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "key",
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
    }
}
