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
                 username = table.Column<string>(nullable: true, maxLength: 255),
                 password = table.Column<string>(nullable: true, maxLength: 255),
                 name = table.Column<string>(nullable: true, maxLength: 255),
                 lastname = table.Column<string>(nullable: true, maxLength: 255),
                 phone = table.Column<string>(nullable: true, maxLength: 20),
                 email = table.Column<string>(nullable: true, maxLength: 100),
                 stutus = table.Column<int>(nullable: true),
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
