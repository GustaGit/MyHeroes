using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class SettingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes");

            migrationBuilder.AddColumn<int>(
                name: "HeroSuperpowerId",
                table: "HeroisSuperpoderes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes",
                column: "HeroSuperpowerId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroisSuperpoderes_HeroId",
                table: "HeroisSuperpoderes",
                column: "HeroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes");

            migrationBuilder.DropIndex(
                name: "IX_HeroisSuperpoderes_HeroId",
                table: "HeroisSuperpoderes");

            migrationBuilder.DropColumn(
                name: "HeroSuperpowerId",
                table: "HeroisSuperpoderes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes",
                columns: new[] { "HeroId", "SuperpowerId" });
        }
    }
}
