using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class CreationtableEvolutions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Evolutions",
                columns: new[] { "EvolutionId", "Level", "To" },
                values: new object[,]
                {
                    { 1, 16, "Ivysaur" },
                    { 28, 16, "Kadabra" },
                    { 29, 28, "Machoke" },
                    { 30, 21, "Weepinbell" },
                    { 31, 30, "Tentacruel" },
                    { 32, 25, "Graveler" },
                    { 33, 40, "Rapidash" },
                    { 34, 30, "Magneton" },
                    { 35, 31, "Dodrio" },
                    { 36, 34, "Dewgong" },
                    { 37, 38, "Muk" },
                    { 27, 25, "Poliwhirl" },
                    { 38, 25, "Haunter" },
                    { 40, 28, "Kingler" },
                    { 41, 30, "Electrode" },
                    { 42, 28, "Marowak" },
                    { 43, 35, "Weezing" },
                    { 44, 42, "Rhydon" },
                    { 45, 32, "Seadra" },
                    { 46, 33, "Seaking" },
                    { 47, 20, "Gyarados" },
                    { 48, 40, "Omastar" },
                    { 49, 40, "Kabutops" },
                    { 39, 26, "Hypno" },
                    { 50, 30, "Dragonair" },
                    { 26, 28, "Primeape" },
                    { 24, 28, "Persian" },
                    { 2, 32, "Venusaur" },
                    { 3, 16, "Charmeleon" },
                    { 4, 36, "Charizard" },
                    { 5, 16, "Wartortle" },
                    { 6, 36, "Blastoise" },
                    { 7, 7, "Metapod" },
                    { 8, 10, "Butterfree" },
                    { 9, 7, "Kakuna" },
                    { 10, 10, "Beedrill" },
                    { 11, 18, "Pidgeotto" },
                    { 25, 33, "Golduck" },
                    { 12, 36, "Pidgeot" },
                    { 14, 20, "Fearow" },
                    { 15, 22, "Arbok" },
                    { 16, 22, "Sandslash" }
                });

            migrationBuilder.InsertData(
                table: "Evolutions",
                columns: new[] { "EvolutionId", "Level", "To" },
                values: new object[,]
                {
                    { 17, 16, "Nidorina" },
                    { 18, 16, "Nidorino" },
                    { 19, 22, "Golbat" },
                    { 20, 21, "Gloom" },
                    { 21, 24, "Parasect" },
                    { 22, 31, "Venomoth" },
                    { 23, 26, "Dugtrio" },
                    { 13, 20, "Raticate" },
                    { 51, 55, "Dragonite" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evolutions");
        }
    }
}
