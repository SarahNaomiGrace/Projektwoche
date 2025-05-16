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
                Begruessung();

                bool weiterspielen = true;

                while (weiterspielen)
                {
                    bool spielStarten = Hauptmenue();

                    if (spielStarten)
                    {
                    spieler = new Spieler();
                    BasisRaum aktuellerRaum = new AnfangsRaum();

                        while (aktuellerRaum != null)
                        {
                            aktuellerRaum = aktuellerRaum.Betreten(spieler);
                        }
                            Console.WriteLine();
                            Console.WriteLine(" Das Spiel wurde beendet.");
                            Console.WriteLine();
                            Console.WriteLine(" Möchtest du nochmal spielen?");
                            Console.WriteLine(" [1] Ja");
                            Console.WriteLine(" [2] Nein");
                            Console.Write(" Eingabe: ");
                            string eingabe = Console.ReadLine();
                            weiterspielen = (eingabe == "1");
                            Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Danke fürs Spielen, bis zum nächsten Mal! ");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                }
                Console.WriteLine();
                Console.WriteLine(" Danke fürs Spielen, bis zum nächsten Mal! ");
                Thread.Sleep(2000);
            }


            private void Begruessung()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" Herzlich Willkommen zu Särah's EscapeRoom!! ");
                Console.WriteLine(" Schön, dass du da bist & viel Spaß!! ");
                Console.WriteLine();
            }


            private bool Hauptmenue()
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Hauptmenü:");
                    Console.WriteLine(" [1] Spiel starten");
                    Console.WriteLine(" [2] Beenden");
                    Console.Write(" Eingabe: ");
                    string eingabe = Console.ReadLine();

                    if (eingabe == "1")
                    {
                        Thread.Sleep(1000);
                        Console.Clear();
                        Thread.Sleep(1000);
                        return true;
                    }
                    else if (eingabe == "2")
                    {
                        return false;
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

// Die Variable "Spieler" speichert den aktuellen Spieler. 
// Der AnfangsRaum erbt von der Basisklasse BasisRaum, hier beginnt das Spiel.

// Mit Starte() startet das Spiel, dann wird die Begrüßung gezeigt, dann das 
// Hauptmenü und der Spieler entscheidet, ob er spielen oder beenden möchte. 
// Außerdem wird am Ende des Spiels gefragt, ob man noch einmal spielen möchte. 

// Innerhalb von Begrüßung() ist die Begrüßung deklariert und wird einmal zu Beginn aufgerufen.

// Im Hauptmenü() ist das Hauptmenü deklariert und gibt true oder false zurück.

// Integriert sind While-Schleifen, die den Spielablauf steuern. 

// "Environment.Exit(0)" beendet das Programm. 
// "Thread.Sleep()" lässt einen Timer ablaufen, so sind die Übergänge nicht so abrupt. 

