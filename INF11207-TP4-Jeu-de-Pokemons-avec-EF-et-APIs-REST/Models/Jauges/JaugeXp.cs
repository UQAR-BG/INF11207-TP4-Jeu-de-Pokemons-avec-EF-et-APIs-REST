using Newtonsoft.Json;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class JaugeXp : Jauge
    {
        public JaugeXp(int maxValue) : base(maxValue) { }

        [JsonConstructor]
        public JaugeXp() { }

        public int AjouterExperience(Personnage personnage, int experience)
        {
            int niveauxEnPlus = 0;
            int experienceTotale = Value + experience;

            if (experience >= 0)
            {
                Value = experienceTotale % MaxValue;
                niveauxEnPlus += experienceTotale / MaxValue;
            }

            AugmenterNiveau(personnage, niveauxEnPlus);
            return niveauxEnPlus;
        }

        protected override void AugmenterNiveau(Personnage personnage, int niveauxEnPlus)
        {
            personnage.Level += niveauxEnPlus;
        }
    }
}
