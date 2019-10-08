using Microsoft.EntityFrameworkCore.Migrations;

namespace OnePieceApp.Data.Migrations
{
    public partial class demo_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DevilFruits_Characters_CharacterId",
                table: "DevilFruits");

            migrationBuilder.DropIndex(
                name: "IX_DevilFruits_CharacterId",
                table: "DevilFruits");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "DevilFruits");

            migrationBuilder.AddColumn<int>(
                name: "DevilFruitId",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DevilFruitId",
                table: "Characters",
                column: "DevilFruitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_DevilFruits_DevilFruitId",
                table: "Characters",
                column: "DevilFruitId",
                principalTable: "DevilFruits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_DevilFruits_DevilFruitId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_DevilFruitId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "DevilFruitId",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "DevilFruits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DevilFruits_CharacterId",
                table: "DevilFruits",
                column: "CharacterId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DevilFruits_Characters_CharacterId",
                table: "DevilFruits",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
