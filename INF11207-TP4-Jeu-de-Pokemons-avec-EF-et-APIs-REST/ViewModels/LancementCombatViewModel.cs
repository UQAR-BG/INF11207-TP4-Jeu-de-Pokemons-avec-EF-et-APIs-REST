using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public class LancementCombatViewModel : BaseViewModel
    {
        private Invitation _invitation;
        private Invitation _invitationSelectionnee;
        private ObservableCollection<Invitation> _resultats;

        public ICommand CommandeCreer { get; set; }

        public ICommand CommandeLancer { get; set; }

        public Invitation Invitation
        {
            get { return _invitation; }
            set { _invitation = value; }
        }

        public Invitation InvitationSelectionne
        {
            get { return _invitationSelectionnee; }
            set
            {
                _invitationSelectionnee = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Invitation> Resultats
        {
            get { return _resultats; }
            set
            {
                if (_resultats != value)
                {
                    _resultats = value;
                    OnPropertyChanged();
                }
            }
        }

        public LancementCombatViewModel(WindowSize size) : base(size) 
        {
            CommandeCreer = new RelayCommand(
                o => Invitation.IsValid,
                o => CreerInvitation()
            );

            CommandeLancer = new RelayCommand(
                o => _invitationSelectionnee != null && Invitation.IsValid,
                o => LancerUnCombat()
            );
        }

        public void RechercherInvitations()
        {
            Invitation = new Invitation(Dresseur, 100);

            List<Invitation> invitations = Invitation.GetInvitationsEnAttente();

            Resultats = new ObservableCollection<Invitation>(invitations);
            InvitationSelectionne = Resultats[0];
        }

        private void CreerInvitation()
        {
            Invitation.AddInvitation(Invitation);
            Invitation.InvitationId = Invitation.GetLatestId();
            Dresseur.Invitations.Add(Invitation);

            MessageBox.Show($" Le dresseur {Resultats[0].NomCreateur} a accepté votre invitation.\nLancement du combat en cours...", 
                "Nouveau combat", MessageBoxButton.OK);

            LancerUnCombat();
        }

        private void LancerUnCombat()
        {
            int invitationId = Invitation.InvitationId == 0 ? InvitationSelectionne.InvitationId : Invitation.InvitationId;
            Combat nouveauCombat = Invitation.Accepter(invitationId, Dresseur, Invitation.MiseCreateur);

            if (nouveauCombat.Mise > 0)
            {
                Game.Combat = nouveauCombat;
                Game.Naviguer("combats");
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors du lancement du combat.", "Erreur", MessageBoxButton.OK);
            }
        }
    }
}
