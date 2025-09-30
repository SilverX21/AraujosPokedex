using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AraujosPokedex.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedTypesTableAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Types",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 2, "Fire" },
                    { 3, "Water" },
                    { 4, "Grass" },
                    { 5, "Electric" },
                    { 6, "Psychic" },
                    { 7, "Ice" },
                    { 8, "Dragon" },
                    { 9, "Dark" },
                    { 10, "Fairy" },
                    { 11, "Fighting" },
                    { 12, "Flying" },
                    { 13, "Poison" },
                    { 14, "Ground" },
                    { 15, "Rock" },
                    { 16, "Bug" },
                    { 17, "Ghost" },
                    { 18, "Steel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Types",
                schema: "dbo");
        }
    }
}
