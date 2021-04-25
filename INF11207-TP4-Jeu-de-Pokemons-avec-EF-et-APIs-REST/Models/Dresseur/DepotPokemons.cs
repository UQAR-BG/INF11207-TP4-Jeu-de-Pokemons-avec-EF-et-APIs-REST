using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class DepotPokemons : Binding
    {
        [JsonIgnore]
        private ObservableCollection<EmplacementPokemon> _emplacements;
        private ObservableCollection<int> _indexPokemonsEquipes;

        public int DepotId { get; set; }
        public int DresseurId { get; set; }

        [NotMapped]
        public List<Pokemon> PokemonsAchetes { get; set; }

        [NotMapped]
        public ObservableCollection<int> IndexPokemonsEquipes
        {
            get { return _indexPokemonsEquipes; }
            set
            {
                if (_indexPokemonsEquipes != value)
                {
                    _indexPokemonsEquipes = value;
                    OnPropertyChanged();
                }
            }
        }

        public string IndexPokemonsEquipesSerialises { get; set; }

        [NotMapped]
        [JsonIgnore]
        public ObservableCollection<EmplacementPokemon> Emplacements
        {
            get { return _emplacements; }
            set
            {
                if (_emplacements != value)
                {
                    _emplacements = value;
                    OnPropertyChanged();
                }
            }
        }

        [JsonConstructor]
        public DepotPokemons() 
        {
            Emplacements = new ObservableCollection<EmplacementPokemon>();
        }

        public DepotPokemons(int niveauDresseur)
        {
            Emplacements = new ObservableCollection<EmplacementPokemon>();
            ChargerProprietesDepuisBd();
        }

        public void ChargerProprietesDepuisBd()
        {
            PokemonsAchetes = ChargerPokemonsAchetes(this);
            ChargerIndexPokemonsEquipes();
            RechargerEmplacements();
        }

        public bool Equipe(Emplacement emplacement)
        {
            int position = (int)emplacement;

            return IndexPokemonsEquipes[position] > -1;
        }

        public int ChercherIndexDePokemonAchete(int idPokemonAchete)
        {
            return PokemonsAchetes.FindIndex(p => p.Id.Equals(idPokemonAchete));
        }

        public void EquiperPokemon(Emplacement emplacement, int indexPokemon)
        {
            int position = (int)emplacement;

            if (IndexValide(indexPokemon))
            {
                Pokemon pokemon = PokemonsAchetes[indexPokemon];
                Emplacements[position].EquiperPokemon(pokemon);
                SetPokemon(emplacement, Emplacements[position]);

                UpdateDepot(DepotId, IndexPokemonsEquipes.ToList());
            }
        }

        public void DesequiperPokemon(Emplacement emplacement)
        {
            int position = (int)emplacement;
            if (Equipe(emplacement))
            {
                Emplacements[position].DesequiperPokemon();
                SetPokemon(emplacement, Emplacements[position]);

                UpdateDepot(DepotId, IndexPokemonsEquipes.ToList());
            }
        }

        public void Echanger(Emplacement emplacement1, Emplacement emplacement2)
        {
            int position1 = (int)emplacement1;
            int position2 = (int)emplacement2;

            if (emplacement1 != emplacement2)
            {
                EmplacementPokemon pokemon1 = Emplacements[position1];

                Emplacements[position1] = Emplacements[position2];
                Emplacements[position2] = pokemon1;

                SetPokemon(emplacement1, Emplacements[position1]);
                SetPokemon(emplacement2, Emplacements[position2]);

                UpdateDepot(DepotId, IndexPokemonsEquipes.ToList());
            }
        }

        public void RechargerEmplacements()
        {
            for (int i = 0; i < 3; i++)
            {
                Emplacement emplacement = (Emplacement)i;

                if (!Equipe(emplacement))
                {
                    SetPokemon(emplacement, new EmplacementPokemon(emplacement));
                }
                else
                {
                    int indexPokemonEquipe = IndexPokemonsEquipes[i];
                    Pokemon pokemon = PokemonsAchetes[indexPokemonEquipe];

                    EmplacementPokemon pokemonEquipe = new EmplacementPokemon(emplacement);
                    pokemonEquipe.Pokemon = pokemon;
                    SetPokemon(emplacement, pokemonEquipe);
                }
            }
        }

        public void Evolution(int index, Pokemon evolution)
        {
            if (IndexValide(index))
            {
                PokemonsAchetes.RemoveAt(index);
                PokemonsAchetes.Insert(index, evolution);
            }
        }

        public void ChargerDepotParDefaut()
        {
            PokemonsAchetes.Add(Pokemon.Acheter(DepotId, "Bulbasaur"));
            EquiperPokemon(0, 0);
        }

        private void ChargerIndexPokemonsEquipes()
        {
            if (DepotExiste(DepotId))
            {
                IndexPokemonsEquipes = new ObservableCollection<int>(ChargerIndexPokemonsEquipes(this));
            }
            else
            {
                IndexPokemonsEquipes = new ObservableCollection<int>();
                for (int i = 0; i < 3; i++)
                {
                    IndexPokemonsEquipes.Add(-1);
                }
            }
        }

        private bool IndexValide(int indexPokemon)
        {
            return indexPokemon >= 0 && indexPokemon < PokemonsAchetes.Count;
        }

        private void SetPokemon(Emplacement emplacement, EmplacementPokemon pokemon)
        {
            int position = (int)emplacement;
            int indexPokemon = -1;

            EmplacementPokemon tempPokemonEquipe = pokemon;
            tempPokemonEquipe.Ordre = emplacement;
            if (tempPokemonEquipe.Equipe)
            {
                indexPokemon = ChercherIndexDePokemonAchete(pokemon.Pokemon.Id);
                tempPokemonEquipe.Pokemon.Emplacement = emplacement;

                Pokemon.UpdatePokemon(tempPokemonEquipe.Pokemon.Id, tempPokemonEquipe.Pokemon.Level, tempPokemonEquipe.Pokemon.Emplacement);
            }

            IndexPokemonsEquipes[position] = indexPokemon;

            if (Emplacements.Count == 3)
            {
                Emplacements.RemoveAt(position);
                Emplacements.Insert(position, tempPokemonEquipe);
            }
            else
            {
                Emplacements.Add(pokemon);
            }
        }
    }
}
