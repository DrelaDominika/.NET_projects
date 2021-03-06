using System;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=100; i>1;i--)
            {
                if(i % 3 == 0 && i % 2 != 0)
                {
                    Console.WriteLine(i);
                   
                }
            }
            int a = 100;
            while (a > 1)
            {
                if (a % 3 == 0 && a % 2 != 0)
                {
                    Console.WriteLine(a);
                   
                }
                a--;
            }
            int b = 100;
            do
            {
                if (b % 3 == 0 && b % 2 != 0)
                {
                    Console.WriteLine(b);

                }
                b--;
            } while (b > 1);
            
            Console.ReadKey();

        }
    }
}
