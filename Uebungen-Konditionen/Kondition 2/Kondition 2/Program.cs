using System;

namespace Kondition_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var eingabe1 = HoleEingabe1();
            var eingabe2 = HoleEingabe2();
            Auswertung(eingabe1, eingabe2);
        }

        internal static int HoleEingabe1()
        {
            Console.WriteLine("Erste Zahl:");
            var eingabe1 = Convert.ToInt32(Console.ReadLine());
            return eingabe1;
        }

        internal static int HoleEingabe2()
        {
            Console.WriteLine("Zweite Zahl:");
            var eingabe2 = Convert.ToInt32(Console.ReadLine());
            return eingabe2;
        }

        internal static void Auswertung(int eingabe1, int eingabe2)
        {
            if (eingabe1 > eingabe2)
                Console.WriteLine("die " + eingabe1 + " ist größer!");
            else if (eingabe2 > eingabe1)
                Console.WriteLine("die " + eingabe2 + " ist größer!");
            else
                Console.WriteLine("Die Eingaben sind gleich.");
        }
    }
}