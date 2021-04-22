using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using System.Collections.Generic;
using System.Windows;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class Attaque : Binding
    {
        public int AttaqueId { get; set; }

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

        public static List<Attaque> ChargerAttaquesDepuisFichier()
        {
            List<Attaque> attacks = new List<Attaque>();
            if (!Loader.Charger(out attacks, "Resources/Data/Attacks.json"))
            {
                MessageBox.Show("Le fichier Attacks.json est manquant. Le jeu pourra donc rencontrer des comportements étranges.",
                    "Données manquantes", MessageBoxButton.OK);
            }

            return attacks;
        }
    }
}
