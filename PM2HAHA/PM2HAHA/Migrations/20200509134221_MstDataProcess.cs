using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PM2HAHA.Migrations
{
    public partial class MstDataProcess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "MstDataProcess",
               columns: table => new
               {
                   id = table.Column<Guid>(nullable: false),
                   time = table.Column<int>(nullable: true),
                   pm25 = table.Column<int>(nullable: true),
                   pm10 = table.Column<string>(nullable: true, maxLength: 255),
                   humidity = table.Column<decimal>(nullable: true),
                   temp = table.Column<decimal>(nullable: true),
                   CreateAt = table.Column<DateTime>(nullable: false),
                   UploadAt = table.Column<DateTime>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_MstDataProcess", x => x.id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
