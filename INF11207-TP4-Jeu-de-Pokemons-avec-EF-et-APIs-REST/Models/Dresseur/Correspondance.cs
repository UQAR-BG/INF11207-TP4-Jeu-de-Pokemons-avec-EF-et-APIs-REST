using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class Correspondance
    {
        public int CorrespondanceId { get; set; }
        public string CorrespondancesSerialisee { get; set; }

        public static Dictionary<int, List<int>> ShowCorrespondances()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();

            Dictionary<int, List<int>> correspondances;
            string correspondancesSerialisees = context.Correspondances.Find(1).CorrespondancesSerialisee;

            try
            {
                correspondances = JsonConvert.DeserializeObject<Dictionary<int, List<int>>>(correspondancesSerialisees);
            }
            catch (JsonSerializationException)
            {
                correspondances = new Dictionary<int, List<int>>();
            }

            return correspondances;
        }

        public static Correspondance ChargerCorrespondancesDepuisFichier()
        {
            string nomFichierCorrespondance = "Resources/Data/CorrespondanceNiveauPokemons.json";

            Correspondance correspondanceNiveauPokemons = new Correspondance();
            correspondanceNiveauPokemons.CorrespondanceId = 1;
            correspondanceNiveauPokemons.CorrespondancesSerialisee = Loader.Lire(nomFichierCorrespondance);

            return correspondanceNiveauPokemons;
        }
    }
}
