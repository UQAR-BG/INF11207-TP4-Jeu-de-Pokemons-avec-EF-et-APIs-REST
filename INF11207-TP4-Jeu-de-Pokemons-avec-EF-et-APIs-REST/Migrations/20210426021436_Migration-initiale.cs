using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Migrationinitiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attaques",
                columns: table => new
                {
                    AttaqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Damage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attaques", x => x.AttaqueId);
                });

            migrationBuilder.CreateTable(
                name: "Correspondances",
                columns: table => new
                {
                    CorrespondanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorrespondancesSerialisee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Correspondances", x => x.CorrespondanceId);
                });

            migrationBuilder.CreateTable(
                name: "Efficacites",
                columns: table => new
                {
                    EfficaciteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attack = table.Column<int>(type: "int", nullable: false),
                    Defend = table.Column<int>(type: "int", nullable: false),
                    Effectiveness = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Efficacites", x => x.EfficaciteId);
                });

            migrationBuilder.CreateTable(
                name: "Evolutions",
                columns: table => new
                {
                    EvolutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolutions", x => x.EvolutionId);
                });

            migrationBuilder.CreateTable(
                name: "HealthGauges",
                columns: table => new
                {
                    GaugeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    MaxValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthGauges", x => x.GaugeId);
                });

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

            migrationBuilder.CreateTable(
                name: "XpGauges",
                columns: table => new
                {
                    GaugeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    MaxValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XpGauges", x => x.GaugeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attaques");

            migrationBuilder.DropTable(
                name: "Correspondances");

            migrationBuilder.DropTable(
                name: "Efficacites");

            migrationBuilder.DropTable(
                name: "Evolutions");

            migrationBuilder.DropTable(
                name: "HealthGauges");

            migrationBuilder.DropTable(
                name: "Statistiques");

            migrationBuilder.DropTable(
                name: "XpGauges");
        }
    }
}
