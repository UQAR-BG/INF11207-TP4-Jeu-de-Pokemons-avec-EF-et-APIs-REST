using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class CreationtableCorrespondances : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Correspondances",
                columns: new[] { "CorrespondanceId", "CorrespondancesSerialisee" },
                values: new object[] { 1, "{\r\n  \"1\": [\r\n    1\r\n  ],\r\n  \"2\": [\r\n    2,3,4,5\r\n  ],\r\n  \"3\": [\r\n    6,7,8\r\n  ],\r\n  \"4\": [\r\n    9,10\r\n  ],\r\n  \"5\": [\r\n    11,12\r\n  ],\r\n  \"6\": [\r\n    13,14,15\r\n  ],\r\n  \"7\": [\r\n    16\r\n  ],\r\n  \"9\": [\r\n    17,18,19,20\r\n  ],\r\n  \"10\": [\r\n    21,22,23,24,25\r\n  ],\r\n  \"11\": [\r\n    26,27,28\r\n  ],\r\n  \"12\": [\r\n    29,30,31,32,33,34,35\r\n  ],\r\n  \"13\": [\r\n    36,37,38\r\n  ],\r\n  \"14\": [\r\n    39,40\r\n  ],\r\n  \"15\": [\r\n    41,42,43,44,45\r\n  ],\r\n  \"16\": [\r\n    46,47,48,49,50\r\n  ],\r\n  \"17\": [\r\n    51,52,53,54,55,56,57,58,59,60\r\n  ],\r\n  \"18\": [\r\n    61,62,63,64,65\r\n  ],\r\n  \"19\": [\r\n    66,67,68,69,70\r\n  ],\r\n  \"20\": [\r\n    71,72,73,74,75,76\r\n  ],\r\n  \"22\": [\r\n    77,78,79,80\r\n  ],\r\n  \"23\": [\r\n    81,82,83,84\r\n  ],\r\n  \"24\": [\r\n    85,86,87\r\n  ],\r\n  \"25\": [\r\n    88,89,90,91,92\r\n  ],\r\n  \"26\": [\r\n    93,94,95\r\n  ],\r\n  \"27\": [\r\n    96,97,98,99,100\r\n  ],\r\n  \"28\": [\r\n    101,102,103,104,105\r\n  ],\r\n  \"29\": [\r\n    106,107,108,109,110,111,112\r\n  ],\r\n  \"30\": [\r\n    113,114,115\r\n  ],\r\n  \"31\": [\r\n    116,117,118,119,120\r\n  ],\r\n  \"32\": [\r\n    121,122\r\n  ],\r\n  \"33\": [\r\n    123,124,125\r\n  ],\r\n  \"34\": [\r\n    126,127,128,129,130,131,132\r\n  ],\r\n  \"35\": [\r\n    133,134,135,136\r\n  ],\r\n  \"36\": [\r\n    137,138\r\n  ],\r\n  \"37\": [\r\n    139,140,141,142\r\n  ],\r\n  \"38\": [\r\n    143,144,145\r\n  ],\r\n  \"39\": [\r\n    146,147,148\r\n  ],\r\n  \"40\": [\r\n    149,150,151\r\n  ]\r\n}" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Correspondances");
        }
    }
}
