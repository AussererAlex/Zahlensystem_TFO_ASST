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
