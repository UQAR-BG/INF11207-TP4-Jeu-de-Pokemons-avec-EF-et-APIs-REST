using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public class AccueilViewModel : BaseViewModel
    {
        public bool IsValid { get; private set; }
        public ICommand CommandeChargerSauvegarde { get; private set; }
        public ICommand CommandeCommencerUnePartie { get; private set; }

        public AccueilViewModel(WindowSize size) : base(size) 
        {
            VerifierSiSauvegardeExiste();

            CommandeCommencerUnePartie = new RelayCommand(
                o => true,
                o => CommencerUnePartie()
            );

            CommandeChargerSauvegarde = new RelayCommand(
                o => IsValid,
                o => ChargerSauvegarde()
            );
        }

        private void VerifierSiSauvegardeExiste()
        {
            IsValid = File.Exists(Game.CheminVersSauvegarde);
        }

        private void CommencerUnePartie()
        {
            Game.Naviguer("creationjoueur");
        }

        private void ChargerSauvegarde()
        {
            Game.Dresseur = Dresseur.GetDresseur(2);

            if (Game.Dresseur.DresseurId > 0)
            {
                MessageBox.Show("Sauvegarde chargée avec succès.", "Sauvegarde chargée", MessageBoxButton.OK);
                Game.Naviguer("joueur");
            }
            else
            {
                MessageBox.Show("La sauvegarde a été corrompue. Il est impossible de la lire. " +
                    "Veuillez débuter une nouvelle partie.", "Sauvegarde corrompue", MessageBoxButton.OK);
            }
        }
    }
}
