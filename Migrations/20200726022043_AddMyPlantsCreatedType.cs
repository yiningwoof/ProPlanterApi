using Microsoft.EntityFrameworkCore.Migrations;

namespace CmdApi.Migrations
{
    public partial class AddMyPlantsCreatedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "MyPlantsItems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "MyPlantsItems");
        }
    }
}
