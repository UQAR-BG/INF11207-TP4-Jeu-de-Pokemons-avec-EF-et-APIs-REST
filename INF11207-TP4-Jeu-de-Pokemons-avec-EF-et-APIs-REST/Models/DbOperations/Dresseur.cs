using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Dresseur
    {
        public static Dresseur AddDresseur(Dresseur dresseur)
        {
            JaugeXp.AddXpGauge(dresseur.XpGauge);
            dresseur.XpGaugeId = JaugeXp.GetLatestId();

            DepotPokemons.AddDepot(dresseur.Depot);
            dresseur.DepotId = DepotPokemons.GetLatestId();
            dresseur.Depot.ChargerDepotParDefaut();

            Statistiques.AddStatistique(dresseur.Statistiques);
            dresseur.StatistiquesId = Statistiques.GetLatestId();

            using (JeuDePokemonsDbContext context = new JeuDePokemonsDbContext())
            {
                context.Dresseurs.Add(dresseur);
                context.SaveChanges();
            }

            DepotPokemons.UpdateDepot(dresseur.DepotId, dresseur.DresseurId);
            return dresseur;
        }

        public static Dresseur GetDresseur(int dresseurId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Dresseur dresseur = context.Dresseurs.Find(dresseurId);

            if (dresseurId <= 0 || dresseur == null)
            {
                dresseur = new Dresseur(1);
            }

            dresseur.ChargerProprietesDepuisBd();
            return dresseur;
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Dresseur dresseur = context.Dresseurs.OrderByDescending(d => d.DresseurId).FirstOrDefault();

            if (dresseur != null)
            {
                return dresseur.DresseurId;
            }

            return 0;
        }

        public static void UpdateDresseur(int dresseurId, int money, int level)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Dresseur dresseur = context.Dresseurs.Find(dresseurId);

            if (dresseur != null)
            {
                dresseur.Money = money;
                dresseur.Level = level;
                context.SaveChanges();
            }
        }
    }
}
