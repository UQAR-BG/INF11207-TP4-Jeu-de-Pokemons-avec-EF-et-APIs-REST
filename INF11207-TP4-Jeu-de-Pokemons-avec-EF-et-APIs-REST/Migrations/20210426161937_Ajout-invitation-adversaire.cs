using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Migrations
{
    public partial class Ajoutinvitationadversaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Invitations",
                columns: new[] { "InvitationId", "CreateurId", "DateCreation", "MiseAdversaire", "MiseCreateur", "Niveau", "NomAdversaire", "NomCreateur", "Statut" },
                values: new object[] { 1, 1, new DateTime(2021, 4, 26, 11, 17, 44, 216, DateTimeKind.Local).AddTicks(4331), 0, 100, 5, null, "John Doe", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Invitations",
                keyColumn: "InvitationId",
                keyValue: 1);
        }
    }
}
