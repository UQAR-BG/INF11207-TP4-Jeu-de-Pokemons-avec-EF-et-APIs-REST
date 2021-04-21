using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels.UserControlViewModels
{
    public class PokemonSimpleViewModel : BaseViewModel
    {
        private EmplacementPokemon _pokemon;

        public EmplacementPokemon Pokemon { get { return _pokemon; } }

        public PokemonSimpleViewModel(EmplacementPokemon pokemon)
        {
            _pokemon = pokemon;
        }
    }
}
