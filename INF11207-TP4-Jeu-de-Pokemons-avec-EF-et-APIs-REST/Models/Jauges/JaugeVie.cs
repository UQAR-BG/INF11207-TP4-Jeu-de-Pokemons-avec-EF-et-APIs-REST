using Newtonsoft.Json;
using System;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class JaugeVie : Jauge
    {
        public JaugeVie(int value, int maxValue) : base(maxValue)
        {
            Value = value;
        }

        public JaugeVie(int maxValue) : base(maxValue) 
        {
            Value = MaxValue;
        }

        [JsonConstructor]
        public JaugeVie() { }

        public void Reinitialiser()
        {
            Value = MaxValue;
            UpdateHpGauge(GaugeId, Value);
        }

        public void PerdreDeLaVie(int hp)
        {
            if (Value >= hp)
            {
                Value -= hp;
            }
            else
            {
                Value = 0;
            }
            UpdateHpGauge(GaugeId, Value);
        }

        protected override void AugmenterNiveau(Personnage personnage, int niveauxEnPlus)
        {
            throw new NotImplementedException();
        }
    }
}
