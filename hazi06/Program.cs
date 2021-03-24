using System;
using konyvNevter;

namespace hazi06
{
    class Program
    {
        static void Main(string[] args)
        {
            Konyv konyv1 = new Konyv("A kendőzetlen igazság", "Bakó Csaba", 600, 4990);
            Console.WriteLine(konyv1.ToString());
            Console.WriteLine(konyv1.Osszefuz());

            Konyv konyv2 = new Konyv("A két lotti", "Erich Kästner", 456);
            Console.WriteLine(konyv2.ToString());

            konyv1.ArNoveles(20);
            Console.WriteLine(konyv1.ToString());

            Console.WriteLine(Konyv.HosszabbKonyv(konyv1, konyv2));

            Console.WriteLine(konyv1.ParosE());

            Console.WriteLine("Hány könyvet olvasson be?");
            int n = Convert.ToInt32(Console.ReadLine());
            Konyv[] konyvek = new Konyv[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Add meg a könyv: Címét, Szerzőjét, Oldalszámát, Árát");
                konyvek[i] = new Konyv(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            }

            int maxindex = 0;
            for (int i = 0; i < n; i++)
            {
                if(konyvek[i].Oldalszam > konyvek[maxindex].Oldalszam)
                {
                    maxindex = i;
                }
            }
            Console.WriteLine($"A leghosszabb könyv adatai:\n {konyvek[maxindex]}");

            int leghosszabb=0;
            for (int i = 0; i < n; i++)
            {
                if(konyvek[i].Oldalszam%2 == 0)
                {
                    leghosszabb = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if(konyvek[i].Oldalszam%2 == 0)
                {
                    if (konyvek[i].Oldalszam > konyvek[leghosszabb].Oldalszam)
                    {
                        leghosszabb = i;
                    }
                }
            }
            Console.WriteLine($"A leghosszabb páros oldalszámú könyv adatai:\n {konyvek[leghosszabb]}");

            for (int i = 0; i < n; i++)
            {
                int elofordulas = 1;
                for (int j = 0; j < n; j++)
                {
                    if(konyvek[i].Szerzo == konyvek[j].Szerzo && i != j)
                    {
                        elofordulas++;
                    }
                }
                Console.WriteLine($"{konyvek[i].Szerzo}-nak/-nek {elofordulas} könyve jelent meg.");
            }
        }
    }
}
