using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Views
{
    /// <summary>
    /// Interaction logic for Combats.xaml
    /// </summary>
    public partial class Combats : UserControl
    {
        public Combats()
        {
            InitializeComponent();
            DataContext = Game.VueActuelle;
        }

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                try
                {
                    ((CombatsViewModel)DataContext).LancerCombat();
                }
                catch (Exception) { }
            }
        }
    }
}
