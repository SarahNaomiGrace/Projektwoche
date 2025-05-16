using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Threading;

using System;
using System.Threading;

namespace MeinProjekt
{
    public class KellerRaum : BasisRaum
    {
        const int gesuchteZahl = 14;
        int versuche = 3;

        public override BasisRaum Betreten(Spieler spieler)
        {
            Console.WriteLine();
            Console.WriteLine(" Du stehst jetzt in einem Kellerraum..");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine(" Beim Umsehen entdeckst du ein paar schmale aber vergitterte Fenster..");
            Thread.Sleep(4000);
            Console.WriteLine();
            Console.WriteLine(" Dann siehst du eine schwere Eisentür, die ins Freie führt..");
            Thread.Sleep(4000);
            Console.WriteLine();
            Console.WriteLine(" Leider ist auch diese Tür wieder verschlossen – diesmal mit einem Zahlenschloss.");
            Thread.Sleep(4000);

            bool hinweisGelesen = false;

            while (versuche > 0)
            {
                Console.WriteLine();
                Console.WriteLine(" Was möchtest du tun?");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine(" [1] Den Kellerraum nach einem Hinweis durchsuchen.");
                Console.WriteLine(" [2] Eine Zahl eingeben.");
                Console.Write(" Eingabe: ");
                string eingabe = Console.ReadLine();

                if (eingabe == "1")
                {
                    if (!hinweisGelesen)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Du findest einen Notizzettel, auf dem steht:");
                        Thread.Sleep(3000);
                        Console.WriteLine();
                        Console.WriteLine(" >> Ein Wesen krabbelt, acht Beine trägt's,");
                        Thread.Sleep(3000);
                        Console.WriteLine(" ein anderes auf zweien durch das Leben geht,");
                        Thread.Sleep(3000);
                        Console.WriteLine(" das letzte bellt und läuft auf vier.");
                        Thread.Sleep(3000);
                        Console.WriteLine(" - Gemeinsam stehen sie nun vor dir. << ");
                        hinweisGelesen = true;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Du hast den Hinweis bereits gefunden.");
                        Thread.Sleep(3000);
                    }
                }
                else if (eingabe == "2")
                {
                    Console.WriteLine();
                    Console.Write(" Gib eine Zahl zwischen 1 und 100 ein: ");
                    string zahlEingabe = Console.ReadLine();
                    Thread.Sleep(1000);

                    if (int.TryParse(zahlEingabe, out int zahl))
                    {
                        if (zahl < 1 || zahl > 100)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Ungültige Eingabe.");
                            Console.WriteLine();
                        }
                        else if (zahl == gesuchteZahl)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Das war richtig!!");
                            Thread.Sleep(2000);
                            Console.WriteLine();
                            Console.WriteLine(" Die Tür ist offen und du kannst fliehen!!");
                            Thread.Sleep(2000);
                            return null;
                        }
                        else
                        {
                            versuche--;
                            if (versuche > 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine($" Das war falsch, du hast noch {versuche} Versuch(e).");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Ungültige Eingabe.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Ungültige Eingabe.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine(" Du hast alle Versuche verbraucht..");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine(" Nun musst du hoffen, dass dich irgendjemand rettet..");
            Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine(" > Spielende < ");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine(" Möchtest du nochmal spielen?");
            Console.WriteLine(" [1] Ja");
            Console.WriteLine(" [2] Nein");
            Console.Write(" Eingabe: ");
            string neuStart = Console.ReadLine();

            if (neuStart == "1")
            {
                Console.Clear();
                return new AnfangsRaum();
            }

            Console.WriteLine();
            Console.WriteLine(" Danke fürs Spielen, bis zum nächsten Mal! ");
            Thread.Sleep(2000);
            Environment.Exit(0);
            return null;
        }
    }
}



// Der KellerRaum erbt "Betreten" vom BasisRaum. Hier wird beschrieben, was im zweiten Raum passiert.
// const = für Konstante, der int-Wert kann nicht verändert werden
