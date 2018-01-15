using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 8, operand2 = 0;
            
            Console.WriteLine("Введите знак арефметической операции:");
            string sign = Console.ReadLine();
            switch (sign)

            {
                case "+": Console.WriteLine(operand1 + operand2);
                    break;
                case "-": Console.WriteLine(operand1 - operand2);
                    break;
                case "*": Console.WriteLine(operand1 * operand2);
                    break;
                case "/":
                    if (operand2 !=0)
                    Console.WriteLine(operand1 / operand2);
                    else Console.WriteLine("На ноль делить нельзя");
                    break;

                default:
                {
                    Console.WriteLine("Вы ввели не знак математической опреции");
                    break;
                }
            }
            
            Console.ReadKey();
        }
    }
}

//Используя Visual Studio, создайте проект по шаблону Console Application.
//Напишите программу - консольный калькулятор. Создайте две переменные с именами operand1 и operand 2. 
//Задайте переменным некоторые произвольные значения.Предложите пользователю ввести знак арифметической операции. 
//Примите значение введенное пользователем и поместите его в строковую переменную sign.
//Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch . 
//Выведите на экран результат выполнения арифметической операции.
//В случае использования операции деления, организуйте проверку попытки деления на ноль. 
//И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке
//пользователя .
