using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class Gegenstand
    {
        public string Name { get; set; }

        public Gegenstand(string name)
        {
            Name = name;
        }
    }
}

// Das ist der Konstruktor, er erstellt einen neuen Gegenstand und gibt ihm einen Namen.
// Mit {get;set} kann man den Namen des Gegenstandes auslesen oder verändern. 
// Dient ebenfalls, um Gegenstände zum Inventar hinzuzufügen.