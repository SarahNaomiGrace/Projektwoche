using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class Spiel
    {
        private Spieler spieler;

        public void Starte()
        {
            Console.WriteLine("Willkommen im EscapeRoom!");
            Hauptmenü();
        }

        private void Hauptmenü()
        {
            while (true)
            {
                Console.WriteLine("[1] Spiel starten");
                Console.WriteLine("[2] Beenden");
                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    StarteSpiel();
                    break;
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine("Das Spiel wird beendet...");
                    return;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }
        }

        private void StarteSpiel()
        {
            spieler = new Spieler();
            BasisRaum aktuellerRaum = new Raum1();

            while (aktuellerRaum != null)
            {
                aktuellerRaum = aktuellerRaum.Betreten(spieler);
            }
            Console.WriteLine("Spiel beendet."!);
        }
    }
}