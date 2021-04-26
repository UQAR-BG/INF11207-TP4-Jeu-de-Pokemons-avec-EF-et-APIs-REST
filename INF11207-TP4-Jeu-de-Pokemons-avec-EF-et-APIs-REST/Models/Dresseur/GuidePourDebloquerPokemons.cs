using Newtonsoft.Json;
using System.Collections.Generic;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class GuidePourDebloquerPokemons
    {
        [JsonIgnore]
        public Dictionary<int, List<int>> CorrespondanceNiveauPokemon { get; set; }

        [JsonIgnore]
        public List<int> IdPokemonsDebloques { get; set; }

        [JsonConstructor]
        public GuidePourDebloquerPokemons() { }

        public GuidePourDebloquerPokemons(int niveauDresseur)
        {
            CorrespondanceNiveauPokemon = Correspondance.ShowCorrespondances();
            AppliquerCorrespondance(niveauDresseur);
        }

        public void AppliquerCorrespondance(int niveauDresseur)
        {
            if (niveauDresseur > 0)
            {
                IdPokemonsDebloques = new List<int>();

                while (niveauDresseur > 0)
                {
                    AppliquerCorrespondanceParNiveau(niveauDresseur);
                    niveauDresseur--;
                }
            }
        }

        private void AppliquerCorrespondanceParNiveau(int niveauDresseur)
        {
            if (CorrespondanceNiveauPokemon.ContainsKey(niveauDresseur))
            {
                IdPokemonsDebloques.InsertRange(0, CorrespondanceNiveauPokemon[niveauDresseur]);
            }
        }
    }
}
