using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShop.Migrations
{
    public partial class init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Tables_TableId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Table");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Table_TableId",
                table: "Bills",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Table_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Table_TableId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Table_TableId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Tables_TableId",
                table: "Bills",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
