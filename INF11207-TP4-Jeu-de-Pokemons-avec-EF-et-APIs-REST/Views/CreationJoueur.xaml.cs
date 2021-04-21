using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Interfaces;
using System.Text.RegularExpressions;
using System.Windows.Input;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for CreationJoueur.xaml
    /// </summary>
    public partial class CreationJoueur : UserControl, INombreEnEntree
    {
        public CreationJoueur()
        {
            InitializeComponent();
            DataContext = Game.VueActuelle;
        }

        public void VerifierSiEntreeEstNombre(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
