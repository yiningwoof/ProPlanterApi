﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CmdApi.Migrations
{
    public partial class AddMyPlantsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyPlantsItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    WaterFrequency = table.Column<int>(nullable: false),
                    LastWateredDate = table.Column<DateTime>(nullable: false),
                    DatePlanted = table.Column<DateTime>(nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlantsItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyPlantsItems");
        }
    }
}