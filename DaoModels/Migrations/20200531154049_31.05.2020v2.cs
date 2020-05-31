using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _31052020v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DotViolations",
                table: "DriverReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberOfAccidents",
                table: "DriverReports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DotViolations",
                table: "DriverReports");

            migrationBuilder.DropColumn(
                name: "NumberOfAccidents",
                table: "DriverReports");
        }
    }
}
