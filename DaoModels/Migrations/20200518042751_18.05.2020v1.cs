using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _18052020v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportVehicles_ProfileSettings_ProfileSettingId",
                table: "TransportVehicles");

            migrationBuilder.DropIndex(
                name: "IX_TransportVehicles_ProfileSettingId",
                table: "TransportVehicles");

            migrationBuilder.DropColumn(
                name: "ProfileSettingId",
                table: "TransportVehicles");

            migrationBuilder.AddColumn<int>(
                name: "IdTr",
                table: "ProfileSettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransportVehicleId",
                table: "ProfileSettings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfileSettings_TransportVehicleId",
                table: "ProfileSettings",
                column: "TransportVehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileSettings_TransportVehicles_TransportVehicleId",
                table: "ProfileSettings",
                column: "TransportVehicleId",
                principalTable: "TransportVehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileSettings_TransportVehicles_TransportVehicleId",
                table: "ProfileSettings");

            migrationBuilder.DropIndex(
                name: "IX_ProfileSettings_TransportVehicleId",
                table: "ProfileSettings");

            migrationBuilder.DropColumn(
                name: "IdTr",
                table: "ProfileSettings");

            migrationBuilder.DropColumn(
                name: "TransportVehicleId",
                table: "ProfileSettings");

            migrationBuilder.AddColumn<int>(
                name: "ProfileSettingId",
                table: "TransportVehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportVehicles_ProfileSettingId",
                table: "TransportVehicles",
                column: "ProfileSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportVehicles_ProfileSettings_ProfileSettingId",
                table: "TransportVehicles",
                column: "ProfileSettingId",
                principalTable: "ProfileSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
