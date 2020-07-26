using Microsoft.EntityFrameworkCore.Migrations;

namespace CmdApi.Migrations
{
    public partial class AddMyPlantsCreatedQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "MyPlantsItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "MyPlantsItems");
        }
    }
}
