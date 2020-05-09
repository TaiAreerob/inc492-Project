using Microsoft.EntityFrameworkCore.Migrations;
using PM2HAHA.Models;
using System;
namespace PM2HAHA.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MstDataRaw",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    aqi = table.Column<int>(nullable: true),
                    idx = table.Column<int>(nullable: true),
                    city = table.Column<string>(nullable: true, maxLength: 255),
                    longitude = table.Column<decimal>(nullable: true),
                    latitude = table.Column<decimal>(nullable: true),
                    co = table.Column<decimal>(nullable: true),
                    h = table.Column<int>(nullable: true),
                    no2 = table.Column<decimal>(nullable: true),
                    o3 = table.Column<decimal>(nullable: true),
                    p = table.Column<decimal>(nullable: true),
                    pm25 = table.Column<int>(nullable: true),
                    pm10 = table.Column<int>(nullable: true),
                    so2 = table.Column<decimal>(nullable: true),
                    t = table.Column<decimal>(nullable: true),
                    w = table.Column<decimal>(nullable: true),
                    time = table.Column<DateTime>( nullable: false),
                    CreateAt = table.Column<DateTime>( nullable: false),
                    UploadAt = table.Column<DateTime>( nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MstDataRaw", x => x.id);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MstDataRaw"
                );
        }
    }
}
