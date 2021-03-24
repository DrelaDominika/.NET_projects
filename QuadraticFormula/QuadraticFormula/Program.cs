using System;

namespace QuadraticFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            double delta, x1, x2;

            Console.Write("Podaj wartość a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wartość b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wartość c : ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                Console.Write("Równanie ma dwa rozwiązania.\n");

                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.Write("Pierwsza niewiadoma ma wartość = {0}\n", x1);
                Console.Write("Druga niewiadoma ma wartość = {0}\n", x2);

            }
            else if (delta == 0)
            {
                Console.Write("Równanie ma jedno rozwiązanie.\n");

                x1 = -b / (2.0 * a);
                x2 = x1;

                Console.Write("Pierwsza niewiadoma ma wartość = {0}\n", x1);
                Console.Write("Druga niewiadoma ma wartość = {0}\n", x2);
            }
            else
                Console.Write("Delta jest mniejsza od 0. Równanie nie ma rozwiązań.");
        }
    }
}
