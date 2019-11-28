using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShop.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Tables_TableId",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_TableId",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Tables",
                newName: "TableID");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Bills",
                newName: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_TableID",
                table: "Bills",
                column: "TableID",
                unique: true,
                filter: "[TableID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Tables_TableID",
                table: "Bills",
                column: "TableID",
                principalTable: "Tables",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Tables_TableID",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_TableID",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "TableID",
                table: "Tables",
                newName: "TableId");

            migrationBuilder.RenameColumn(
                name: "TableID",
                table: "Bills",
                newName: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_TableId",
                table: "Bills",
                column: "TableId",
                unique: true,
                filter: "[TableId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Tables_TableId",
                table: "Bills",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
