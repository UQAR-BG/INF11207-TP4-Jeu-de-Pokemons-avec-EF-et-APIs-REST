using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for Statistiques.xaml
    /// </summary>
    public partial class Statistiques : UserControl
    {
        public Statistiques()
        {
            InitializeComponent();
            DataContext = Game.VueActuelle;
        }
    }
}
