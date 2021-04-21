using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class EfficaciteAttaque
    {
        public OrigineType Attack { get; set; }
        public OrigineType Defend { get; set; }
        public double Effectiveness { get; set; }
    }
}
