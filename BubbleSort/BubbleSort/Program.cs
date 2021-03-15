using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            int[] array = new int[10];

            Console.WriteLine("Podaj 10 liczb: ");

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Tablica nieposortowana: ");
                
                foreach (int x in array)
                    Console.Write(x + " ");
                
                bubble.Sort(array, 10);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Podano niepoprawny format!\n" + e);
            }
        }
    }
    class BubbleSort
    {
        public void Sort(int[] array, int n)
        {
            int temp;

            for (int j = 0; j <= n - 2; j++)
            {
                for (int i = 0; i <= n - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nTablica posortowana metoda babelkowa: ");
            
            foreach (int x in array)
                Console.Write(x + " ");
        }
    }
}
