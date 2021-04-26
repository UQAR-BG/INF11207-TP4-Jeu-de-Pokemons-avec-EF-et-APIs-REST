using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Ajoutpremierejaugevie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HealthGauges",
                columns: new[] { "GaugeId", "MaxValue", "Value" },
                values: new object[] { 1, 50, 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HealthGauges",
                keyColumn: "GaugeId",
                keyValue: 1);
        }
    }
}
