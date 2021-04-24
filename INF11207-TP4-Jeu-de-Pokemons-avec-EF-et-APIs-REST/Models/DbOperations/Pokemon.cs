using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Pokemon
    {
        public static List<Pokemon> ChargerPokemonDeBase()
        {
            List<Pokemon> pokemonsDeBase = new List<Pokemon>();
            pokemonsDeBase = Loader.ChargerDepuisFichier<Pokemon>("Resources/Data/PokemonInfo_ForDB.json");

            foreach (Pokemon pokemon in pokemonsDeBase)
            {
                GenererTypesSerialises(pokemon);
                GenererIdsAttaquesSerialises(pokemon);
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

        private static void GenererIdsAttaquesSerialises(Pokemon pokemon)
        {
            List<int> idsAttaques = GenererListeIdsDesAttaques(pokemon.Attacks);
            string idsAttaquesSerialises = Loader.GenererJson(idsAttaques);

            pokemon.AttacksIdsSerialises = idsAttaquesSerialises;
        }

        private static List<int> GenererListeIdsDesAttaques(List<Attaque> attaques)
        {
            List<int> idsAttaques = new List<int>();

            foreach (Attaque attaque in attaques)
            {
                int attaqueId = Attaque.GetAttaqueId(attaque.Name);
                idsAttaques.Add(attaqueId);
            }
            return idsAttaques;
        }
    }
}
