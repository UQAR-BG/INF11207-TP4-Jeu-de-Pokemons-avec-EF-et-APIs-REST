using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public abstract class Jauge : Binding
    {
        private int value;
        private int maxValue;

        public int GaugeId { get; set; }

        public int Value
        {
            get { return value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    OnPropertyChanged();
                }
            }
        }

        public int MaxValue 
        { 
            get { return maxValue; }
            set
            {
                if (maxValue != value)
                {
                    maxValue = value;
                    OnPropertyChanged();
                }
            }
        }

        public Jauge(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public Jauge() { }

        protected abstract void AugmenterNiveau(Personnage personnage, int niveauxEnPlus);

        public static void CreerJauges(Pokemon pokemon)
        {
            JaugeXp.AddXpGauge(pokemon.XpGauge);
            pokemon.XpGaugeId = JaugeXp.GetLatestId();

            JaugeVie.AddHpGauge(pokemon.HpGauge);
            pokemon.HpGaugeId = JaugeVie.GetLatestId();
        }
    }
}
