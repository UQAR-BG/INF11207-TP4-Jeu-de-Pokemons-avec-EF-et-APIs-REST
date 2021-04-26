using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Ajoutpremierestatistique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Statistiques",
                columns: new[] { "StatistiquesId", "CombatsGagnes", "CombatsPerdus", "CombatsTotal", "MontantAccumule", "MontantDepense", "PokemonsAchetes", "PokemonsDebloques" },
                values: new object[] { 1, 0, 0, 0, 5000, 0, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Statistiques",
                keyColumn: "StatistiquesId",
                keyValue: 1);
        }
    }
}
