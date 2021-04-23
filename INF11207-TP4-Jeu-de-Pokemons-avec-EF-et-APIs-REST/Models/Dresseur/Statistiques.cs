using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class Statistiques
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

        public static Statistiques GetStatistique(int statsId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Statistiques stats = context.Statistiques.SingleOrDefault(s => s.StatistiquesId == statsId);

            if (stats == null)
            {
                return new Statistiques(5000, 1);
            }

            return stats;
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Statistiques stats = context.Statistiques.OrderByDescending(s => s.StatistiquesId).FirstOrDefault();

            if (stats != null)
            {
                return stats.StatistiquesId;
            }

            return 0;
        }

        public static void AddStatistique(Statistiques stats)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            context.Statistiques.Add(stats);
            context.SaveChanges();
        }

        public static void UpdateStatistique(Statistiques stats)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Statistiques updatedStats = context.Statistiques.Find(stats.StatistiquesId);

            if (updatedStats != null)
            {
                context.Entry(updatedStats).CurrentValues.SetValues(stats);
                context.SaveChanges();
            }
        }
    }
}
