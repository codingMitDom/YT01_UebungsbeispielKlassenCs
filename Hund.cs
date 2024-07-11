using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTutorial
{
    internal class Hund
    {
        // Felder
        public string name; // Achtung - in der Praxis nicht public verwenden!
        public int alter; // Achtung - in der Praxis nicht public verwenden!


        // Methoden
        // Methode, die Wuff auf der Konsole ausgibt
        public void Bellen()
        {
            Console.WriteLine($"Der Hund {name} bellt!");
            Console.WriteLine("Wuff");
        }
    }
}
