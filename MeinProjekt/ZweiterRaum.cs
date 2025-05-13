using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class ZweiterRaum : BasisRaum
    {
        public override BasisRaum Betreten(Spieler spieler)
        {
            Console.WriteLine(" Du öffnest die Tür und betrittst einen ..");
            Console.WriteLine(" einen weiteren Raum - ohne Fenster ..");
            Console.WriteLine(" Hier ist es sehr dunkel, du kannst kaum etwas erkennen ..");
            
        }
    }
    {
    }
}
