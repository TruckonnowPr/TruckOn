using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _08062020v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipping_Drivers_DriverrId",
                table: "Shipping");

            migrationBuilder.DropIndex(
                name: "IX_Shipping_DriverrId",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "Driver",
                table: "Shipping");

            migrationBuilder.DropColumn(
                name: "DriverrId",
                table: "Shipping");

            migrationBuilder.AddColumn<int>(
                name: "IdDriver",
                table: "Shipping",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDriver",
                table: "Shipping");

            migrationBuilder.AddColumn<string>(
                name: "Driver",
                table: "Shipping",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DriverrId",
                table: "Shipping",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shipping_DriverrId",
                table: "Shipping",
                column: "DriverrId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipping_Drivers_DriverrId",
                table: "Shipping",
                column: "DriverrId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
