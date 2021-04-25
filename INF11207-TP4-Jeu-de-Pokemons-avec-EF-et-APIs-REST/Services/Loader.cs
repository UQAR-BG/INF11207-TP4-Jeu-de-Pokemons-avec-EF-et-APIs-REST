using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace INF11207_TP4_Jeu_de_Pokemons_avec_EF_et_APIs_REST.Services
{
    public class Loader
    {
        public static bool PeutEtreCharge(string nomFichier)
        {
            return File.Exists(nomFichier);
        }

        public static bool Sauvegarder<T>(T objetASauvegarder, string nomFichier)
        {
            bool sauvegardeReussie = true;

            try
            {
                string objetSerialise = JsonConvert.SerializeObject(objetASauvegarder, Formatting.Indented);
                using (StreamWriter sauvegarde = File.CreateText(nomFichier))
                {
                    sauvegarde.Write(objetSerialise);
                }
            }
            catch (JsonSerializationException)
            {
                sauvegardeReussie = false;
            }

            return sauvegardeReussie;
        }

        public static List<T> ChargerDepuisFichier<T>(string nomFichier) where T : class
        {
            List<T> objets = new List<T>();
            if (!Charger(out objets, nomFichier))
            {
                MessageBox.Show($"Le fichier {nomFichier} est manquant. Le jeu pourra donc rencontrer des comportements étranges.",
                    "Données manquantes", MessageBoxButton.OK);
            }

            return objets;
        }

        public static bool Charger<T>(out T objetACharger, string nomFichier) where T : new()
        {
            bool chargementReussi = true;
            objetACharger = new();

            try
            {
                using (StreamReader contenuFichier = File.OpenText(nomFichier))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    objetACharger = (T)serializer.Deserialize(contenuFichier, typeof(T));
                }
            }
            catch (JsonSerializationException)
            {
                chargementReussi = false;
            }

            return chargementReussi;
        }

        public static string Lire(string nomFichier)
        {
            string contenuFichier;

            try
            {
                contenuFichier = File.ReadAllText(nomFichier);
            }
            catch (JsonSerializationException)
            {
                contenuFichier = "";
            }

            return contenuFichier;
        }

        public static string GenererJson<T>(T objetASeriaiser)
        {
            string objetSerialise;

            try
            {
                objetSerialise = JsonConvert.SerializeObject(objetASeriaiser, Formatting.Indented);
            } 
            catch (JsonSerializationException)
            {
                objetSerialise = "";
            }

            return objetSerialise;
        }

        public static T DeserialiserDepuisJson<T>(string objetSerialise) where T : new()
        {
            T objet;

            try
            {
                objet = JsonConvert.DeserializeObject<T>(objetSerialise);
            }
            catch (JsonSerializationException)
            {
                objet = new T();
            }
            return objet;
        }
    }
}
