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
            
            Titel("Zahlensystem", ConsoleColor.Green);


            
            Console.Write("\nWählen Sie die Umwandlung (0 = Binär => Dezimal / 1 = Binär => Hexadezimal / 2 = Ende): ");
            string wahl = Console.ReadLine();
           
            while (wahl != "2")
            {
               
               
                if (wahl == "0")
                {
                    //Binär => Dezimal 
                    string Zahl = BinaerzahlEinlesen();
                  
                }
                else
                {
                    //Binär => Hexadezimal
                    string Zahl = BinaerzahlEinlesen();
                    string ErgHex = Hexadezimal(Zahl);
                    Console.WriteLine("Das Ergebniss ist : "+ ErgHex);
                }
                
                Console.Write("\nWählen Sie die Umwandlung (0 = Binär => Dezimal / 1 = Binär => Hexadezimal / 2 = Ende): ");
                wahl = Console.ReadLine();
            }
            
        
        }
     
        //Titelmethote
        static void Titel(string titel, ConsoleColor textfarbe)
        {
            int breite = Console.WindowWidth;
            int textlen = titel.Length;
            ConsoleColor aktTextFarbe = Console.ForegroundColor;
            Console.Clear();
            Console.ForegroundColor = textfarbe;

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < (breite - textlen) / 2; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(titel);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = aktTextFarbe;
        }

        //Binärzahl einlesen 
        public static string BinaerzahlEinlesen()
        {
            Console.Write("\nGeben Sie die Binärzahl ein (das kleinste Bit ist ganz rechts): ");
            string Binaerzahl = Console.ReadLine();

            while (Binaerzahl.Contains("2") || Binaerzahl.Contains("3") || Binaerzahl.Contains("4") || Binaerzahl.Contains("5") || Binaerzahl.Contains("6") || Binaerzahl.Contains("7") || Binaerzahl.Contains("8") || Binaerzahl.Contains("9"))
            {
                Console.Clear();
                Console.Write("Fehler!! Die Zahl darf nur 1 oder 0 enthalten");

                Console.Write("\nGeben Sie die Binärzahl ein (das kleinste Bit ist ganz rechts): ");
                Binaerzahl = Console.ReadLine();
            }

            return Binaerzahl;
        }
        /// <summary>
        /// Methode zur Umwandlung einer Binärzahl in Hexadezimal - Fabian Sieder
        /// </summary>
        /// <param name="Binaerzahl">Binaerzahl, welche umgewandelt werden soll</param>
        /// <returns>Hexadezimalzahl als string</returns>
        static string Hexadezimal(string Binaerzahl)
        {
            return Convert.ToInt32(Binaerzahl, 2).ToString("X");
          
        }
    }
}
