using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListen
{
    class Array4
    {
        internal void Verarbeitung()
        {
            var liste = new List<int>(); 
            do
            {
                HoleUndListe(liste);
                Ausgabe(liste);
            }
            while (!HoleUndListe(liste));

           
        }

        internal static bool HoleUndListe(List<int>liste)
        {
            Console.WriteLine("Gib eine Zahl ein:");
            var eingabe = Console.ReadLine();
            if (eingabe?.ToLower() == "ende")
                return true;
            else
            {
                liste.Add(Convert.ToInt32(eingabe));
                return false;
            }
        }

        internal static List<int> Ausgabe(List<int> liste)
        {
            var ausgabe = new List<int>();
            foreach (int zahl in liste)
            {
                if (!ausgabe.Contains(zahl))
                {
                    ausgabe.Add(zahl);
                }
            }
            return ausgabe;
        }
    }
    
}
