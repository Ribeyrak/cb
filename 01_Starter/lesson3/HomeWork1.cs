using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = 10; int y = 12; int z = 3;
            
            x += y - x++ * z;
            Console.Write("1) ");
            Console.WriteLine(x);

            z = --x - y * 5;
            Console.Write("2) ");
            Console.WriteLine(z);

            y /= x + 5 % z;
            Console.Write("3) ");
            Console.WriteLine(y);

            z = x++ + y * 5;
            Console.Write("4) ");
            Console.WriteLine(z);

            x = y - x++ * z;
            Console.Write("5) ");
            Console.WriteLine(x);




            Console.ReadKey();
        }
    }
}
