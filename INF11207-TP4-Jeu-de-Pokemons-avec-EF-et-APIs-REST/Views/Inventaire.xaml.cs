using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for Inventaire.xaml
    /// </summary>
    public partial class Inventaire : UserControl
    {
        public Inventaire()
        {
            InitializeComponent();
            DataContext = Game.VueActuelle;
        }

        private void UserControl_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                ((InventaireViewModel)DataContext).Rechercher();
            }
        }
    }
}
