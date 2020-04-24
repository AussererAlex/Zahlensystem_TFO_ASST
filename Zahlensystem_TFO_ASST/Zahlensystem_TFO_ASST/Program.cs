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
            // Console.WriteLine("\nDezimalzahl: "+ Dezimal(Zahl)); um meine Methode aufzurufen und das Ergebnis auszugeben!
            Console.ReadKey();
        }

        //Dezimal
        static string Dezimal(string Zahl)
        {
            Zahl = Convert.ToInt32(Zahl, 2).ToString();
            return (Zahl);

        }
    }
}
