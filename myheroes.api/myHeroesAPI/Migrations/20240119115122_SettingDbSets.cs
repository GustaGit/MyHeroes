using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class SettingDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HeroisSuperpoderes",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    SuperpowerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroisSuperpoderes", x => new { x.HeroId, x.SuperpowerId });
                    table.ForeignKey(
                        name: "FK_HeroisSuperpoderes_Herois_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroisSuperpoderes_Superpoderes_SuperpowerId",
                        column: x => x.SuperpowerId,
                        principalTable: "Superpoderes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroisSuperpoderes_SuperpowerId",
                table: "HeroisSuperpoderes",
                column: "SuperpowerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroisSuperpoderes");
        }
    }
}
