using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AraujosPokedex.Database.Migrations
{
    /// <inheritdoc />
    public partial class CreatedPokemonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Pokemons",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Nickname = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Region = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    PrimaryType = table.Column<string>(type: "text", nullable: false),
                    SecondaryType = table.Column<string>(type: "text", nullable: true),
                    IsOwned = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    DateCaught = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons",
                schema: "dbo");
        }
    }
}
