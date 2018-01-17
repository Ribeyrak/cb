using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int s = Convert.ToInt32(Console.ReadLine());
            int n = (int)(s << 31);

            if (n == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }

           Console.ReadKey();
        }
    }
}
//Известно, что у четных чисел младший бит имеет значение 0 
//Напишите программу, которая будет выполнять проверку чисел на четность.
//Предложите два варианта решения поставленной задачи.