using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MeinProjekt
{
    public class AnfangsRaum : BasisRaum
    {
        public override BasisRaum Betreten(Spieler spieler)
        {
            Console.WriteLine(" Du wachst auf ..");
            Console.WriteLine(" .. und findest dich in einem Raum ohne Fenster wieder ..");
            Console.WriteLine(" .. du siehst nur ein kleines Licht an der Wand flackern ..");
            Console.WriteLine(" .. beim Umsehen erkennst du eine Zimmertür ..");
            Console.WriteLine();
            Console.WriteLine(" Was machst du als nächstes?");
            Console.WriteLine("[1] Versuchen die Tür zu öffnen");
            Console.WriteLine("[2] Den Raum nach einem nützlichen Gegenstand durchsuchen");
            string eingabe = Console.ReadLine();
            
            switch (eingabe)
            {
                case "1":
                    Console.WriteLine(" Die Tür ist verschlossen.");
                    return this;
                case "2":
                    Console.WriteLine(" Du findest ein Brecheisen.");
                    spieler.Inventar.Hinzufuegen(new Gegenstand("Brecheisen"));
                    return new ZweiterRaum();
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    return this;
            }
        }
    }
}
