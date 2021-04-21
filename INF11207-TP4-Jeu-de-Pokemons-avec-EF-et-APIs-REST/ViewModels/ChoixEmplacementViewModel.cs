using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using System.Windows;
using System.Windows.Input;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public class ChoixEmplacementViewModel : BaseViewModel
    {
        private Emplacement _emplacement;
        private Window _window;

        public Emplacement Emplacement
        {
            get { return _emplacement; }
            set
            {
                if (_emplacement != value)
                {
                    _emplacement = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CommandeChoisirEmplacement { get; set; }

        public ChoixEmplacementViewModel(Window window)
        {
            _window = window;

            CommandeChoisirEmplacement = new RelayCommand(
                o => true, 
                o=> ChoisirEmplacement()
            );
        }

        private void ChoisirEmplacement()
        {
            Game.Emplacement = Emplacement;
            _window.Close();
        }
    }
}
