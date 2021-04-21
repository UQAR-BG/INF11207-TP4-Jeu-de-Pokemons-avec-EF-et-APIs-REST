using System.Windows.Input;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Interfaces
{
    public interface INombreEnEntree
    {
        void VerifierSiEntreeEstNombre(object sender, TextCompositionEventArgs e);
    }
}
