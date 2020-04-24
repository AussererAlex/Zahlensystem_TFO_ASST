using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensystem_TFO_ASST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }


        public static string BinaerzahlEinlesen()
        {
            Console.Write("Geben Sie die Binärzahl ein (das kleinste Bit ist ganz rechts): ");
            string Binaerzahl = Console.ReadLine();

            while (Binaerzahl.Contains("2") || Binaerzahl.Contains("3") || Binaerzahl.Contains("4") || Binaerzahl.Contains("5") || Binaerzahl.Contains("6") || Binaerzahl.Contains("7") || Binaerzahl.Contains("8") || Binaerzahl.Contains("9"))
            {
                Console.Clear();
                Console.Write("Fehler!! Die Zahl darf nur 1 oder 0 enthalten");

                Console.Write("\nGeben Sie die Binärzahl ein (das kleinste Bit ist ganz rechts): ");
                Binaerzahl = Console.ReadLine();
            }

            return Binaerzahl;
        }// Ende der Methode
    }
}
