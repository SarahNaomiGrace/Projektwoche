using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public abstract class BasisRaum
    {
        public abstract BasisRaum Betreten(Spieler spieler);
    }
}

// Abstrakte  Basis-Klasse, von der alle anderen Räume erben können. 
// Die  Methode "Betreten" sollen die anderen Klassen übernehmen. 