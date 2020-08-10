using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPlanterAPI.Migrations
{
    public partial class AddedMyPlantCreatedQuantitySold : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuantitySold",
                table: "MyPlantItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantitySold",
                table: "MyPlantItems");
        }
    }
}
