using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Enums;
using INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Windows;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Models
{
    public class EfficaciteAttaque
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int EfficaciteId { get; set; }
        public OrigineType Attack { get; set; }
        public OrigineType Defend { get; set; }
        public double Effectiveness { get; set; }

        public static double ChercherEfficacite(OrigineType agresseur, OrigineType defenseur)
        {
            JeuDePokemonsDbContext context = new JeuDePokemonsDbContext();

            return context.Efficacites.Where(e => e.Attack == agresseur && e.Defend == defenseur).FirstOrDefault().Effectiveness;
        }

        public static List<EfficaciteAttaque> ChargerEfficacitesDepuisFichier()
        {
            List<EfficaciteAttaque> _efficacites = new List<EfficaciteAttaque>();
            if (!Loader.Charger(out _efficacites, "Resources/Data/AttacksEffectiveness.json"))
            {
                MessageBox.Show("Le fichier AttacksEffectiveness.json est manquant. Le jeu pourra donc rencontrer des comportements étranges.",
                    "Données manquantes", MessageBoxButton.OK);
            }

            for (int i = 0; i < _efficacites.Count; i++)
            {
                _efficacites[i].EfficaciteId = i + 1;
            }

            return _efficacites;
        }
    }
}
