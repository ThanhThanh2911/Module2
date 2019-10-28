using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyTruongMamNon.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "NgayId",
                table: "ChildrenDiemDanhs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NgayId",
                table: "ChildrenDiemDanhs",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
