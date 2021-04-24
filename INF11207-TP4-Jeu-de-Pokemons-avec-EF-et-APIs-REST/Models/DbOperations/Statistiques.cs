using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Statistiques
    {
        public static Statistiques GetStatistique(int statsId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Statistiques stats = context.Statistiques.Find(statsId);

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
