using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Ajoutpremieresjaugesvie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "XpGauges",
                columns: new[] { "GaugeId", "MaxValue", "Value" },
                values: new object[] { 1, 100, 0 });

            migrationBuilder.InsertData(
                table: "XpGauges",
                columns: new[] { "GaugeId", "MaxValue", "Value" },
                values: new object[] { 2, 100, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "XpGauges",
                keyColumn: "GaugeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "XpGauges",
                keyColumn: "GaugeId",
                keyValue: 2);
        }
    }
}
