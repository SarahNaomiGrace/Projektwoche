using System;
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
            if (!Hat(g.Name))
            {
                gegenstaende.Add(g);
                Console.WriteLine($" {g.Name} wurde zu deinem Inventar hinzugefügt.");
            }
        }

        public bool Hat(string name)
        {
            return gegenstaende.Any(item => item.Name == name);
        }
    }
}

// Mit der "Hinzufügen"-Methode werden Gegenstände ins Inventar hinzugefürt.
// Die gesammelten Gegenstände werden in "List" gespeichert. 

// Die "Hat"-Methode ermöglicht es zu überprüfen ob sich ein Gegenstand  bereits 
// im Inventar befindet. 
