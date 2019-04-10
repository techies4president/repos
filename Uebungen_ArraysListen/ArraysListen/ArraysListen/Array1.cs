using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListen
{
    public class Array1
    {
        internal void Verarbeitung()
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
            int likes = liste.Count - 1;
            if (likes == 0)
            {
                return "";
            }
            else if(likes == 1)
            {
                return +liste.inde+" mag deinen Post
            }
        }
    }
}
