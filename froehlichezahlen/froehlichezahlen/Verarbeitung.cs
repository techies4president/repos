using System.Collections.Generic;

namespace froehlichezahlen
{
    public class Verarbeitung
    {
        internal static bool StarteRechnung(int zahlen)
        {
            var ende = false;
            var froehlich = false;
            do
            {
                var intArray = HoleIntArray(zahlen);
                zahlen = PotenziereIntArray(intArray);
                ende = PruefeLoesung(zahlen, ende);
            } while (!ende);

            froehlich = PruefeFroehlich(zahlen, froehlich);
            return froehlich;
        }

        internal static int[] HoleIntArray(int zahlen)
        {
            var intArray = new List<int>();
            while (zahlen > 0)
            {
                intArray.Add(zahlen % 10);
                zahlen = zahlen / 10;
            }

            intArray.Reverse();
            return intArray.ToArray();
        }

        internal static int PotenziereIntArray(int[] intArray)
        {
            var zahlen = 0;
            foreach (var t in intArray)
                zahlen = zahlen + t * t;

            return zahlen;
        }

        internal static bool PruefeLoesung(int loesung, bool ende)
        {
            if (loesung == 4) return ende = true;
            if (loesung == 1)
                return ende = true;
            return ende = false;
        }

        internal static bool PruefeFroehlich(int loesung, bool froehlich)
        {
            if (loesung == 1)
                return froehlich = true;
            return froehlich = false;
        }
    }
}