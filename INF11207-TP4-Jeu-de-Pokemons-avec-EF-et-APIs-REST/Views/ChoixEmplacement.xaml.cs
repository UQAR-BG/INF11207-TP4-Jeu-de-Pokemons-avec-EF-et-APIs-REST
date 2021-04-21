using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Windows;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for ChoixEmplacement.xaml
    /// </summary>
    public partial class ChoixEmplacement : Window
    {
        public ChoixEmplacement()
        {
            InitializeComponent();
            DataContext = new ChoixEmplacementViewModel(this);
        }
    }
}
