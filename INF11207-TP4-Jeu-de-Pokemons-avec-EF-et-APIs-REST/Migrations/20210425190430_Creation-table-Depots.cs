using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class CreationtableDepots : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepotId",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Depots",
                columns: table => new
                {
                    DepotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DresseurId = table.Column<int>(type: "int", nullable: false),
                    IndexPokemonsEquipesSerialises = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depots", x => x.DepotId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depots");

            migrationBuilder.DropColumn(
                name: "DepotId",
                table: "Pokemons");
        }
    }
}
