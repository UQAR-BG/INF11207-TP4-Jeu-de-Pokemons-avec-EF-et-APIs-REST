using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Ajoutattaqueenplus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "AttaqueId", "Damage", "Name", "Type" },
                values: new object[] { 125, 12.800000000000001, "Blizzard", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 125);
        }
    }
}
