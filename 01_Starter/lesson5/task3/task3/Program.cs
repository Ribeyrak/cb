using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;
            Console.WriteLine("1) {0}", x += y >> x++ * z);
            Console.WriteLine("2) {0}", z = ++x & y * 5);
            Console.WriteLine("3) {0}", y /= x + 5 | z);
            Console.WriteLine("3) {0}", z = x++ & y * 5);
            Console.WriteLine("3) {0}", x = y << x++ ^ z);

            Console.ReadKey();
        }
    }
}
//Имеется 3 переменные типа int x = 5, y = 10, и z = 15; 
//Выполните и рассчитайте результат следующих операций для этих переменных:
//§ x += y >> x++ * z; 
//§ z = ++x & y* 5 ; 
//§ y /= x + 5 | z ; 
//§ z = x++ & y* 5 ; 
//§ x = y << x++ ^ z ;
