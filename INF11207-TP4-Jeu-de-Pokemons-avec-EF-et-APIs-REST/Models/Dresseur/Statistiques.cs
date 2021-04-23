using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Statistiques
    {
        public int StatistiquesId { get; set; }
        public int MontantAccumule { get; set; }
        public int MontantDepense { get; set; }
        public int PokemonsAchetes { get; set; }
        public int PokemonsDebloques { get; set; }
        public int CombatsTotal { get; set; }
        public int CombatsGagnes { get; set; }
        public int CombatsPerdus { get; set; }

        [NotMapped]
        public string PrintMontantAccumule { get { return $"{MontantAccumule}$"; } }

        [NotMapped]
        public string PrintMontantDepense { get { return $"{MontantDepense}$"; } }

        [JsonConstructor]
        public Statistiques() { }

        public Statistiques(int montantInitial, int nbPokemonsAchetes)
        {
            MontantAccumule = montantInitial;
            MontantDepense = 0;
            PokemonsAchetes = nbPokemonsAchetes;
            PokemonsDebloques = nbPokemonsAchetes;
            CombatsTotal = 0;
            CombatsGagnes = 0;
            CombatsPerdus = 0;
        }

        public void CombatTermine(ResultatCombat resultat)
        {
            MontantAccumule += resultat.Mise;
            CombatsTotal++;

            if (resultat.Victoire)
            {
                CombatsGagnes++;
            }
            else
            {
                CombatsPerdus++;
            }
        }
    }
}
