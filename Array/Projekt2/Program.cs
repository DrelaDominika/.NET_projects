﻿using System;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[4][];
            int licznik = 10;


            for (int i = 0; i < 4; i++)
            {
                tab[i] = new int[i + 1];
            }


            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;
                }
            }


            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write(tab[i][j] + " ");
                }
                
                Console.WriteLine();
            }

        }
    }
}
