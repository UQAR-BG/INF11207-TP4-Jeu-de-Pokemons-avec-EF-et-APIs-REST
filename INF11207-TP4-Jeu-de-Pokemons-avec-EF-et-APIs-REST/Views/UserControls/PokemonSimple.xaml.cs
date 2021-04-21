using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels.UserControlViewModels;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views.UserControls
{
    /// <summary>
    /// Interaction logic for PokemonSimple.xaml
    /// </summary>
    public partial class PokemonSimple : UserControl
    {
        public PokemonSimple()
        {
            InitializeComponent();
            EmplacementPokemon pokemon = (EmplacementPokemon)DataContext;
            DataContext = new PokemonSimpleViewModel(pokemon);
        }
    }
}
