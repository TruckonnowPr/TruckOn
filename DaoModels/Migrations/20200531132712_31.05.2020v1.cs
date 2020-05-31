using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _31052020v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlcoholTendency",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrivingSkills",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrugTendency",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EldKnowledge",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "English",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCompany",
                table: "DriverReports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentHandling",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnedEquipmen",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Terminated",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkingEfficiency",
                table: "DriverReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlcoholTendency",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "DrivingSkills",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "DrugTendency",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "EldKnowledge",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "English",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "IdCompany",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "PaymentHandling",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "ReturnedEquipmen",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "Terminated",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "WorkingEfficiency",
                table: "DriverReports");
        }
    }
}
