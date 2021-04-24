using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class JaugeXp
    {
        public static JaugeXp GetXpGauge(int gaugeId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            JaugeXp gauge = context.XpGauges.Find(gaugeId);

            if (gauge == null)
            {
                return new JaugeXp(100);
            }

            return gauge;
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            JaugeXp gauge = context.XpGauges.OrderByDescending(g => g.GaugeId).FirstOrDefault();

            if (gauge != null)
            {
                return gauge.GaugeId;
            }

            return 0;
        }

        public static void AddXpGauge(JaugeXp gauge)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            context.XpGauges.Add(gauge);
            context.SaveChanges();
        }

        public static void UpdateXpGauge(int gaugeId, int value)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            JaugeXp updatedGauge = context.XpGauges.Find(gaugeId);

            if (updatedGauge != null)
            {
                updatedGauge.Value = value;
                context.SaveChanges();
            }
        }
    }
}
