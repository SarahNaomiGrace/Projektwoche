using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MeinProjekt
{
    public class ZweiterRaum : BasisRaum
    {
        public override BasisRaum Betreten(Spieler spieler)
        {
            Console.WriteLine();
            Console.WriteLine(" Du betrittst einen weiteren Raum, auch dieser hat keine Fenster.. ");
            Thread.Sleep(4000);
            Console.WriteLine();
            Console.WriteLine(" Es ist sehr dunkel, du kannst kaum etwas erkennen..");
            Thread.Sleep(3000);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" Was möchtest du tun?");
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine(" [1] Inventar durchsuchen.");
                Console.WriteLine(" [2] Raum abtasten.");
                Console.Write(" Eingabe: ");
                string eingabe = Console.ReadLine();
                
                if (eingabe == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine(" In deinem Inventar findest du eine Taschenlampe..");
                    Thread.Sleep(4000);
                    Console.WriteLine();
                    Console.WriteLine(" Jetzt leuchtest du mit dieser durch den Raum ...");
                    Thread.Sleep(2000);
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine(" Es ist keine Zimmertür zu sehen, nur ein paar Schränke stehen an den Wänden..");
                    Thread.Sleep(4000);
                    Console.WriteLine();
                    Console.WriteLine(" In der Mitte des Raumes auf dem Boden liegt ein Teppich..");
                    Thread.Sleep(4000);

                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Was machst du als nächstes?");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(" [1] Schränke durchsuchen.");
                        Console.WriteLine(" [2] Durch den Raum bewegen.");
                        Console.Write(" Eingabe: ");
                        string eingabe1 = Console.ReadLine();

                        if (eingabe1 == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Alle Schränke sind leer..");
                            Thread.Sleep(2000);
                            Console.Clear();
                            continue; 
                        }
                        else if (eingabe1 == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" Als du durch den Raum läufst, bemerkst du eine knarrende Stelle..");
                            Thread.Sleep(4000);
                            Console.WriteLine();
                            Console.WriteLine(" Genau auf dieser Stelle liegt der Teppich..");
                            Thread.Sleep(4000);
                            Console.WriteLine();
                            Console.WriteLine(" Du entfernst ihn und findest eine verschlossene Falltür.");
                            Thread.Sleep(4000);

                            while (true)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" Wie willst du die Tür öffnen?");
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.WriteLine(" [1] Brecheisen verwenden.");
                                Console.WriteLine(" [2] Schlüssel verwenden.");
                                Console.Write(" Eingabe: ");
                                string eingabe2 = Console.ReadLine();

                                if (eingabe2 == "1")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(" Du stellst bei dem Versuch, die Tür mit dem Brecheisen zu öffnen fest,");
                                    Thread.Sleep(4000);
                                    Console.WriteLine();
                                    Console.WriteLine(" dass ein Vorhängeschloss das Aufbrechen verhindert..");
                                    Thread.Sleep(5000);
                                    Console.WriteLine();
                                    Console.Clear();
                                    continue; 
                                }
                                else if (eingabe2 == "2")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(" Du versuchst mit dem Schlüssel das Vorhängeschloss zu öffnen ...");
                                    Thread.Sleep(2000);
                                    Console.ReadKey();
                                    Console.WriteLine();
                                    Console.WriteLine(" Das hat geklappt!!");
                                    Thread.Sleep(2000);
                                    Console.WriteLine();
                                    Console.WriteLine(" Du öffnest freudig die Falltür..");
                                    Thread.Sleep(3000);
                                    Console.WriteLine();
                                    Console.WriteLine(" Nun siehst du eine Leiter, die nach unten führt..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine();
                                    Console.WriteLine(" Du kannst Tageslicht erkennen..");
                                    Thread.Sleep(2000);
                                    Console.WriteLine();
                                    Console.WriteLine(" Mutig steigst du die Leiter hinab ...");
                                    Thread.Sleep(2000);
                                    Console.ReadKey();
                                    Console.Clear();
                                    return new KellerRaum();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine(" Ungültige Eingabe.");
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
                else if (eingabe == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine(" Du tastest die Wände des Raumes ab, ");
                    Thread.Sleep(2000);
                    Console.WriteLine();
                    Console.WriteLine(" und versuchst dir ohne Licht Orientierung zu verschaffen ...");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine(" Du kannst Schränke ertasten, traust dich aber nicht sie in der Dunkelheit zu öffnen..");
                    Thread.Sleep(4000);
                    Console.WriteLine();
                    Console.WriteLine(" Eine Zimmertür konntest du auch nicht finden..");
                    Thread.Sleep(4000);
                    Console.WriteLine();
                    Console.Clear();
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

// Der ZweiteRaum erbt ebenfalls von BasisRaum.
// Mit der override-Methode wird der Raum betreten. 

// Auch hier sorgen verschachtelte While-Schleifen für den logischen Spielablauf.
// break verlässt die aktuelle Schleife, continue wiederholt die aktuelle Schleife. 
// Mit return new betritt man den KellerRaum.
