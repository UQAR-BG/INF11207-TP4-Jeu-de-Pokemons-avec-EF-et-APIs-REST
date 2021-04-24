using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Pokemon
    {
        public static List<Pokemon> ChargerPokemonDeBase()
        {
            List<Pokemon> pokemonsDeBase = new List<Pokemon>();
            pokemonsDeBase = Loader.ChargerDepuisFichier<Pokemon>("Resources/Data/PokemonInfo.json");

            foreach (Pokemon pokemon in pokemonsDeBase)
            {
                GenererTypesSerialises(pokemon);
            }
            return pokemonsDeBase;
        }

        private static void GenererTypesSerialises(Pokemon pokemon)
        {
            string typesSerialises = Loader.GenererJson(pokemon.Types);

            if (!string.IsNullOrEmpty(typesSerialises))
            {
                pokemon.TypesSerialises = typesSerialises;
            }
        }
    }
}
