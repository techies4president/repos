using System;

namespace Konditionen3und4
{
    internal class Kondition4
    {
        internal static string Verarbeitung(string gemessen, string maximal)
        {
            return PruefeGeschwindigkeit(gemessen, maximal);
        }

        internal static string PruefeGeschwindigkeit(string gemessen, string maximal)
        {
            var intGem = Convert.ToInt32(gemessen);
            var intMax = Convert.ToInt32(maximal);
            if (intGem <= intMax) return "OK";
            if (intGem - intMax < 5) return "Glück gehabt! 0 Punkte.";
            var i = 0;
            while (intGem - intMax >= 5)
            {
                intGem = intGem - 5;
                i += 1;
            }

            if (i < 12)
                return Convert.ToString(i) + " Punkte kassiert.";
            return Convert.ToString(i) + " Punkte kassiert.\nFührerschein wird entzogen";
        }
    }
}