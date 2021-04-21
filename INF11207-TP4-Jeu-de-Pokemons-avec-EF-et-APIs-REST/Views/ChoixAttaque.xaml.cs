using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for ChoixAttaque.xaml
    /// </summary>
    public partial class ChoixAttaque : Window
    {
        public ChoixAttaque(List<Attaque> attaques)
        {
            InitializeComponent();
            DataContext = new ChoixAttaqueViewModel(this, attaques);
        }
    }
}
