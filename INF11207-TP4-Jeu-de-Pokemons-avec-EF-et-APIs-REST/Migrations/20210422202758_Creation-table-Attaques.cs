using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class CreationtableAttaques : Migration
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

            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "AttaqueId", "Damage", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 5.4000000000000004, "Vine Whip", 4 },
                    { 91, 4.1500000000000004, "Low Kick", 6 },
                    { 90, 6.6500000000000004, "Low Sweep", 6 },
                    { 89, 3.75, "Karate Chop", 6 },
                    { 88, 15.0, "Cross Chop", 6 },
                    { 87, 6.9000000000000004, "Power Gem", 13 },
                    { 86, 5.5499999999999998, "Night Slash", 14 },
                    { 85, 5.0, "Sucker Punch", 14 },
                    { 84, 5.75, "Mud Bomb", 8 },
                    { 83, 5.5499999999999998, "Mud Slap", 8 },
                    { 82, 5.25, "Psybeam", 11 },
                    { 81, 8.3499999999999996, "Cross Poison", 7 },
                    { 80, 4.8499999999999996, "Ominous Wind", 15 },
                    { 79, 9.5, "Play Rough", 17 },
                    { 78, 10.550000000000001, "Heat Wave", 1 },
                    { 77, 5.75, "Feint Attack", 14 },
                    { 76, 6.5499999999999998, "Dazzling Gleam", 17 },
                    { 75, 10.35, "Moonblast", 17 },
                    { 74, 3.2000000000000002, "Disarming Voice", 17 },
                    { 73, 5.7000000000000002, "Zen Headbutt", 11 },
                    { 72, 6.5, "Pound", 0 },
                    { 71, 12.5, "Megahorn", 12 },
                    { 70, 3.75, "Fury Cutter", 12 },
                    { 69, 5.7000000000000002, "Horn Attack", 0 },
                    { 68, 12.9, "Stone Edge", 13 },
                    { 67, 5.2000000000000002, "Poison Fang", 7 },
                    { 66, 5.1500000000000004, "Bulldoze", 8 },
                    { 65, 11.9, "Earthquake", 8 },
                    { 92, 4.3499999999999996, "Flame Wheel", 1 },
                    { 64, 6.3499999999999996, "Metal Claw", 9 },
                    { 93, 5.9500000000000002, "Fire Fang", 1 },
                    { 95, 5.1500000000000004, "Bubble Beam", 2 },
                    { 122, 4.4500000000000002, "Draining Kiss", 17 },
                    { 121, 6.0, "Dragon Breath", 16 },
                    { 120, 9.0500000000000007, "Dragon Pulse", 16 },
                    { 119, 7.1500000000000004, "Stomp", 0 },
                    { 118, 7.7999999999999998, "Bone Club", 8 },
                    { 117, 5.2999999999999998, "Rock Smash", 6 },
                    { 116, 5.9500000000000002, "Vice Grip", 0 },
                    { 115, 7.5, "Iron Head", 9 },
                    { 114, 5.7999999999999998, "Shadow Claw", 15 },
                    { 113, 5.75, "Sludge", 7 }
                });

            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "AttaqueId", "Damage", "Name", "Type" },
                values: new object[,]
                {
                    { 112, 5.5499999999999998, "Frost Breath", 5 },
                    { 111, 3.2999999999999998, "Icy Wind", 5 },
                    { 110, 5.0, "Lick", 15 },
                    { 109, 5.3499999999999996, "Ice Shard", 5 },
                    { 108, 5.0, "Swift", 0 },
                    { 107, 6.6500000000000004, "Cut", 0 },
                    { 106, 5.3499999999999996, "Magnet Bomb", 9 },
                    { 105, 4.8499999999999996, "Ancient Power", 13 },
                    { 104, 4.4000000000000004, "Rock Throw", 13 },
                    { 103, 9.8000000000000007, "Leaf Blade", 4 },
                    { 102, 4.1500000000000004, "Bullet Punch", 9 },
                    { 101, 6.1500000000000004, "Psycho Cut", 11 },
                    { 100, 7.2999999999999998, "Shadow Ball", 15 },
                    { 99, 7.4000000000000004, "Psyshock", 11 },
                    { 98, 6.4500000000000002, "Ice Punch", 5 },
                    { 97, 7.1500000000000004, "Submission", 6 },
                    { 96, 6.9000000000000004, "Scald", 2 },
                    { 94, 5.4500000000000002, "Bubble", 2 },
                    { 63, 4.4000000000000004, "Rock Tomb", 13 },
                    { 62, 7.7999999999999998, "Rock Slide", 13 },
                    { 61, 5.4500000000000002, "Mud Shot", 8 },
                    { 28, 4.4000000000000004, "Struggle", 0 },
                    { 27, 5.5499999999999998, "Bug Bite", 12 },
                    { 26, 7.7000000000000002, "Flash Cannon", 9 },
                    { 25, 11.85, "Hydro Pump", 2 },
                    { 24, 8.9000000000000004, "Ice Beam", 5 },
                    { 23, 6.0, "Bite", 14 },
                    { 22, 6.0, "Water Gun", 2 },
                    { 21, 5.2999999999999998, "Water Pulse", 2 },
                    { 20, 9.5500000000000007, "Aqua Tail", 2 },
                    { 19, 5.2999999999999998, "Aqua Jet", 2 },
                    { 18, 5.4500000000000002, "Bubble", 2 },
                    { 17, 10.949999999999999, "Dragon Claw", 16 },
                    { 16, 12.199999999999999, "Fire Blast", 1 },
                    { 15, 6.0, "Wing Attack", 10 },
                    { 14, 7.1500000000000004, "Fire Punch", 1 },
                    { 13, 9.5, "Flamethrower", 1 },
                    { 12, 7.1500000000000004, "Flame Burst", 1 },
                    { 11, 4.0499999999999998, "Flame Charge", 1 },
                    { 10, 6.0, "Scratch", 0 },
                    { 9, 4.75, "Ember", 1 },
                    { 8, 10.15, "Petal Blizzard", 4 }
                });

            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "AttaqueId", "Damage", "Name", "Type" },
                values: new object[,]
                {
                    { 7, 12.25, "Solar Beam", 4 },
                    { 6, 5.1500000000000004, "Razor Leaf", 4 },
                    { 5, 12.5, "Power Whip", 4 },
                    { 4, 8.3499999999999996, "Seed Bomb", 4 },
                    { 3, 10.6, "Sludge Bomb", 7 },
                    { 2, 5.4500000000000002, "Tackle", 0 },
                    { 29, 4.9500000000000002, "Confusion", 11 },
                    { 30, 8.8000000000000007, "Bug Buzz", 12 },
                    { 31, 9.8000000000000007, "Psychic", 11 },
                    { 32, 7.25, "Signal Beam", 12 },
                    { 60, 8.3499999999999996, "Thunder Punch", 3 },
                    { 59, 9.4000000000000004, "Brick Break", 6 },
                    { 58, 5.0, "Spark", 3 },
                    { 57, 11.65, "Thunder", 3 },
                    { 56, 10.199999999999999, "Thunderbolt", 3 },
                    { 55, 7.0, "Discharge", 3 },
                    { 54, 4.1500000000000004, "Thunder Shock", 3 },
                    { 53, 10.300000000000001, "Sludge Wave", 7 },
                    { 52, 6.4500000000000002, "Dark Pulse", 14 },
                    { 51, 10.85, "Gunk Shot", 7 },
                    { 50, 3.1499999999999999, "Wrap", 0 },
                    { 49, 4.75, "Acid", 7 },
                    { 48, 7.3499999999999996, "Drill Run", 8 },
                    { 123, 0.0, "Splash", 2 },
                    { 47, 7.4000000000000004, "Drill Peck", 10 },
                    { 45, 12.0, "Hyper Beam", 0 },
                    { 44, 12.800000000000001, "Body Slam", 0 },
                    { 43, 8.3499999999999996, "Hyper Fang", 0 },
                    { 42, 6.0499999999999998, "Dig", 8 },
                    { 41, 12.5, "Hurricane", 10 },
                    { 40, 5.6500000000000004, "Steel Wing", 9 },
                    { 39, 4.5499999999999998, "Air Cutter", 10 },
                    { 38, 4.6500000000000004, "Twister", 16 },
                    { 37, 3.75, "Quick Attack", 0 },
                    { 36, 8.3499999999999996, "X-Scissor", 12 },
                    { 35, 5.1500000000000004, "Aerial Ace", 10 },
                    { 34, 5.7000000000000002, "Poison Jab", 7 },
                    { 33, 5.1500000000000004, "Poison Sting", 7 },
                    { 46, 4.3499999999999996, "Peck", 10 },
                    { 124, 5.2000000000000002, "Brine", 2 },
                    { 125, 12.80000000000000, "Blizzard", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attaques");
        }
    }
}
