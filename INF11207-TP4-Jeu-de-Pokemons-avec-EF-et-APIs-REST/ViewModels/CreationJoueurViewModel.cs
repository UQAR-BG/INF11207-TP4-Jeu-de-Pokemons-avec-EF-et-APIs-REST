using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using System.Windows.Input;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public class CreationJoueurViewModel : BaseViewModel
    {
        public ICommand CommandeCreerJoueur { get; private set; }
        public ICommand CommandeAnnuler { get; private set; }

        public CreationJoueurViewModel(WindowSize size) : base(size)
        {
            CommandeCreerJoueur = new RelayCommand(
                o => Dresseur.IsValid,
                o => CreerJoueur()
            );

            CommandeAnnuler = new RelayCommand(
                o => true,
                o => Annuler()
            );
        }

        private void CreerJoueur()
        {
            Game.Naviguer("joueur");
        }

        private void Annuler()
        {
            Game.Naviguer("accueil");
        }
    }
}
