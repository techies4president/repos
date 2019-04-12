using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListen
{
    class Array5
    {
        internal static List<int> Verarbeitung()
        {
            var geprueft = false;
            var eingabe = "";
            while (!geprueft)
            {
                eingabe = HoleEingabe();
                geprueft = PruefeEingabe(eingabe);
            }
            return Ausgabe(eingabe);
        }

        internal static string HoleEingabe()
        {
            Console.WriteLine("Eingabe:");
            return Console.ReadLine();
        }

        internal static bool PruefeEingabe(string eingabe)
        {
            var ausgabe = new List<string>(eingabe);
            ausgabe.RemoveAll(",")
           Convert.
            return ausgabe;
        }
    }
}
