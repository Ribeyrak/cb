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
            int a = 6;
            int b = 2;
            int c = 0;

            a = b + c + 1;
            c = (a * b - 10) * 10;

            Console.WriteLine(a);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
