using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using Newtonsoft.Json;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Evolution
    {
        public int EvolutionId { get; set; }
        public int Level { get; set; }
        public string To { get; set; }

        [JsonConstructor]
        public Evolution()
        {
            Level = 1;
            To = "";
        }

        public Pokemon EvoluerSiAtteintLeNiveau(Pokemon pokemon)
        {
            if (pokemon.Evolue && pokemon.Level >= Level && !pokemon.Name.Equals(To))
            {
                Pokemon evolution = (Pokemon)Game.PokemonsDeBase
                    .Find(p => p.Name.Equals(To))
                    .Clone();

                evolution.Acheter();
                evolution.ATK = pokemon.ATK;
                evolution.DEF = pokemon.DEF;
                evolution.Emplacement = pokemon.Emplacement;
                evolution.Level = pokemon.Level;
                evolution.XpGauge = pokemon.XpGauge;

                return evolution;
            }
            return null;
        }
    }
}
