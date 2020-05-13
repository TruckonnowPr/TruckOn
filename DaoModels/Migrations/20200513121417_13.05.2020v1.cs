using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DaoModels.Migrations
{
    public partial class _13052020v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileSettingId",
                table: "TransportVehicles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProfileSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeTransportVehikle = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSettings", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportVehicles_ProfileSettings_ProfileSettingId",
                table: "TransportVehicles");

            migrationBuilder.DropTable(
                name: "ProfileSettings");

            migrationBuilder.DropIndex(
                name: "IX_TransportVehicles_ProfileSettingId",
                table: "TransportVehicles");

            migrationBuilder.DropColumn(
                name: "ProfileSettingId",
                table: "TransportVehicles");
        }
    }
}
