using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManagement.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QueQuans",
                columns: table => new
                {
                    QueQuanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueQuans", x => x.QueQuanId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ho = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    QueQuanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_QueQuans_QueQuanId",
                        column: x => x.QueQuanId,
                        principalTable: "QueQuans",
                        principalColumn: "QueQuanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_QueQuanId",
                table: "Contacts",
                column: "QueQuanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "QueQuans");
        }
    }
}
