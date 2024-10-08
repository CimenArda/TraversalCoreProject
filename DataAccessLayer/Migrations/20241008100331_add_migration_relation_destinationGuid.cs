using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_migration_relation_destinationGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuidID",
                table: "Destinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_GuidID",
                table: "Destinations",
                column: "GuidID");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guids_GuidID",
                table: "Destinations",
                column: "GuidID",
                principalTable: "Guids",
                principalColumn: "GuidID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guids_GuidID",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_GuidID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "GuidID",
                table: "Destinations");
        }
    }
}
