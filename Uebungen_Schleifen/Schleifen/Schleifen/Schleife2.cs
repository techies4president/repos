using System;

namespace Schleifen
{
    public class Schleife2
    {
        public static int Verarbeitung(string eingabeString)
        {
            return SummeListe(eingabeString);
        }

        internal static int SummeListe(string eingabeString)
        {
            var zeichenArray = eingabeString.Split('\n');
            var summe = 0;
            foreach (var zeichen in zeichenArray)
                if (zeichen != "ok")
                    summe = summe + Convert.ToInt32(zeichen);

            return summe;
        }
    }
}