using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;
using System.Windows;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public class Game
    {
        private static readonly string _cheminVersSauvegarde = "Resources/Save/Sauvegarde.json";
        private static bool _sauvegardeChargee = false;

        private static List<Pokemon> _pokemonsBase;

        private static MainWindowViewModel _mainViewModel = new MainWindowViewModel();
        private static Dresseur _dresseur = new Dresseur(1);
        private static Recherche _recherche;

        public static string CheminVersSauvegarde
        {
            get { return _cheminVersSauvegarde; }
        }

        public static bool SauvegardeChargee
        {
            get { return _sauvegardeChargee; }
        }

        public static Emplacement Emplacement { get; set; }
        public static Attaque Attaque { get; set; }

        public static MainWindowViewModel MainWindow
        {
            get { return _mainViewModel; }
        }

        public static BaseViewModel VueActuelle
        {
            get { return _mainViewModel.VueActuelle; }
        }

        public static Dresseur Dresseur
        {
            get { return _dresseur; }
            set
            {
                _dresseur = value;
                _sauvegardeChargee = true;
            }
        }

        public static Recherche Recherche
        {
            get { return _recherche; }
        }

        public static Combat Combat { get; set; }

        public static List<Pokemon> PokemonsDeBase
        {
            get { return _pokemonsBase; }
        }

        public static void Initialiser()
        {
            _pokemonsBase = Pokemon.GetPokemonsDeBase();
            _recherche = new Recherche();
            _recherche.Filtre = FiltreRecherche.Tous;
            Combat = new Combat(new Dresseur(1), new Dresseur(1), 0);
        }

        public static void Naviguer(string destination)
        {
            _mainViewModel.Navigation(destination);
        }

        public static void Sauvegarder()
        {
            if (Loader.Sauvegarder(Dresseur, CheminVersSauvegarde))
            {
                MessageBox.Show("Sauvegarde effectuée avec succès.", "Sauvegarde effectuée", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors de la sauvegarde.", "Erreur", MessageBoxButton.OK);
            }
        }
    }
}
