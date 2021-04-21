namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class WindowSize
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public WindowSize(int height, int width)
        {
            Width = width;
            Height = height;
        }
    }
}
