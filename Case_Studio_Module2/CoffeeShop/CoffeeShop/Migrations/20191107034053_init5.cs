using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeShop.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Table_TableID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Bill_BillId",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetail_Drinks_DrinkId",
                table: "BillDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Drinks_DrinkId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Table_TableId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetail",
                table: "BillDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bill",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_TableID",
                table: "Bill");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Tables");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "BillDetail",
                newName: "BillDetails");

            migrationBuilder.RenameTable(
                name: "Bill",
                newName: "Bills");

            migrationBuilder.RenameColumn(
                name: "TableID",
                table: "Tables",
                newName: "TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_TableId",
                table: "Orders",
                newName: "IX_Orders_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DrinkId",
                table: "Orders",
                newName: "IX_Orders_DrinkId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetail_DrinkId",
                table: "BillDetails",
                newName: "IX_BillDetails_DrinkId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetail_BillId",
                table: "BillDetails",
                newName: "IX_BillDetails_BillId");

            migrationBuilder.RenameColumn(
                name: "TableID",
                table: "Bills",
                newName: "TableId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "TableId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails",
                column: "BillDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bills",
                table: "Bills",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_TableId",
                table: "Bills",
                column: "TableId",
                unique: true,
                filter: "[TableId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_BillId",
                table: "BillDetails",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Drinks_DrinkId",
                table: "BillDetails",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Tables_TableId",
                table: "Bills",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Drinks_DrinkId",
                table: "Orders",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_BillId",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Drinks_DrinkId",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Tables_TableId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Drinks_DrinkId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Tables_TableId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bills",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_TableId",
                table: "Bills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillDetails",
                table: "BillDetails");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Table");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Bills",
                newName: "Bill");

            migrationBuilder.RenameTable(
                name: "BillDetails",
                newName: "BillDetail");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Table",
                newName: "TableID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_TableId",
                table: "Order",
                newName: "IX_Order_TableId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DrinkId",
                table: "Order",
                newName: "IX_Order_DrinkId");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Bill",
                newName: "TableID");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetails_DrinkId",
                table: "BillDetail",
                newName: "IX_BillDetail_DrinkId");

            migrationBuilder.RenameIndex(
                name: "IX_BillDetails_BillId",
                table: "BillDetail",
                newName: "IX_BillDetail_BillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "TableID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bill",
                table: "Bill",
                column: "BillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillDetail",
                table: "BillDetail",
                column: "BillDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_TableID",
                table: "Bill",
                column: "TableID",
                unique: true,
                filter: "[TableID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Table_TableID",
                table: "Bill",
                column: "TableID",
                principalTable: "Table",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Bill_BillId",
                table: "BillDetail",
                column: "BillId",
                principalTable: "Bill",
                principalColumn: "BillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetail_Drinks_DrinkId",
                table: "BillDetail",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Drinks_DrinkId",
                table: "Order",
                column: "DrinkId",
                principalTable: "Drinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Table_TableId",
                table: "Order",
                column: "TableId",
                principalTable: "Table",
                principalColumn: "TableID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
