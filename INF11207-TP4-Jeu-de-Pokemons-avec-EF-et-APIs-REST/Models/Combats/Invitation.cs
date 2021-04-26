using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Invitation : Binding
    {
        [JsonIgnore]
        private bool isValid;

        private StatutType statut;
        private string nomAdversaire;
        private string nomCreateur;
        private int miseCreateur;
        private int miseAdversaire;
        private int niveau;

        private DateTime dateCreation;
        private Dresseur createur;

        public int InvitationId { get; set; }

        public StatutType Statut
        {
            get { return statut; }
            set
            {
                if (statut != value)
                {
                    statut = value;
                    SetIsValid();
                }
            }
        }

        public int Niveau
        {
            get { return niveau; }
            set
            {
                if (niveau != value)
                {
                    niveau = value;
                    OnPropertyChanged();
                }
            }
        }

        public string NomAdversaire
        {
            get { return nomAdversaire; }
            set
            {
                if (nomAdversaire != value)
                {
                    nomAdversaire = value;
                    OnPropertyChanged();
                }
            }
        }

        public string NomCreateur
        {
            get { return nomCreateur; }
            set
            {
                if (nomCreateur != value)
                {
                    nomCreateur = value;
                    OnPropertyChanged();
                }
            }
        }

        public int MiseCreateur
        {
            get { return miseCreateur; }
            set
            {
                if (miseCreateur != value)
                {
                    miseCreateur = value;
                    SetIsValid();
                }
            }
        }

        public int MiseAdversaire
        {
            get { return miseAdversaire; }
            set
            {
                if (miseAdversaire != value)
                {
                    miseAdversaire = value;
                    SetIsValid();
                }
            }
        }

        public DateTime DateCreation
        {
            get { return dateCreation; }
            set
            {
                if (dateCreation != value)
                {
                    dateCreation = value;
                    OnPropertyChanged();
                }
            }
        }

        public int CreateurId { get; set; }

        [NotMapped]
        public Dresseur Createur
        {
            get { return createur; }
            set
            {
                if (createur != value)
                {
                    createur = value;
                    SetIsValid();
                }
            }
        }

        [NotMapped]
        [JsonIgnore]
        public bool IsValid
        {
            get { return isValid; }
            set
            {
                if (isValid != value)
                {
                    isValid = value;
                    OnPropertyChanged();
                }
            }
        }

        [JsonConstructor]
        public Invitation() { }

        public Invitation(Dresseur createur, int miseCreateur)
        {
            statut = StatutType.Attente;

            this.createur = createur;
            CreateurId = createur.DresseurId;
            NomCreateur = $"{createur.FirstName} {createur.Name}";
            MiseCreateur = miseCreateur;
            Niveau = createur.Level;
            DateCreation = DateTime.Now;
        }

        public bool ShouldSerializeCreateur()
        {
            return false;
        }

        public void Confirmer()
        {

        }

        public void Refuser()
        {

        }

        private void SetIsValid()
        {
            IsValid = createur != null && MiseCreateur >= 100 && createur.Money >= MiseCreateur;
        }
    }
}
