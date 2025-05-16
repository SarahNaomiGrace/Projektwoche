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
                Console.WriteLine();
                Console.WriteLine(" Du schreckst wie aus einem Alptraum auf.. Dein Herz pocht.. ");
                Thread.Sleep(4000);
                Console.WriteLine();
                Console.WriteLine(" Was ist passiert? Wo bist du? Du schaust dich langsam um.. ");
                Thread.Sleep(4000);
                Console.WriteLine();
                Console.WriteLine(" Du findest dich in einem düsteren Raum ohne Fenster wieder..");
                Thread.Sleep(4000);
                Console.WriteLine();
                Console.WriteLine(" Du siehst nur ein kleines Licht an der Wand flackern..");
                Thread.Sleep(4000);
                Console.WriteLine();
                Console.WriteLine(" Beim Umsehen erkennst du eine Zimmertür..");
                Thread.Sleep(4000);

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Was machst du als nächstes?");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine(" [1] Versuchen die Tür zu öffnen.");
                    Console.WriteLine(" [2] Den Raum nach einem nützlichen Gegenstand durchsuchen.");
                    Console.Write(" Eingabe: ");
                    string eingabe = Console.ReadLine();

                    if (eingabe == "1")
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Die Tür ist verschlossen.");
                        Console.WriteLine();
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else if (eingabe == "2")
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Du hast einen Schlüssel gefunden!");
                        Thread.Sleep(2000);
                        Console.WriteLine();
                        spieler.Inventar.Hinzufuegen(new Gegenstand("Der Schlüssel"));
                        Thread.Sleep(2000);

                    bool aufDerSuche = true;

                        while (aufDerSuche)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Was möchtest du tun?");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine(" [1] Probieren die Tür mit dem Schlüssel aufzuschließen.");
                            Console.WriteLine(" [2] Weiter suchen.");
                            Console.Write(" Eingabe: ");
                            string eingabe1 = Console.ReadLine();

                            if (eingabe1 == "1")
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Der Schlüssel passt nicht zu dieser Tür..");
                                Thread.Sleep(4000);
                                Console.Clear();
                            }
                            else if (eingabe1 == "2")
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Du findest ein Brecheisen..");
                                Thread.Sleep(3000);
                                Console.WriteLine();
                                spieler.Inventar.Hinzufuegen(new Gegenstand("Das Brecheisen"));
                                Thread.Sleep(3000);
                                Console.WriteLine();
                                Console.WriteLine(" Mit diesem versuchst du jetzt die Zimmertür aufzubrechen ...");
                                Thread.Sleep(2000);
                                Console.ReadKey();
                                Console.WriteLine();
                                Console.WriteLine(" Geschafft!!");
                                Thread.Sleep(3000);
                                Console.WriteLine();
                                Console.WriteLine(" Du gehst durch die aufgebrochene Tür ... ");
                                Console.ReadKey();
                                Thread.Sleep(1000);

                                aufDerSuche = false;
                                Console.Clear();
                                return new ZweiterRaum();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ungültige Eingabe.");
                                Console.WriteLine();
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
            }
        }
    }


// Der AnfangsRaum erbt "Betreten" vom BasisRaum. Hier wird beschrieben, was im ersten Raum passiert.

// Mit "Hinzufuegen" werden neue Gegenstände zum Inventar hinzugefügt. 

// Verschachtelte While-Schleifen sorgen für logischen Spielablauf.
// Mit "return new" wird der nächste Raum betreten. 