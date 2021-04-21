using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for Pokemons.xaml
    /// </summary>
    public partial class Pokemons : UserControl
    {
        public Pokemons()
        {
            InitializeComponent();
            DataContext = Game.VueActuelle;
        }
    }
}
