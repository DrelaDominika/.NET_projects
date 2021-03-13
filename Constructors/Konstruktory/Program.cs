using System;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dane a = new Dane(10.0);
            Dane b = new Dane('x');
            Dane c = new Dane(5.5, 'y');
            Dane d = new Dane('z', 19.8);
            Dane e = new Dane(6, 1);
            Dane f = new Dane(50);

            a.wypisz();
            b.wypisz();
            c.wypisz();
            d.wypisz();
            e.wypisz();
            f.wypisz();
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

        //double
        public Dane(double liczba)
        {
            this.liczba = liczba;
        }

        //char
        public Dane(char znak)
        {
            this.znak = znak;
        }

        //double,char
        public Dane(double liczba, char znak)
        {
            this.liczba = liczba;
            this.znak = znak;
        }

        //char,double
        public Dane(char znak, double liczba)
        {
            this.liczba = liczba;
            this.znak = znak;
        }

        //NWD
        public Dane(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            Console.WriteLine("NWD podanych liczb jest: " + a);
        }

        //Sito Eratostenesa

        public Dane(int range)
        {
            int i, j, k;
            int[] array = new int[100];
            k = (int)Math.Floor(Math.Sqrt(range));

            //inicjowanie tablicy
            for (i = 1; i <= range; i++)
                array[i] = i;

            //algorytm
            for (i = 2; i <= k; i++)
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

            Console.Write("Liczby pierwsze od 1 do 50:\n");
            for (i = 2; i <= range; i++)
            {
                if (array[i] != 0)
                    Console.WriteLine(i + " ");
            }
        }
    }
}
