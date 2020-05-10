using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PM2HAHA.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MstDataRaw",
                columns: new[] {"id", "aqi","idx","city","longitude","latitude","co","h","no2","o3","p","pm25","pm10","so2","t","w","time" ,"CreateAt", "UploadAt" },
                values: new object[] { "c2405911-8e6e-4602-a94c-773985c8658d", "100", "100","bangkok","10.2356","56.987","40.2","8","2.5","6.4","50","49","8","4.1","9.13", "9.13", DateTime.Now, DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
               table: "MstDataProcess",
               columns: new[] { "id", "time", "pm25", "pm10", "humidity", "temp", "CreateAt", "UploadAt" },
               values: new object[] { "c2405911-8e6e-4602-a94c-773985c8658d", "100", "100", "200", "10.2356", "56.987", DateTime.Now, DateTime.Now });

            migrationBuilder.InsertData(
             table: "MstRsi",
             columns: new[] { "id", "period", "highlevel", "lowlevel", "usercreate", "CreateAt", "UploadAt" },
             values: new object[] { "c2405911-8e6e-4602-a94c-773985c8658d", "14", "70", "30", "c2405911-8e6e-4602-a94c-773985c8657d", DateTime.Now, DateTime.Now });

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

