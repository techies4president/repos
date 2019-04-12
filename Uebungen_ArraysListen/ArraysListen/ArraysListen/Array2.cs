using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListen
{
    internal class Array2
    {
        internal static string Verarbeitung(string eingabe)
        {
            var eingabeListe = StringZuListe(eingabe);
            return Umkehren(eingabeListe);
        }

        internal static List<char> StringZuListe(string eingabe)
        {
            return new List<char>(eingabe.ToLower());
        }

        internal static string Umkehren(List<char> eingabeListe)
        {
            eingabeListe.Reverse();
            eingabeListe[0] = char.ToUpperInvariant(eingabeListe[0]);
            string ausgabe = string.Join("",eingabeListe.ToArray());
            return ausgabe;
        }
    }
}
