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
                  
                }
                else
                {
                    //Binär => Hexadezimal
                  
                }

                Console.Write("\nWählen Sie die Umwandlung (0 = Binär => Dezimal / 1 = Binär => Hexadezimal / 2 = Ende): ");
                wahl = Console.ReadLine();
            }
            
        
        }
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
    }
}
