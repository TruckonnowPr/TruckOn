using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _12052020v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NamePaterns_TransportVehicles_TransportVehicleId",
                table: "NamePaterns");

            migrationBuilder.DropIndex(
                name: "IX_NamePaterns_TransportVehicleId",
                table: "NamePaterns");

            migrationBuilder.DropColumn(
                name: "TransportVehicleId",
                table: "NamePaterns");

            migrationBuilder.AddColumn<bool>(
                name: "IsUsed",
                table: "Layouts",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Layouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUsed",
                table: "Layouts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Layouts");

            migrationBuilder.AddColumn<int>(
                name: "TransportVehicleId",
                table: "NamePaterns",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NamePaterns_TransportVehicleId",
                table: "NamePaterns",
                column: "TransportVehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_NamePaterns_TransportVehicles_TransportVehicleId",
                table: "NamePaterns",
                column: "TransportVehicleId",
                principalTable: "TransportVehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
