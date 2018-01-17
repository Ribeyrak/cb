using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deMorgana
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = false;
            bool B = false;

            if (A || B)
                Console.WriteLine("A || B = {0}", A || B);
            else
                Console.WriteLine("A || B = {0}", A || B);

            if (!(!A && !B))
                Console.WriteLine("!(!A && !B = {0}", !(!A && !B));
            else
            Console.WriteLine("!(!A && !B = {0}", !(!A && !B));

            Console.ReadKey();
        }
    }
}
//Используя теорему Де Моргана, преобразуйте исходное выражение A | B, в эквивалентное выражение