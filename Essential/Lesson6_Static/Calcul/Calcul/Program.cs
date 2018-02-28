using System;

namespace Calcul
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Addition(12, 15));
            Console.WriteLine(Calculator.Subctraction(46.34, 11.5));
            Console.WriteLine(Calculator.Multiplication(2.5, 10));
            Console.WriteLine(Calculator.Division(5, 0));

            Console.ReadKey();
        }
    }
}