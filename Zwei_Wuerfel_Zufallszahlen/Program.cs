using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.X86;

namespace Zwei_Wuerfel_Zufallszahlen
{
    class Program
    {
        // Christian Brand learns C# :-)
        static void Main(string[] args)
        {
            //Ausgabe des Programmnamens in der Console
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  Erzeugung von zwei Zufallszahlen sowie Berechnung des Ergebnises und Speicherung der Daten in einem 2D-Array");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            // Eingabeaufforderung und Variablen sowie Umwanslung der Eingabe in eine Integer32
            Console.WriteLine("Bitte die Anzahl an Durchläufen eingeben:");
            int y = Convert.ToInt32(Console.ReadLine());

            //Variablen
            //Zählervariable
            int x = 0;
            //Summenvariablen der Zahlen
            double sumz1 = 0;
            double sumz2 = 0;
            double erg = 0;
            // Variablen für die Zähler der Ergebniszahlen plus der Summe dieser
            double erg2 = 0 ; double erg3 = 0; double erg4 = 0; double erg5 = 0; double erg6 = 0; double erg7 = 0; double erg8 = 0; double erg9 = 0; double erg10 = 0; double erg11 = 0; double erg12 = 0;
            double erg_z = 0;

            //Erzeuge Random Objekte
            Random wuerfel1 = new Random();
            Random wuerfel2 = new Random();

            //2D-Array (Zahl 1, Zahl 2, Ergebnis)
            // int[,] zufallszahlenarray = new int[x Zeilen, 3 Spalten];
            double[,] zufallszahlenarray = new double[y, 3];

            // While Schleife
            while (x < y)
            {
                //Generiere zufällige Zahlen je Würfel zwischen 1 und 6
                double zahl1 = wuerfel1.Next(1, 7);
                double zahl2 = wuerfel2.Next(1, 7);
                // Berechne Ergebnis
                double ergebnis = zahl1 + zahl2;

                //Array befüllen
                zufallszahlenarray[x, 0] = zahl1;
                zufallszahlenarray[x, 1] = zahl2;
                zufallszahlenarray[x, 2] = ergebnis;

                //Ausgabe des Arrays
                Console.WriteLine("Index " + x + ": " + zufallszahlenarray[x, 0] + " + " + zufallszahlenarray[x, 1] + " = " + zufallszahlenarray[x, 2]);

                //Summenzähler der Array Spalten
                sumz1 += zufallszahlenarray[x, 0];
                sumz2 += zufallszahlenarray[x, 1];
                erg   += zufallszahlenarray[x, 2];

                //Anzahl der gewürfelten Werte

                if (ergebnis < 2.0009)
                {
                    erg2 = erg2 + 1;
                }
                else if (ergebnis < 3.0009)
                {
                    erg3 = erg3 + 1;
                }
                else if (ergebnis < 4.0009)
                {
                    erg4 = erg4 + 1;
                }
                else if (ergebnis < 5.0009)
                {
                    erg5 = erg5 + 1;
                }
                else if (ergebnis < 6.0009)
                {
                    erg6 = erg6 + 1;
                }
                else if (ergebnis < 7.0009)
                {
                    erg7 = erg7 + 1;
                }
                else if (ergebnis < 8.0009)
                {
                    erg8 = erg8 + 1;
                }
                else if (ergebnis < 9.0009)
                {
                    erg9 = erg9 + 1;
                }
                else if (ergebnis < 10.0009)
                {
                    erg10 = erg10 + 1;
                }
                else if (ergebnis < 11.0009)
                {
                    erg11 = erg11 + 1;
                }
                else if (ergebnis < 12.0009)
                {
                    erg12 = erg12 + 1;
                }
                erg_z = erg2 + erg3 + erg4 + erg5 + erg6 + erg7 + erg8 + erg9 + erg10 + erg11 + erg12;
                
                //Zähler erhöhen
                x++;
            }

            // Durschnitt der Array Spalten (Wüfel 1, 2 & Ergebnis berechnen
            double avg1 = sumz1 / y;
            double avg2 = sumz2 / y;
            double avgerg = erg / y;

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Summe Würfel 1: " + sumz1);
            Console.WriteLine("Summe Würfel 2: " + sumz2);
            Console.WriteLine("Summe Ergebnis: " + erg);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Der Durschnitt von Würfel 1: " +avg1);
            Console.WriteLine("Der Durschnitt von Würfel 2: " + avg2);
            Console.WriteLine("Der Durschnitt von Ergenis:  " + avgerg);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Anzahl der Durchläufe: " + y);
            Console.WriteLine("Anzahl der Zahl  2: " + erg2);
            Console.WriteLine("Anzahl der Zahl  3: " + erg3);
            Console.WriteLine("Anzahl der Zahl  4: " + erg4);
            Console.WriteLine("Anzahl der Zahl  5: " + erg5);
            Console.WriteLine("Anzahl der Zahl  6: " + erg6);
            Console.WriteLine("Anzahl der Zahl  7: " + erg7);
            Console.WriteLine("Anzahl der Zahl  8: " + erg8);
            Console.WriteLine("Anzahl der Zahl  9: " + erg9);
            Console.WriteLine("Anzahl der Zahl 10: " + erg10);
            Console.WriteLine("Anzahl der Zahl 11: " + erg11);
            Console.WriteLine("Anzahl der Zahl 12: " + erg12);
            Console.WriteLine("Summe aller Zahlen:    " + erg_z + " (Muss gleich der Anzahl der Durchläufe sein)");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
