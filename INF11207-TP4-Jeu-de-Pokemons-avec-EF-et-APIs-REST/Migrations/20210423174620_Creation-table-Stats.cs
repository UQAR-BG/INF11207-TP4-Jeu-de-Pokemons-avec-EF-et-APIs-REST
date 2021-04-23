using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class CreationtableStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistiques",
                columns: table => new
                {
                    StatistiquesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontantAccumule = table.Column<int>(type: "int", nullable: false),
                    MontantDepense = table.Column<int>(type: "int", nullable: false),
                    PokemonsAchetes = table.Column<int>(type: "int", nullable: false),
                    PokemonsDebloques = table.Column<int>(type: "int", nullable: false),
                    CombatsTotal = table.Column<int>(type: "int", nullable: false),
                    CombatsGagnes = table.Column<int>(type: "int", nullable: false),
                    CombatsPerdus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistiques", x => x.StatistiquesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistiques");
        }
    }
}
