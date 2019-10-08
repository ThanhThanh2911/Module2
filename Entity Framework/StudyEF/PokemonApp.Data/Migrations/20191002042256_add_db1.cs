using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonApp.Data.Migrations
{
    public partial class add_db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Battles_BattleID",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_BattleID",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "BattleID",
                table: "Pokemons");

            migrationBuilder.CreateTable(
                name: "PokemonBattle",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false),
                    BattleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonBattle", x => new { x.BattleId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonBattle_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecretIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RealName = table.Column<string>(nullable: true),
                    PokemonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretIdentity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecretIdentity_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonBattle_PokemonId",
                table: "PokemonBattle",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_SecretIdentity_PokemonId",
                table: "SecretIdentity",
                column: "PokemonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonBattle");

            migrationBuilder.DropTable(
                name: "SecretIdentity");

            migrationBuilder.AddColumn<int>(
                name: "BattleID",
                table: "Pokemons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_BattleID",
                table: "Pokemons",
                column: "BattleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Battles_BattleID",
                table: "Pokemons",
                column: "BattleID",
                principalTable: "Battles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
