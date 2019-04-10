namespace Schleifen
{
    public class Schleife3
    {
        public static string Verarbeitung(int zahl)
        {
            var ergebnisInt = FakultaetZahl(zahl);
            var ergebnisString = IntZuString(zahl, ergebnisInt);
            return ergebnisString;
        }

        internal static int FakultaetZahl(int zahl)
        {
            var ergebnisInt = 1;
            while (zahl > 0)
            {
                ergebnisInt = ergebnisInt * zahl;
                zahl--;
            }

            return ergebnisInt;
        }
        internal static string IntZuString(int zahl, int ergebnisInt)
        {
            return zahl + "! = " + ergebnisInt;
        }
    }
}