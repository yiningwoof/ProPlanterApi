using Microsoft.EntityFrameworkCore.Migrations;

namespace ProPlanterAPI.Migrations
{
    public partial class AddedMyPlantRemovedAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "MyPlantItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "MyPlantItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
