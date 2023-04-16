﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baza_kostek
{
    partial class Program
    {
        public static void removeData(List<Kostki> wszystkieKostki)
        {
            informacje:

            Console.WriteLine("Wybór sposobu usuwania: ");
            Console.WriteLine("1 - Nazwa kostki");
            Console.WriteLine("2 - numer koski na liscie");
            Console.WriteLine("3 - anuluj wpisywanie");
            Console.Write(">>> ");
            string ans = Console.ReadLine().Trim();

            switch (ans)
            {
                case "1":
                    while (true)
                    {

                    pokazywanieKostek:
                        Console.Clear();
                        Console.WriteLine("Wprowadź nazwę kostki: ");
                        string nazwaKostki = Console.ReadLine();
                        int index = 0;
                        for (; index < wszystkieKostki.Count(); index++)
                        {
                            if (wszystkieKostki[index].Nazwa == nazwaKostki)
                                break;
                        }

                        //  kostka została znaleziona
                        if (index < wszystkieKostki.Count())
                        {
                            CzyUsunuacKostke:
                            Console.Clear();
                            Console.WriteLine("\nKostka znaleziona. Czy usunąć ją z bazy? (y/n)");
                            string odp = Console.ReadLine().Trim();
                            if (odp == "y")
                            {
                                wszystkieKostki.RemoveAt(index);
                                goto pokazywanieKostek;
                            }
                            else if (odp == "n")
                                goto informacje;
                            else
                                goto CzyUsunuacKostke;
                        }
                        //  kostka nie została znaleziona
                        else
                        {
                            CzyPonownieKostka:
                            Console.Clear();
                            Console.WriteLine("\nNiestety, nie udało sie znaleźć kotki o takiej nazwie - czy spróbować ponownie? (y/n)");
                            string odp = Console.ReadLine().Trim();
                            if (odp == "y")
                                goto pokazywanieKostek;
                            else if (odp == "n")
                                goto informacje;
                            else
                                goto CzyPonownieKostka;

                        }
                            
                    }
                    break;

                case "2":

                    break;

                case "3":
                    goto informacje;
            }

        }
    }
}
