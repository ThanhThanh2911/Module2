using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyTruongMamNon.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiemDanhs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Morning = table.Column<bool>(nullable: false),
                    Afternoon = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiemDanhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhuHuynhs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenPhuHuynh = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuHuynhs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Childrens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    PhuHuynhId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Childrens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Childrens_PhuHuynhs_PhuHuynhId",
                        column: x => x.PhuHuynhId,
                        principalTable: "PhuHuynhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChildrenDiemDanhs",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(nullable: false),
                    DiemDanhId = table.Column<int>(nullable: false),
                    NgayId = table.Column<int>(nullable: false),
                    Time = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildrenDiemDanhs", x => new { x.ChildrenId, x.DiemDanhId, x.NgayId });
                    table.ForeignKey(
                        name: "FK_ChildrenDiemDanhs_Childrens_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Childrens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChildrenDiemDanhs_DiemDanhs_DiemDanhId",
                        column: x => x.DiemDanhId,
                        principalTable: "DiemDanhs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChildrenDiemDanhs_DiemDanhId",
                table: "ChildrenDiemDanhs",
                column: "DiemDanhId");

            migrationBuilder.CreateIndex(
                name: "IX_Childrens_PhuHuynhId",
                table: "Childrens",
                column: "PhuHuynhId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildrenDiemDanhs");

            migrationBuilder.DropTable(
                name: "Childrens");

            migrationBuilder.DropTable(
                name: "DiemDanhs");

            migrationBuilder.DropTable(
                name: "PhuHuynhs");
        }
    }
}
