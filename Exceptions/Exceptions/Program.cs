using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArithmeticException
            try
            {
                Console.WriteLine("Podaj pierwsza liczbe:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj druga liczbe:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a / b);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Nie mozna dzielic przez 0!", e);
            }

            //Exception
            catch (FormatException e)
            {
                Console.WriteLine("Podano niepoprawny format!", e);
            }
           
        }
    }
}
