using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static int Add(int operand1,int operand2)
        {
            
           return operand1+operand2;
        }

        static int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        static int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        static int Div(int operand1, int operand2)
        {
            
            if (operand2 != 0)
            {
                return operand1 / operand2;
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
                return 0;
            }
            
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите знак арифметического действия: ");
            string sign = Console.ReadLine();
            
            switch (sign)
            {
                case "+": Console.WriteLine("{0} + {1} = {2}", operand1 ,operand2, Add(operand1,operand2));
                    break;
                case "-": Console.WriteLine("{0} - {1} = {2}", operand1, operand2, Sub(operand1, operand2));
                    break;
                case "*": Console.WriteLine("{0} * {1} = {2}", operand1, operand2, Mul(operand1, operand2));
                        break;
                case "/": Console.WriteLine("{0} / {1} = {2}", operand1, operand2, Div(operand1, operand2));
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
//Создайте четыре метода для выполнения арифметических операций, с именами: 
//Add – сложение, Sub – вычитание, Mul – умножение, Div – деление.
//Каждый метод должен принимать два целочисленных аргумента и выводить на экран результат выполнения арифметической операции соответствующей имени метода.
//Метод деления Div, должен выполнять проверку попытки деления на ноль.
//Требуется предоставить пользователю возможность вводить с клавиатуры значения операндов и знак арифметической операции, для выполнения вычислений.
