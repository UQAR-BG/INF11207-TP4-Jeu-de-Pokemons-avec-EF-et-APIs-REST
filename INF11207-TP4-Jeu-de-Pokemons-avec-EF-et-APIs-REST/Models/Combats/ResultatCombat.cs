namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class ResultatCombat
    {
        private bool victoire;
        private int mise;
        private int experience;

        public bool Victoire { get { return victoire; } }
        public int Mise { get { return mise; } }
        public int Experience { get { return experience; } }

        public ResultatCombat(bool victoire, int mise, int experience)
        {
            this.victoire = victoire;
            this.mise = mise;
            this.experience = experience;
        }
    }
}
