using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class Pokemon : Personnage, ICloneable, ICombattant
    {
        private string description;
        private int atk;
        private int def;
        private int price;
        private int health;
        private Emplacement emplacement;
        [JsonIgnore]
        private JaugeVie hpGauge;
        private Evolution evolution;
        private Guid idPokemonAchete;
        private string image;
        private bool achete;
        private bool equipe;

        private List<Attaque> attacks;

        public int Id { get; set; }

        [NotMapped]
        public List<OrigineType> Types { get; set; }

        [NotMapped]
        public string PrintTypes
        {
            get
            {
                string types = "";
                for (int i = 0; i < Types.Count; i++)
                {
                    types += Types[i].ToString() + (i < Types.Count - 1 ? ", " : "");
                }
                return types;
            }
        }

        public bool Evolue
        {
            get { return evolution != null && !string.IsNullOrEmpty(evolution.To); }
        }

        public int EvolutionId { get; set; }

        [NotMapped]
        public Evolution Evolution
        {
            get { return evolution; }
            set
            {
                if (evolution != value)
                {
                    evolution = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        public int ATK
        {
            get { return atk; }
            set
            {
                if (atk != value)
                {
                    atk = value;
                    OnPropertyChanged();
                }
            }
        }

        public int DEF
        {
            get { return def; }
            set
            {
                if (def != value)
                {
                    def = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged();
                }
            }
        }

        [NotMapped]
        public string PrintPrice
        {
            get { return $"{price}$"; }
        }

        public int Health
        {
            get { return health; }
            set
            {
                if (health != value)
                {
                    health = value;
                    hpGauge = new JaugeVie(health);
                    OnPropertyChanged();
                }
            }
        }

        public int HpGaugeId { get; set; }

        [NotMapped]
        [JsonIgnore]
        public JaugeVie HpGauge
        {
            get { return hpGauge; }
            set
            {
                if (hpGauge != value)
                {
                    hpGauge = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Image
        {
            get { return image; }
            set
            {
                if (image != value)
                {
                    image = value;
                    OnPropertyChanged();
                }
            }
        }

        [NotMapped]
        public List<Attaque> Attacks
        {
            get { return attacks; }
            set
            {
                if (attacks != value)
                {
                    attacks = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Achete
        {
            get { return achete; }
            set
            {
                if (achete != value)
                {
                    achete = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool Equipe
        {
            get { return equipe; }
            set
            {
                if (equipe != value)
                {
                    equipe = value;
                    OnPropertyChanged();
                }
            }
        }

        public Emplacement Emplacement
        {
            get { return emplacement; }
            set
            {
                if (emplacement != value)
                {
                    if (value == Emplacement.Desequipe)
                    {
                        Equipe = false;
                    }
                    else
                    {
                        Equipe = true;
                    }
                    emplacement = value;
                    OnPropertyChanged();
                }
            }
        }

        [NotMapped]
        public Guid IdPokemonAchete 
        { 
            get { return idPokemonAchete; }
            set
            {
                if (idPokemonAchete != value)
                {
                    idPokemonAchete = value;
                    OnPropertyChanged();
                }
            }
        }

        [JsonConstructor]
        public Pokemon() : base("", 1, 100) 
        {
            XpGauge = JaugeXp.GetXpGauge(XpGaugeId);
            HpGauge = JaugeVie.GetHpGauge(HpGaugeId);

            Evolution = Evolution.GetEvolution(EvolutionId);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Acheter()
        {
            Achete = true;
            if (idPokemonAchete.Equals(Guid.Empty))
            {
                idPokemonAchete = Guid.NewGuid();
                Jauge.CreerJauges(this);
            }
        }

        public bool EncoreValide()
        {
            return HpGauge.Value > 0;
        }

        public bool Attaquer(Pokemon adversaire, Attaque attaque)
        {
            double degats = attaque.CalculerDegats(adversaire) + ATK;

            return adversaire.RecevoirUneAttaque(degats); 
        }

        public bool RecevoirUneAttaque(double degats)
        {
            int degatsArrondis = (int)Math.Ceiling(degats) - DEF;
            HpGauge.PerdreDeLaVie(degatsArrondis);

            return HpGauge.Value == 0;
        }

        public void TerminerUnCombat(ResultatCombat resultats)
        {
            int niveauxEnPlus = XpGauge.AjouterExperience(this, resultats.Experience);

            for (int i = 0; i < niveauxEnPlus; i++)
            {
                HpGauge.MaxValue++;
                ATK++;
            }

            HpGauge.Reinitialiser();
        }
    }
}
