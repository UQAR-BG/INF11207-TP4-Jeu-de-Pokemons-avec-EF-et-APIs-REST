using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels;
using Newtonsoft.Json;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public abstract class Personnage : Binding
    {
        protected bool isValid;

        private string name;
        private int level;

        [JsonIgnore]
        private JaugeXp xpGauge;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    SetIsValid();
                }
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    OnPropertyChanged();
                }
            }
        }

        public int XpGaugeId { get; set; }

        [JsonIgnore]
        public JaugeXp XpGauge
        {
            get { return xpGauge; }
            set
            {
                if (xpGauge != value)
                {
                    xpGauge = value;
                    OnPropertyChanged();
                }
            }
        }

        public Personnage(string name = "", int level = 1, int experiencePerLevel = 100)
        {
            Name = name;
            Level = level;
            XpGauge = new JaugeXp(experiencePerLevel);
        }

        protected virtual void SetIsValid()
        {
            isValid = !string.IsNullOrEmpty(Name);
        }
    }
}
