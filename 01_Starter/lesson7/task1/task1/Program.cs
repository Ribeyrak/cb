using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Add(int operand1,int operand2)
        {
           Console.WriteLine("{0} + {1} = {2}",operand1, operand2, (operand1+operand2));
        }

        static void Sub(int operand1, int operand2)
        {
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, (operand1 - operand2));
        }

        static void Mul(int operand1, int operand2)
        {
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, (operand1 * operand2));
        }

        static void Div(int operand1, int operand2)
        {
            if (operand1 / operand2 != 0)
            {
                Console.WriteLine("{0} + {1} = {2}", operand1, operand2, (operand1 / operand2));
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite 1");
            operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vvedite 2");
            operand2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Znak");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+": Console.WriteLine(operand1, operand2);
            }
                


        }
    }
}
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте четыре метода для выполнения арифметических операций, с именами: 
//Add – сложение, Sub – вычитание, Mul – умножение, Div – деление.
//Каждый метод должен принимать два целочисленных аргумента и выводить на экран результат выполнения арифметической операции соответствующей имени метода.
//Метод деления Div, должен выполнять проверку попытки деления на ноль.
//Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак арифметической операции, для выполнения вычислений.
