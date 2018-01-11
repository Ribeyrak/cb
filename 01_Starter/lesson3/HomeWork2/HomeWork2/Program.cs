using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int c = 0;

            c = (a / b + 1) * 2;

            Console.Write("При переменной равной - ");
            Console.WriteLine(c);

            
            const double pi = 3.141;
            double r = Math.Pow(c, 2);
            double P = pi * r;
            Console.Write("Площадь круга составит - ");
            Console.WriteLine(P);

            Console.ReadKey();
        }
    }
}
