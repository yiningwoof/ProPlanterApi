using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPlanterAPI.Migrations
{
    public partial class AddedMyPlantCreatedPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "MyPlantItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "MyPlantItems");
        }
    }
}
