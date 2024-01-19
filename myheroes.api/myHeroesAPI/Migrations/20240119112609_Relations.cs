using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperPowers_Hero_HeroModelId",
                table: "SuperPowers");

            migrationBuilder.DropIndex(
                name: "IX_SuperPowers_HeroModelId",
                table: "SuperPowers");

            migrationBuilder.DropColumn(
                name: "HeroModelId",
                table: "SuperPowers");

            migrationBuilder.CreateTable(
                name: "HeroModelSuperPowers",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    SuperpowersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroModelSuperPowers", x => new { x.HeroId, x.SuperpowersId });
                    table.ForeignKey(
                        name: "FK_HeroModelSuperPowers_Hero_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Hero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroModelSuperPowers_SuperPowers_SuperpowersId",
                        column: x => x.SuperpowersId,
                        principalTable: "SuperPowers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroModelSuperPowers_SuperpowersId",
                table: "HeroModelSuperPowers",
                column: "SuperpowersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroModelSuperPowers");

            migrationBuilder.AddColumn<int>(
                name: "HeroModelId",
                table: "SuperPowers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_HeroModelId",
                table: "SuperPowers",
                column: "HeroModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperPowers_Hero_HeroModelId",
                table: "SuperPowers",
                column: "HeroModelId",
                principalTable: "Hero",
                principalColumn: "Id");
        }
    }
}
