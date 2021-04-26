using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using System.Collections.Generic;
using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Invitation
    {
        public static void AddInvitation(Invitation invitation)
        {
            if (!Dresseur.DresseurExiste(invitation.CreateurId))
            {
                return;
            }

            using (JeuDePokemonsDbContext context = new JeuDePokemonsDbContext())
            {
                context.Invitations.Add(invitation);
                context.SaveChanges();
            }
        }

        public static int GetLatestId()
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Invitation invitation = context.Invitations.OrderByDescending(i => i.InvitationId).FirstOrDefault();

            if (invitation != null)
            {
                return invitation.InvitationId;
            }

            return 0;
        }

        public static Invitation GetInvitation(int invitationId)
        {
            if (invitationId <= 0)
            {
                return null;
            }

            using (JeuDePokemonsDbContext context = new JeuDePokemonsDbContext())
            {
                Invitation invitation = context.Invitations.Find(invitationId);

                return invitation;
            }
        }

        public static List<Invitation> GetInvitations(int createurId)
        {
            using (JeuDePokemonsDbContext context = new JeuDePokemonsDbContext())
            {
                List<Invitation> invitations = context.Invitations.Where(i => i.CreateurId == createurId).ToList();

                return invitations;
            }
        }

        public static List<Invitation> GetInvitationsEnAttente()
        {
            using (JeuDePokemonsDbContext context = new JeuDePokemonsDbContext())
            {
                List<Invitation> invitations = context.Invitations.Where(i => i.Statut == StatutType.Attente).ToList();

                return invitations;
            }
        }

        public static Combat Accepter(int invitationId, Dresseur adversaire, int mise)
        {
            Invitation invitation = GetInvitation(invitationId);

            if (invitation != null)
            {
                UpdateInvitation(invitationId, StatutType.Accepte, mise, $"{adversaire.FirstName} {adversaire.Name}");

                adversaire.ModifierArgent(-mise);
                int miseTotale = mise + invitation.MiseCreateur;

                Dresseur createur = Dresseur.GetDresseur(invitation.CreateurId);
                return new Combat(adversaire, createur, miseTotale);
            }
            else
            {
                return new Combat(new Dresseur(1), new Dresseur(1), 0);
            }
        }

        public static void UpdateInvitation(int invitationId, StatutType statut, int miseAdversaire, string nomAdversaire)
        {
            using (JeuDePokemonsDbContext context = new JeuDePokemonsDbContext())
            {
                Invitation invitation = context.Invitations.Find(invitationId);

                if (invitation != null)
                {
                    invitation.Statut = statut;
                    invitation.MiseAdversaire = miseAdversaire;
                    invitation.NomAdversaire = nomAdversaire;
                    context.SaveChanges();
                }
            }
        }
    }
}
