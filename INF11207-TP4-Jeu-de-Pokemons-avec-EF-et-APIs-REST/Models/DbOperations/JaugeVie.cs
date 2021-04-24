using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class JaugeVie
    {
        public static JaugeVie GetHpGauge(int gaugeId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            JaugeVie gauge = context.HealthGauges.Find(gaugeId);

            if (gauge == null)
            {
                return new JaugeVie(50);
            }

            return gauge;
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            JaugeVie gauge = context.HealthGauges.OrderByDescending(g => g.GaugeId).FirstOrDefault();

            if (gauge != null)
            {
                return gauge.GaugeId;
            }

            return 0;
        }

        public static void AddHpGauge(JaugeVie gauge)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            context.HealthGauges.Add(gauge);
            context.SaveChanges();
        }

        public static void UpdateHpGauge(int gaugeId, int value)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            JaugeVie updatedGauge = context.HealthGauges.Find(gaugeId);

            if (updatedGauge != null)
            {
                updatedGauge.Value = value;
                context.SaveChanges();
            }
        }
    }
}
