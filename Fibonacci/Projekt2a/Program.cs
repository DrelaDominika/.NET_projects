using System;

namespace Projekt2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[10][];

            int x = 0;
            int y = 1;

            for(int i = 0; i < 10; i++)
            {
                tab[i] = new int[y];
                for(int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = tab[i].Length - j;
                }
                int z = x + y;
                x = y;
                y = z;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("tab({0}): ", i);
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j] + " ");

                }

                Console.WriteLine();

            }

        }
        
    }
}
