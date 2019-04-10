using System;

namespace Konditionen
{
    class Start
    {
        internal void StarteProgramm()
        {
            var eingabe = HoleEingabe();
            WaehleKondition(eingabe);
        }

        public static string HoleEingabe()
        {
            Console.WriteLine("Wählen Sie eine der folgenden Optionen:\n");
            Console.WriteLine("[1] Gültig/ Ungültig?\n");
            Console.WriteLine("[2] Was ist größer?\n");
            Console.WriteLine("[3] Hoch- oder Querformat?\n");
            Console.WriteLine("[4] Blitzer - Strafmaß?\n");
            var eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);
            return eingabe;
        }

        internal static void WaehleKondition(string eingabe)
        {
            if (eingabe == "1")
                Kondition1.StartKon1();
            else
                Console.WriteLine("Geben Sie etwas gültiges ein!");
        }

        public static bool FrageObEnde()
        {
            Console.WriteLine("Beenden? j | n");

            if (Console.ReadLine() == "j")
                return true;
            return false;
        }
    }
}