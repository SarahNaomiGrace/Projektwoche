using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class Spieler
    {
        public Inventar Inventar { get; set; }

        public Spieler()
        {
            Inventar = new Inventar();
        }
    }
}

// Das ist der Konstruktor, er erstellt ein neues Inventar für den Spieler.
// Mit {get;set} kann man Gegenstände ins Inventar hinzufügen und prüfen, 
// ob etwas im Inventar enthalten ist. 
