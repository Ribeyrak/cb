using System;

namespace AnonMethod
{
    public delegate int Delegate(int a, int b, int c);

    internal class Program
    {
        private static void Main(string[] args)
        {
            int _summand1 = 5, _summand2 = 6, _summand3 = 7, sum = 0;
            Delegate myDelegate = delegate(int a, int b, int c) { return (a + b + c) / 3; };
            sum = myDelegate(_summand1, _summand2, _summand3);

            Console.WriteLine("Среднее значение равное {0}", sum);

            Console.ReadKey();
        }
    }
}