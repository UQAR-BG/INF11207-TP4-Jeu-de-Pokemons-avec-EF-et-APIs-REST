using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using System.Windows.Controls;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public abstract class BaseViewModel : Binding
    {
        public WindowSize WindowSize { get; set; }
        public Grid Grid { get; set; }
        public Dresseur Dresseur 
        { 
            get { return Game.Dresseur; }
            set { Game.Dresseur = value; }
        }

        public BaseViewModel()
        {
            WindowSize = new WindowSize(450, 800);
        }

        public BaseViewModel(WindowSize size)
        {
            WindowSize = size;
        }
    }
}
