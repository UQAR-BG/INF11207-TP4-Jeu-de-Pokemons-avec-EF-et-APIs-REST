using System.Linq;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public partial class Attaque
    {
        public static int GetAttaqueId(string nomAttaque)
        {
            int attaqueId = -1;
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();
            Attaque attaque = context.Attaques.FirstOrDefault(a => a.Name.Equals(nomAttaque));

            if (attaque != null)
            {
                attaqueId = attaque.AttaqueId;
            }

            return attaqueId;
        }
    }
}
