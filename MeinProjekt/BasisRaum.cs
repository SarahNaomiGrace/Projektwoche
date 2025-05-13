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
