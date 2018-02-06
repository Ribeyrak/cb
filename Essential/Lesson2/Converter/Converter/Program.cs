using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Converter
    {
        public Converter (double usd, double eur, double rub)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер валюты для конвертации: 1 - USD, 2 - EUR, 3 - RUB ");
            Console.ReadLine();

            Console.WriteLine("Vvedite summu dlia obmena: ");
            Convert.ToInt32(Console.ReadLine());

            Сonsole.WriteLine();
        }
    }
}
//(+)Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется: Создать класс Converter.В теле класса создать пользовательский конструктор, 
//который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу 3 -х основн ых валют, 
//по отношению к гривне - public Converter(double usd, double eur, double rub). 
//Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,
//также программа должна производить конвертацию из указанных валют в гривну.
