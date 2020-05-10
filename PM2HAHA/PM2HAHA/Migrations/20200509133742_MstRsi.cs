using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PM2HAHA.Migrations
{
    public partial class MstRsi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "MstRsi",
             columns: table => new
             {
                 id = table.Column<Guid>(nullable: false),
                 period = table.Column<int>(nullable: true, maxLength: 255),
                 highlevel = table.Column<int>(nullable: true, maxLength: 255),
                 lowlevel = table.Column<int>(nullable: true, maxLength: 255),
                 usercreate = table.Column<Guid>(nullable: true, maxLength: 255),
                 CreateAt = table.Column<DateTime>(nullable: false),
                 UploadAt = table.Column<DateTime>(nullable: false)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_MstRsi", x => x.id);
             });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "MstRsi"
            );
        }
    }
}
