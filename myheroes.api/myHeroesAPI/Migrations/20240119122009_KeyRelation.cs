using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class KeyRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_HeroisSuperpoderes_HeroId",
                table: "HeroisSuperpoderes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes",
                columns: new[] { "HeroId", "SuperpowerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes");

            migrationBuilder.CreateIndex(
                name: "IX_HeroisSuperpoderes_HeroId",
                table: "HeroisSuperpoderes",
                column: "HeroId");
        }
    }
}
