using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму для конвертации: ");
            int summ = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите курс валюты: ");
            int course = Convert.ToInt32(Console.ReadKey());

            int ekv = summ * course;
            Console.WriteLine("При курсе {0} за {1} единиц вы получите {2}", course, summ, ekv);
        }
    }
}
