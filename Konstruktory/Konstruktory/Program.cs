using System;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dane y = new Dane(3.5);
            Dane x = new Dane('z');
            Dane z = new Dane(4.6, 'z');
            Dane i = new Dane('i', 1.3);
            Dane k = new Dane(12, 8);
            Dane j = new Dane(100);

            y.wypisz();
            x.wypisz();
            z.wypisz();
            i.wypisz();
            j.wypisz();
            k.wypisz();
        }
    }
    class Dane
    {
        double liczba;
        char znak;
        public void wypisz()
        {
            Console.WriteLine(znak + " " + liczba);
        }

        // 1 konstruktor
        public Dane(double liczba)
        {
            this.liczba = liczba;
        }

        // 2 konstruktor
        public Dane(char znak)
        {
            this.znak = znak;
        }

        //3 konstruktor
        public Dane(double liczba, char znak)
        {
            this.liczba = liczba;
            this.znak = znak;
        }

        //4 konstruktor
        public Dane(char znak, double liczba)
        {
            this.liczba = liczba;
            this.znak = znak;
        }

        //5 kostruktor - największy wspólny dzielnik
        public Dane(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("Największym wspólnym dzielnikiem 12 i 4 podanych liczb jest: " + a);
        }

        //6 konstrukotr - sito Eratostenesa

        public Dane(int range)
        {
            int i, j, n;
            int[] array = new int[900];
            n = (int)Math.Floor(Math.Sqrt(range));


            for (i = 1; i <= range; i++)
                array[i] = i;

            for (i = 2; i <= n; i++)
            {
                if (array[i] != 0)
                {
                    j = i + i;
                    while (j <= range)
                    {
                        array[j] = 0;
                        j += i;
                    }
                }
            }

            Console.Write("Liczby pierwsze z zakresu od 1 do 100");
            for (i = 2; i <= range; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine(i + " ");
            }
        }
    }
}
