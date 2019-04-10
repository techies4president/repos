using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Schleife4
{
    public class Schleife4
    {
        public static void Main()
        {
            var versuche = 4;
            var pruefzahl = ErstellePruefzahl();
            while (versuche > 0)
            {
                var eingabe = HoleEingabe(pruefzahl);
                versuche--;
                PruefeEingabe(ref versuche, eingabe, pruefzahl);
            }
        }

        internal static int ErstellePruefzahl()
        {
            WriteLine("Errate die Zahl zwischen 1 und 10!");
            Random pruefzahl = new Random();
            return Convert.ToInt32(pruefzahl.Next(1, 10));

        }
        internal static int HoleEingabe(int pruefzahl)
        {
            WriteLine("Prüfzahl:"+pruefzahl);
            int eingabe = Convert.ToInt32(ReadLine());
            return eingabe;
        }
        internal static int PruefeEingabe(ref int versuche, int eingabe, int pruefzahl)
        {
            if (eingabe == pruefzahl)
            {
                WriteLine("Das war der "+(4-versuche)+". Versuch.\nGewonnen");
                return versuche = 0;
            }
            else if (versuche != 0)
            {
                WriteLine("Das war der "+(4-versuche)+". Versuch.\n");
                return versuche;
            }
            else
            {
                WriteLine("Verloren");
                return versuche;
            }
        }
    }
}