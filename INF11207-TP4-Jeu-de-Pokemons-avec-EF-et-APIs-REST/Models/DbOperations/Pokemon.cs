using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;
using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Pokemon
    {
        public static Pokemon Acheter(string nom)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Pokemon pokemon = GetPokemonDeBase(nom);

            if (pokemon != null)
            {
                Pokemon pokemonAchete = (Pokemon)pokemon.Clone();
                pokemonAchete.Id = 0;
                pokemonAchete.Achete = true;

                pokemonAchete.ChargerProprietesDepuisBd();
                Jauge.CreerJauges(pokemonAchete);

                pokemonAchete.Attacks = ChargerAttaques(pokemonAchete);

                context.Pokemons.Add(pokemonAchete);
                context.SaveChanges();

                pokemonAchete.Id = GetLatestId();
                return pokemonAchete;
            }
            return new Pokemon();
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Pokemon pokemon = context.Pokemons.OrderByDescending(p => p.Id).FirstOrDefault();

            if (pokemon != null)
            {
                return pokemon.Id;
            }

            return 0;
        }

        public static Pokemon GetPokemon(int pokemonId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Pokemon pokemon = context.Pokemons.Find(pokemonId);

            if (pokemon == null)
            {
                return new Pokemon();
            }

            pokemon.Attacks = ChargerAttaques(pokemon);
            return pokemon;
        }

        public static Pokemon GetPokemonDeBase(string nom)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Pokemon pokemon = context.Pokemons.FirstOrDefault(p => p.Name.Equals(nom));

            return pokemon;
        }

        public static List<Pokemon> GetPokemonsDeBase()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            List<Pokemon> pokemonsDeBase = context.Pokemons.Take(151).ToList();

            foreach (Pokemon pokemonDeBase in pokemonsDeBase)
            {
                pokemonDeBase.Attacks = ChargerAttaques(pokemonDeBase);
            }
            return pokemonsDeBase;
        }

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

        private static List<Attaque> ChargerAttaques(Pokemon pokemon)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            List<Attaque> attaques = new List<Attaque>();

            pokemon.AttacksIds = ChargerListeIdsAttaques(pokemon);
            attaques = context.Attaques.Where(a => pokemon.AttacksIds.Contains(a.AttaqueId)).ToList();

            return attaques;
        }

        private static List<int> ChargerListeIdsAttaques(Pokemon pokemon)
        {
            List<int> idsAttaques = Loader.DeserialiserDepuisJson<List<int>>(pokemon.AttacksIdsSerialises);

            return idsAttaques;
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
            string idsAttaquesSerialises = Loader.GenererJson(pokemon.AttacksIds);

            pokemon.AttacksIdsSerialises = idsAttaquesSerialises;
        }
    }
}
