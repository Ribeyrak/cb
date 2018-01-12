using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предлогаем ввести слово на русском
            Console.WriteLine("Введите слово на русском языке (с маленькой буквы): ");

            //Принимаем ввод
            string myWord = Console.ReadLine();

            switch (myWord)
            {
                case "сын":
                    Console.WriteLine("son");
                    break;
                case "очки":
                    Console.WriteLine("glass");
                    break;
                case "кукла":
                    Console.WriteLine("doll");
                    break;
                case "стол":
                    Console.WriteLine("table");
                    break;
                case "роза":
                    Console.WriteLine("rose");
                    break;

                default:
                {
                    Console.WriteLine("Нет перевода для этого слова");
                    break;
                }
            }

           Console.ReadKey();
        }
    }
}
