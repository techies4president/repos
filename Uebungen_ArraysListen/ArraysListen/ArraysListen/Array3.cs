using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListen
{
    internal class Array3
    {
        internal static List<int> Verarbeitung()
        {
            var liste = new List<int>();
            while (liste.Count < 5)
            {
                var eingabe = HoleEingabe();
                PruefeUndListe(liste, eingabe);
            }

            return Ausgabe(liste);
        }

        internal static int HoleEingabe()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        internal static void PruefeUndListe(List<int> liste, int eingabe)
        {
            if (liste.Contains(eingabe))
            {
                Console.WriteLine("Zahl bereits vorhanden!\nGeben Sie eine gültige Zahl ein:");
            }
            else
            {
                liste.Add(eingabe);
            }
        }
        internal static List<int> Ausgabe(List<int> liste)
        {
            liste.Sort();
            return liste;
        }
    }
}