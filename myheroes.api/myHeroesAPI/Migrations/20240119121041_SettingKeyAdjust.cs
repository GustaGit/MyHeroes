using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class SettingKeyAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HeroisSuperpoderes",
                table: "HeroisSuperpoderes");

            migrationBuilder.DropColumn(
                name: "HeroSuperpowerId",
                table: "HeroisSuperpoderes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
