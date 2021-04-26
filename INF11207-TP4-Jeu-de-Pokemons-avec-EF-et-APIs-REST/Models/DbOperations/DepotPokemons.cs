using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;
using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class DepotPokemons
    {
        public static void AddDepot(DepotPokemons depot)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            context.Depots.Add(depot);
            context.SaveChanges();
        }

        public static bool DepotExiste(int depotId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            DepotPokemons depot = context.Depots.Find(depotId);

            return depot != null;
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            DepotPokemons depot = context.Depots.OrderByDescending(d => d.DepotId).FirstOrDefault();

            if (depot != null)
            {
                return depot.DepotId;
            }

            return 0;
        }

        public static DepotPokemons GetDepot(int dresseurId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            DepotPokemons depot = context.Depots.Where(d => d.DresseurId == dresseurId).FirstOrDefault();

            if (dresseurId <= 0 || depot == null)
            {
                depot = new DepotPokemons(1);
            }

            depot.ChargerProprietesDepuisBd();
            return depot;
        }

        public static List<Pokemon> ChargerPokemonsAchetes(DepotPokemons depot)
        {
            List<Pokemon> pokemonsAchetes = Pokemon.GetPokemonAchetes(depot.DepotId);

            return pokemonsAchetes;
        }

        public static List<int> ChargerIndexPokemonsEquipes(DepotPokemons depot)
        {
            List<int> indexPokemonsEquipes = Loader.DeserialiserDepuisJson<List<int>>(depot.IndexPokemonsEquipesSerialises);

            return indexPokemonsEquipes;
        }

        public static void UpdateDepot(int depotId, List<int> indexPokemonsEquipes)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            DepotPokemons depot = context.Depots.Find(depotId);

            if (depot != null)
            {
                depot.IndexPokemonsEquipesSerialises = GenererIndexPokemonsEquipes(indexPokemonsEquipes);
                context.SaveChanges();
            }
        }

        public static void UpdateDepot(int depotId, int dresseurId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            DepotPokemons depot = context.Depots.Find(depotId);

            if (depot != null)
            {
                depot.DresseurId = dresseurId;
                context.SaveChanges();
            }
        }

        private static string GenererIndexPokemonsEquipes(List<int> indexPokemonsEquipes)
        {
            string indexPokemonsEquipesSerialises = Loader.GenererJson(indexPokemonsEquipes);

            return indexPokemonsEquipesSerialises;
        }
    }
}
