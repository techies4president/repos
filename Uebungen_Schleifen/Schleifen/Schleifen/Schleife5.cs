using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schleifen
{
    public class Schleife5
    {
        public static int Verarbeitung(string eingabe)
        {
            var intListe = new List<int>(StringZuInt(eingabe));
            return MaxWert(intListe);
        }
        internal static List<int> StringZuInt(string eingabe)
        {
            var intListe = eingabe.Split(',').ToList().ConvertAll(Convert.ToInt32);
            return intListe;
        }
        internal static int MaxWert(List<int> intListe)
        {
            return intListe.Max();
        }
    }
}