﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main()
        {
            ColorPrinter print = new ColorPrinter(ConsoleColor.Yellow);
            print.Print("Hello");

            ColorPrinter print1 = new ColorPrinter(ConsoleColor.Red);
            print1.Print("Hello");

            Console.ReadKey();
        }
    }
}
//Создайте класс Printer.В теле класса создайте метод void Print(string value), который выводит на экран значение
//аргумента.Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
//соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
//выводились разными цветами.Обязательно используйте приведение типов.