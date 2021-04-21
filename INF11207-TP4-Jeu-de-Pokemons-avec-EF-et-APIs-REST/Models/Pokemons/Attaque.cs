﻿using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class Attaque : Binding
    {
        private string name;
        private double damage;
        private OrigineType type;

        public OrigineType Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Damage
        {
            get { return damage; }
            set
            {
                if (damage != value)
                {
                    damage = value;
                    OnPropertyChanged();
                }
            }
        }

        public double CalculerDegats(Pokemon adversaire)
        {
            double efficaciteTotale = 1;

            foreach (OrigineType typeAdversaire in adversaire.Types)
            {
                efficaciteTotale *= EfficaciteAttaque.ChercherEfficacite(type, typeAdversaire);
            }
            return damage * efficaciteTotale;
        }
    }
}
