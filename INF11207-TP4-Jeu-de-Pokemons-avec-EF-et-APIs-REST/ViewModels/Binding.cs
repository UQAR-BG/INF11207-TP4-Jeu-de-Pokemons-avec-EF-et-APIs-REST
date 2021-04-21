using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.ViewModels
{
    public class Binding : INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T valeurActuelle, T nouvelleValeur, [CallerMemberName] string propertyName = null)
        {
            if (Equals(valeurActuelle, nouvelleValeur))
            {
                return;
            }

            valeurActuelle = nouvelleValeur;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
