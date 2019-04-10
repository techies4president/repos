using System;
using System.Linq;

namespace Konditionen
{
    class Kondition1
    {
        internal static void StartKon1()
        {


            var eingabe = HoleEingabe();
            PrüfeObImBereich(eingabe);
        }

        internal static int HoleEingabe()
        {
            Console.WriteLine("Bitte eine Zahl zwischen 1 und 10 eingeben:");
            return Convert.ToInt32(Console.ReadLine());
        }

        internal static void PrüfeObImBereich(int eingabe)
        {
            if (Enumerable.Range(1, 10).Contains(eingabe))
            {
                Console.WriteLine(eingabe);
                Console.WriteLine("gültig");
            }
            else
            {
                Console.WriteLine(eingabe);
                Console.WriteLine("ungültig");
            }

            Console.ReadKey();
        }
    }
}