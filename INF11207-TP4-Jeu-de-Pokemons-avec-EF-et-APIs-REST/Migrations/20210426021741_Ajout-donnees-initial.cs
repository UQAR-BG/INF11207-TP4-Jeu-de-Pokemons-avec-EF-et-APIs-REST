using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Ajoutdonneesinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { 93, 5.9500000000000002, "Fire Fang", 1 },
                    { 94, 5.4500000000000002, "Bubble", 2 },
                    { 95, 5.1500000000000004, "Bubble Beam", 2 },
                    { 124, 5.2000000000000002, "Brine", 2 },
                    { 123, 0.0, "Splash", 2 },
                    { 122, 4.4500000000000002, "Draining Kiss", 17 },
                    { 121, 6.0, "Dragon Breath", 16 },
                    { 120, 9.0500000000000007, "Dragon Pulse", 16 },
                    { 118, 7.7999999999999998, "Bone Club", 8 },
                    { 117, 5.2999999999999998, "Rock Smash", 6 },
                    { 116, 5.9500000000000002, "Vice Grip", 0 },
                    { 115, 7.5, "Iron Head", 9 },
                    { 114, 5.7999999999999998, "Shadow Claw", 15 }
                });

            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "AttaqueId", "Damage", "Name", "Type" },
                values: new object[,]
                {
                    { 113, 5.75, "Sludge", 7 },
                    { 112, 5.5499999999999998, "Frost Breath", 5 },
                    { 111, 3.2999999999999998, "Icy Wind", 5 },
                    { 64, 6.3499999999999996, "Metal Claw", 9 },
                    { 110, 5.0, "Lick", 15 },
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
                    { 109, 5.3499999999999996, "Ice Shard", 5 },
                    { 63, 4.4000000000000004, "Rock Tomb", 13 },
                    { 119, 7.1500000000000004, "Stomp", 0 },
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
                    { 9, 4.75, "Ember", 1 }
                });

            migrationBuilder.InsertData(
                table: "Attaques",
                columns: new[] { "AttaqueId", "Damage", "Name", "Type" },
                values: new object[,]
                {
                    { 8, 10.15, "Petal Blizzard", 4 },
                    { 7, 12.25, "Solar Beam", 4 },
                    { 6, 5.1500000000000004, "Razor Leaf", 4 },
                    { 5, 12.5, "Power Whip", 4 },
                    { 3, 10.6, "Sludge Bomb", 7 },
                    { 2, 5.4500000000000002, "Tackle", 0 },
                    { 62, 7.7999999999999998, "Rock Slide", 13 },
                    { 29, 4.9500000000000002, "Confusion", 11 },
                    { 30, 8.8000000000000007, "Bug Buzz", 12 },
                    { 4, 8.3499999999999996, "Seed Bomb", 4 },
                    { 32, 7.25, "Signal Beam", 12 },
                    { 31, 9.8000000000000007, "Psychic", 11 },
                    { 59, 9.4000000000000004, "Brick Break", 6 },
                    { 60, 8.3499999999999996, "Thunder Punch", 3 },
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
                    { 47, 7.4000000000000004, "Drill Peck", 10 },
                    { 58, 5.0, "Spark", 3 },
                    { 45, 12.0, "Hyper Beam", 0 },
                    { 46, 4.3499999999999996, "Peck", 10 },
                    { 35, 5.1500000000000004, "Aerial Ace", 10 },
                    { 36, 8.3499999999999996, "X-Scissor", 12 },
                    { 37, 3.75, "Quick Attack", 0 },
                    { 38, 4.6500000000000004, "Twister", 16 },
                    { 34, 5.7000000000000002, "Poison Jab", 7 },
                    { 40, 5.6500000000000004, "Steel Wing", 9 },
                    { 44, 12.800000000000001, "Body Slam", 0 },
                    { 39, 4.5499999999999998, "Air Cutter", 10 },
                    { 43, 8.3499999999999996, "Hyper Fang", 0 },
                    { 33, 5.1500000000000004, "Poison Sting", 7 },
                    { 42, 6.0499999999999998, "Dig", 8 },
                    { 41, 12.5, "Hurricane", 10 }
                });

            migrationBuilder.InsertData(
                table: "Correspondances",
                columns: new[] { "CorrespondanceId", "CorrespondancesSerialisee" },
                values: new object[] { 1, "{\r\n  \"1\": [\r\n    1\r\n  ],\r\n  \"2\": [\r\n    2,3,4,5\r\n  ],\r\n  \"3\": [\r\n    6,7,8\r\n  ],\r\n  \"4\": [\r\n    9,10\r\n  ],\r\n  \"5\": [\r\n    11,12\r\n  ],\r\n  \"6\": [\r\n    13,14,15\r\n  ],\r\n  \"7\": [\r\n    16\r\n  ],\r\n  \"9\": [\r\n    17,18,19,20\r\n  ],\r\n  \"10\": [\r\n    21,22,23,24,25\r\n  ],\r\n  \"11\": [\r\n    26,27,28\r\n  ],\r\n  \"12\": [\r\n    29,30,31,32,33,34,35\r\n  ],\r\n  \"13\": [\r\n    36,37,38\r\n  ],\r\n  \"14\": [\r\n    39,40\r\n  ],\r\n  \"15\": [\r\n    41,42,43,44,45\r\n  ],\r\n  \"16\": [\r\n    46,47,48,49,50\r\n  ],\r\n  \"17\": [\r\n    51,52,53,54,55,56,57,58,59,60\r\n  ],\r\n  \"18\": [\r\n    61,62,63,64,65\r\n  ],\r\n  \"19\": [\r\n    66,67,68,69,70\r\n  ],\r\n  \"20\": [\r\n    71,72,73,74,75,76\r\n  ],\r\n  \"22\": [\r\n    77,78,79,80\r\n  ],\r\n  \"23\": [\r\n    81,82,83,84\r\n  ],\r\n  \"24\": [\r\n    85,86,87\r\n  ],\r\n  \"25\": [\r\n    88,89,90,91,92\r\n  ],\r\n  \"26\": [\r\n    93,94,95\r\n  ],\r\n  \"27\": [\r\n    96,97,98,99,100\r\n  ],\r\n  \"28\": [\r\n    101,102,103,104,105\r\n  ],\r\n  \"29\": [\r\n    106,107,108,109,110,111,112\r\n  ],\r\n  \"30\": [\r\n    113,114,115\r\n  ],\r\n  \"31\": [\r\n    116,117,118,119,120\r\n  ],\r\n  \"32\": [\r\n    121,122\r\n  ],\r\n  \"33\": [\r\n    123,124,125\r\n  ],\r\n  \"34\": [\r\n    126,127,128,129,130,131,132\r\n  ],\r\n  \"35\": [\r\n    133,134,135,136\r\n  ],\r\n  \"36\": [\r\n    137,138\r\n  ],\r\n  \"37\": [\r\n    139,140,141,142\r\n  ],\r\n  \"38\": [\r\n    143,144,145\r\n  ],\r\n  \"39\": [\r\n    146,147,148\r\n  ],\r\n  \"40\": [\r\n    149,150,151\r\n  ]\r\n}" });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[] { 155, 11, 4, 1.0 });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[,]
                {
                    { 146, 10, 11, 1.0 },
                    { 148, 10, 13, 0.5 },
                    { 149, 10, 15, 1.0 },
                    { 150, 10, 16, 1.0 },
                    { 144, 10, 8, 1.0 },
                    { 151, 11, 0, 1.0 },
                    { 152, 11, 1, 1.0 },
                    { 153, 11, 2, 1.0 },
                    { 154, 11, 3, 1.0 },
                    { 145, 10, 10, 1.0 },
                    { 147, 10, 12, 2.0 },
                    { 161, 11, 11, 0.5 },
                    { 157, 11, 6, 2.0 },
                    { 158, 11, 7, 2.0 },
                    { 159, 11, 8, 1.0 },
                    { 160, 11, 10, 1.0 },
                    { 162, 11, 12, 1.0 },
                    { 163, 11, 13, 1.0 },
                    { 164, 11, 15, 1.0 },
                    { 165, 11, 16, 1.0 },
                    { 166, 12, 0, 1.0 },
                    { 167, 12, 1, 0.5 },
                    { 168, 12, 2, 1.0 },
                    { 156, 11, 5, 1.0 },
                    { 143, 10, 7, 1.0 },
                    { 128, 8, 7, 2.0 },
                    { 141, 10, 5, 1.0 },
                    { 116, 7, 11, 1.0 },
                    { 169, 12, 3, 1.0 },
                    { 117, 7, 12, 2.0 },
                    { 118, 7, 13, 0.5 },
                    { 119, 7, 15, 0.5 },
                    { 120, 7, 16, 1.0 },
                    { 121, 8, 0, 1.0 },
                    { 122, 8, 1, 2.0 },
                    { 123, 8, 2, 1.0 },
                    { 124, 8, 3, 2.0 },
                    { 125, 8, 4, 0.5 },
                    { 126, 8, 5, 1.0 },
                    { 127, 8, 6, 1.0 },
                    { 129, 8, 8, 1.0 },
                    { 130, 8, 10, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[,]
                {
                    { 131, 8, 11, 1.0 },
                    { 132, 8, 12, 0.5 },
                    { 133, 8, 13, 2.0 },
                    { 134, 8, 15, 1.0 },
                    { 135, 8, 16, 1.0 },
                    { 136, 10, 0, 1.0 },
                    { 137, 10, 1, 1.0 },
                    { 138, 10, 2, 1.0 },
                    { 139, 10, 3, 0.5 },
                    { 140, 10, 4, 2.0 },
                    { 142, 10, 6, 2.0 },
                    { 170, 12, 4, 2.0 },
                    { 201, 15, 5, 1.0 },
                    { 172, 12, 6, 0.5 },
                    { 203, 15, 7, 1.0 },
                    { 204, 15, 8, 1.0 },
                    { 205, 15, 10, 1.0 },
                    { 206, 15, 11, 0.0 },
                    { 207, 15, 12, 1.0 },
                    { 208, 15, 13, 1.0 },
                    { 209, 15, 15, 2.0 },
                    { 210, 15, 16, 1.0 },
                    { 211, 16, 0, 1.0 },
                    { 212, 16, 1, 1.0 },
                    { 213, 16, 2, 1.0 },
                    { 202, 15, 6, 1.0 },
                    { 214, 16, 3, 1.0 },
                    { 216, 16, 5, 1.0 },
                    { 217, 16, 6, 1.0 },
                    { 218, 16, 7, 1.0 },
                    { 219, 16, 8, 1.0 },
                    { 220, 16, 10, 1.0 },
                    { 221, 16, 11, 1.0 },
                    { 222, 16, 12, 1.0 },
                    { 223, 16, 13, 1.0 },
                    { 224, 16, 15, 1.0 },
                    { 225, 16, 16, 2.0 },
                    { 115, 7, 10, 1.0 },
                    { 215, 16, 4, 1.0 },
                    { 200, 15, 4, 1.0 },
                    { 199, 15, 3, 1.0 },
                    { 198, 15, 2, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[,]
                {
                    { 173, 12, 7, 2.0 },
                    { 174, 12, 8, 1.0 },
                    { 175, 12, 10, 0.5 },
                    { 176, 12, 11, 2.0 },
                    { 177, 12, 12, 1.0 },
                    { 178, 12, 13, 1.0 },
                    { 179, 12, 15, 0.5 },
                    { 180, 12, 16, 1.0 },
                    { 181, 13, 0, 1.0 },
                    { 182, 13, 1, 2.0 },
                    { 183, 13, 2, 1.0 },
                    { 184, 13, 3, 1.0 },
                    { 185, 13, 4, 1.0 },
                    { 186, 13, 5, 2.0 },
                    { 187, 13, 6, 0.5 },
                    { 188, 13, 7, 1.0 },
                    { 189, 13, 8, 0.5 },
                    { 190, 13, 10, 2.0 },
                    { 191, 13, 11, 1.0 },
                    { 192, 13, 12, 2.0 },
                    { 193, 13, 13, 1.0 },
                    { 194, 13, 15, 1.0 },
                    { 195, 13, 16, 1.0 },
                    { 196, 15, 0, 0.0 },
                    { 197, 15, 1, 1.0 },
                    { 171, 12, 5, 1.0 },
                    { 114, 7, 8, 0.5 },
                    { 76, 5, 0, 1.0 },
                    { 112, 7, 6, 1.0 },
                    { 30, 1, 16, 0.5 },
                    { 113, 7, 7, 0.5 },
                    { 32, 2, 1, 2.0 },
                    { 33, 2, 2, 0.5 },
                    { 34, 2, 3, 1.0 },
                    { 35, 2, 4, 0.5 },
                    { 36, 2, 5, 1.0 },
                    { 37, 2, 6, 1.0 },
                    { 38, 2, 7, 1.0 },
                    { 39, 2, 8, 2.0 },
                    { 40, 2, 10, 1.0 },
                    { 29, 1, 15, 1.0 },
                    { 41, 2, 11, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[,]
                {
                    { 43, 2, 13, 2.0 },
                    { 44, 2, 15, 1.0 },
                    { 45, 2, 16, 0.5 },
                    { 46, 3, 0, 1.0 },
                    { 47, 3, 1, 1.0 },
                    { 48, 3, 2, 2.0 },
                    { 49, 3, 3, 0.5 },
                    { 50, 3, 4, 0.5 },
                    { 51, 3, 5, 1.0 },
                    { 52, 3, 6, 1.0 },
                    { 53, 3, 7, 1.0 },
                    { 42, 2, 12, 1.0 },
                    { 28, 1, 13, 0.5 },
                    { 27, 1, 12, 2.0 },
                    { 26, 1, 11, 1.0 },
                    { 1, 0, 0, 1.0 },
                    { 2, 0, 1, 1.0 },
                    { 3, 0, 2, 1.0 },
                    { 4, 0, 3, 1.0 },
                    { 5, 0, 4, 1.0 },
                    { 6, 0, 5, 1.0 },
                    { 7, 0, 6, 1.0 },
                    { 8, 0, 7, 1.0 },
                    { 9, 0, 8, 1.0 },
                    { 10, 0, 10, 1.0 },
                    { 11, 0, 11, 1.0 },
                    { 12, 0, 12, 1.0 },
                    { 13, 0, 13, 0.5 },
                    { 14, 0, 15, 0.0 },
                    { 15, 0, 16, 1.0 },
                    { 16, 1, 0, 1.0 },
                    { 17, 1, 1, 0.5 },
                    { 18, 1, 2, 0.5 },
                    { 19, 1, 3, 1.0 },
                    { 20, 1, 4, 2.0 },
                    { 21, 1, 5, 2.0 },
                    { 22, 1, 6, 1.0 },
                    { 23, 1, 7, 1.0 },
                    { 24, 1, 8, 1.0 },
                    { 25, 1, 10, 1.0 },
                    { 54, 3, 8, 0.0 },
                    { 55, 3, 10, 2.0 }
                });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[,]
                {
                    { 31, 2, 0, 1.0 },
                    { 57, 3, 12, 1.0 },
                    { 87, 5, 12, 1.0 },
                    { 88, 5, 13, 1.0 },
                    { 89, 5, 15, 1.0 },
                    { 90, 5, 16, 2.0 },
                    { 91, 6, 0, 2.0 },
                    { 92, 6, 1, 1.0 },
                    { 93, 6, 2, 1.0 },
                    { 94, 6, 3, 1.0 },
                    { 95, 6, 4, 1.0 },
                    { 96, 6, 5, 2.0 },
                    { 97, 6, 6, 1.0 },
                    { 98, 6, 7, 0.5 },
                    { 99, 6, 8, 1.0 },
                    { 100, 6, 10, 0.5 },
                    { 101, 6, 11, 0.5 },
                    { 102, 6, 12, 0.5 },
                    { 103, 6, 13, 2.0 },
                    { 104, 6, 15, 0.0 },
                    { 105, 6, 16, 1.0 },
                    { 106, 7, 0, 1.0 },
                    { 107, 7, 1, 1.0 },
                    { 108, 7, 2, 1.0 },
                    { 56, 3, 11, 1.0 },
                    { 110, 7, 4, 2.0 },
                    { 111, 7, 5, 1.0 },
                    { 86, 5, 11, 1.0 },
                    { 85, 5, 10, 2.0 },
                    { 109, 7, 3, 1.0 },
                    { 83, 5, 7, 1.0 },
                    { 84, 5, 8, 2.0 },
                    { 58, 3, 13, 1.0 },
                    { 60, 3, 16, 0.5 },
                    { 61, 4, 0, 1.0 },
                    { 62, 4, 1, 0.5 },
                    { 63, 4, 2, 2.0 },
                    { 64, 4, 3, 1.0 },
                    { 65, 4, 4, 0.5 },
                    { 66, 4, 5, 1.0 },
                    { 67, 4, 6, 1.0 },
                    { 68, 4, 7, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Efficacites",
                columns: new[] { "EfficaciteId", "Attack", "Defend", "Effectiveness" },
                values: new object[,]
                {
                    { 69, 4, 8, 2.0 },
                    { 59, 3, 15, 1.0 },
                    { 71, 4, 11, 1.0 },
                    { 72, 4, 12, 0.5 },
                    { 73, 4, 13, 2.0 },
                    { 74, 4, 15, 1.0 },
                    { 75, 4, 16, 0.5 },
                    { 77, 5, 1, 1.0 },
                    { 78, 5, 2, 0.5 },
                    { 79, 5, 3, 1.0 },
                    { 80, 5, 4, 2.0 },
                    { 82, 5, 6, 1.0 },
                    { 81, 5, 5, 0.5 },
                    { 70, 4, 10, 0.5 }
                });

            migrationBuilder.InsertData(
                table: "Evolutions",
                columns: new[] { "EvolutionId", "Level", "To" },
                values: new object[,]
                {
                    { 36, 34, "Dewgong" },
                    { 35, 31, "Dodrio" },
                    { 34, 30, "Magneton" },
                    { 29, 28, "Machoke" },
                    { 32, 25, "Graveler" },
                    { 31, 30, "Tentacruel" },
                    { 30, 21, "Weepinbell" },
                    { 28, 16, "Kadabra" },
                    { 33, 40, "Rapidash" },
                    { 37, 38, "Muk" },
                    { 43, 35, "Weezing" },
                    { 39, 26, "Hypno" },
                    { 40, 28, "Kingler" },
                    { 41, 30, "Electrode" },
                    { 42, 28, "Marowak" },
                    { 44, 42, "Rhydon" },
                    { 45, 32, "Seadra" },
                    { 46, 33, "Seaking" },
                    { 47, 20, "Gyarados" },
                    { 48, 40, "Omastar" },
                    { 27, 25, "Poliwhirl" },
                    { 49, 40, "Kabutops" },
                    { 38, 25, "Haunter" },
                    { 26, 28, "Primeape" },
                    { 13, 20, "Raticate" },
                    { 24, 28, "Persian" },
                    { 50, 30, "Dragonair" },
                    { 1, 16, "Ivysaur" }
                });

            migrationBuilder.InsertData(
                table: "Evolutions",
                columns: new[] { "EvolutionId", "Level", "To" },
                values: new object[,]
                {
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
                    { 12, 36, "Pidgeot" },
                    { 14, 20, "Fearow" },
                    { 15, 22, "Arbok" },
                    { 16, 22, "Sandslash" },
                    { 17, 16, "Nidorina" },
                    { 18, 16, "Nidorino" },
                    { 19, 22, "Golbat" },
                    { 20, 21, "Gloom" },
                    { 21, 24, "Parasect" },
                    { 22, 31, "Venomoth" },
                    { 23, 26, "Dugtrio" },
                    { 25, 33, "Golduck" },
                    { 51, 55, "Dragonite" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Attaques",
                keyColumn: "AttaqueId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Correspondances",
                keyColumn: "CorrespondanceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Efficacites",
                keyColumn: "EfficaciteId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Evolutions",
                keyColumn: "EvolutionId",
                keyValue: 51);
        }
    }
}
