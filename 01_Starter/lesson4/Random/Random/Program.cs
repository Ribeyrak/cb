using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 15 ; //c = 36 - 50, d = 50 - 100;
            Console.WriteLine("Введите число от 0 до 100");
            string number = Console.ReadLine();

            switch (number)
            {
                case "a": Console.WriteLine("Вы попали в первую группу");
                    break;
                case "b": Console.WriteLine("Вы попали во вторую группу");
                    break;
                case "c": Console.WriteLine("Вы попали в третью группу");
                    break;
                case "d": Console.WriteLine("Вы попали в четвертую группу");
                    break;

                default: {Console.WriteLine("Указанно неккоректное число");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в числовой промежуток
//[0 - 14][15 - 35][36 - 50][50 - 100]. Если да, то укажите, в какой именно промежуток. 
//Если пользователь указывает число не входящее н и в один и з имеющихся числовых промежутков, то выводится соответствующее сообщение.
