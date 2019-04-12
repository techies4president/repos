using System;
using System.Collections.Generic;

namespace ArraysListen
{
    internal class Array1
    {
        internal static void Verarbeitung()
        {
            var ende = false;
            var liste = new List<string>();
            while (!ende)
            {
                var eingabe = HoleEingabe();
                FuelleListe(liste, eingabe);
                ende = PruefeListe(liste);
            }

            VerarbeiteListe(liste);
        }

        internal static string HoleEingabe()
        {
            Console.WriteLine("Bitte gib einen Namen ein:");
            return Console.ReadLine();
        }

        internal static List<string> FuelleListe(List<string> liste, string eingabe)
        {
            liste.Add(eingabe);
            return liste;
        }

        internal static bool PruefeListe(List<string> liste)
        {
            return liste.Contains("");
        }
        internal static string VerarbeiteListe(List<string> liste)
        {
            var likes = liste.Count - 1;
            switch (likes)
            {
                case 1:
                    return liste[0] + " mag deinen Post";
                case 2:
                    return liste[0] + " und " + liste[1] + " mögen deinen Post";
                default:
                {
                    if (likes >= 3)
                        return liste[0] + ", " + liste[1] + " und " + (likes - 2) + " weitere mögen deinen Post";
                    return "";
                }
            }
        }
    }
}