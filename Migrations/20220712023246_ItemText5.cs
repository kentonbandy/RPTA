using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPTA.Migrations
{
    public partial class ItemText5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Character");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
