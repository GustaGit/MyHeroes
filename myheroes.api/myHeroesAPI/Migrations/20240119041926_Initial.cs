using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    NomeHeroi = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuperPowers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Superpoder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    HeroModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SuperPowers_Hero_HeroModelId",
                        column: x => x.HeroModelId,
                        principalTable: "Hero",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperPowers_HeroModelId",
                table: "SuperPowers",
                column: "HeroModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperPowers");

            migrationBuilder.DropTable(
                name: "Hero");
        }
    }
}
