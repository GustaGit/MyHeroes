using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myHeroesAPI.Migrations
{
    public partial class RelationsAdjustNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroModelSuperPowers");

            migrationBuilder.DropTable(
                name: "Hero");

            migrationBuilder.DropTable(
                name: "SuperPowers");

            migrationBuilder.CreateTable(
                name: "Herois",
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
                    table.PrimaryKey("PK_Herois", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Superpoderes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Superpoder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpoderes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroSuperpower",
                columns: table => new
                {
                    HeroId = table.Column<int>(type: "int", nullable: false),
                    SuperpowersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSuperpower", x => new { x.HeroId, x.SuperpowersId });
                    table.ForeignKey(
                        name: "FK_HeroSuperpower_Herois_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Herois",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HeroSuperpower_Superpoderes_SuperpowersId",
                        column: x => x.SuperpowersId,
                        principalTable: "Superpoderes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeroSuperpower_SuperpowersId",
                table: "HeroSuperpower",
                column: "SuperpowersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HeroSuperpower");

            migrationBuilder.DropTable(
                name: "Herois");

            migrationBuilder.DropTable(
                name: "Superpoderes");

            migrationBuilder.CreateTable(
                name: "Hero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    NomeHeroi = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
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
                    Descricao = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Superpoder = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPowers", x => x.Id);
                });

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
    }
}
