using System;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            przeciazenie p = new przeciazenie();
            p.Dane(10.0);
            p.Dane('x');
            p.Dane(5.5, 'y');
            p.Dane('z', 19.8);
            p.Dane(6, 3);
            p.Dane(50);

        }
    }
    public class przeciazenie
    {
        double liczba;
        char znak;

        //double
        public void Dane(double liczba)
        {
            this.liczba = liczba;
            Console.WriteLine(liczba);
        }

        //char
        public void Dane(char znak)
        {
            this.znak = znak;
            Console.WriteLine(znak);
        }

        //double,char
        public void Dane(double liczba, char znak)
        {
            this.liczba = liczba;
            this.znak = znak;
            Console.WriteLine(liczba + " " + znak);
        }

        //char,double
        public void Dane(char znak, double liczba)
        {
            this.liczba = liczba;
            this.znak = znak;
            Console.WriteLine(znak + " " + liczba);
        }

        //NWD
        public void Dane(int a, int b)
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

        public void Dane(int range)
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
