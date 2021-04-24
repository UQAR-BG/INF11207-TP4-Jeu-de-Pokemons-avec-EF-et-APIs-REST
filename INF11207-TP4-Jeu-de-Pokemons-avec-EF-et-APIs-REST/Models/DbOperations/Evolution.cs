using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Evolution
    {
        public static Evolution GetEvolution(int evolutionId)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Evolution evolution = context.Evolutions.Find(evolutionId);

            if (evolution == null)
            {
                return new Evolution();
            }

            return evolution;
        }
    }
}
