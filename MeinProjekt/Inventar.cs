using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class Inventar
    {
        private List<Gegenstand> gegenstaende = new List<Gegenstand>();

        public void Hinzufuegen(Gegenstand g)
        {
            if (!gegenstaende.Any(item => item.Name == g.Name))
            {
                gegenstaende.Add(g);
                Console.WriteLine($"{g.Name} zu deinem Inventar hinzugefügt.");
            }
        }


        public bool Hat(string name)
        {
            return gegenstaende.Any(item => item.Name == name);
        }

        public void Zeige()
        {
            Console.WriteLine("Inventar:");
            foreach (var item in gegenstaende)
            {
                Console.WriteLine("- " + item.Name);
            }
        }
    }

}
