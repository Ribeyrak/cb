using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Sign(int operand)
        {
            if (operand >= 0)
                Console.WriteLine("Число положительное");
            else
            {
                Console.WriteLine("Число отрицательное");
            }
        }

        static void Number(int operand)
        {
            int divider = 2;
            int ost;
        
            do
            {
                ost = operand % divider;
                if (ost != 0)
                    divider++;
            } 
            while (ost != 0);
        
            if (divider == operand)
                Console.WriteLine("Число является простым");
            else
            {
                Console.WriteLine("Число не является простым");
            }
        
        }

        static void Divider(int operand)
        {

            if ((operand % 2) == 0 && (operand % 5) == 0 && (operand % 3) == 0 && (operand % 6) == 0 && (operand % 9) == 0)
            {
                Console.WriteLine("Число делиться на 2, 5, 3, 6, 9 без остатка");
            }
            else
            {
                Console.WriteLine("Число не делиться на 2, 5, 3, 6, 9 без остатка");
            }
        }

        static void Main(string[] args)

        {
            Console.Write("Введите число: ");
            int operand = Convert.ToInt32(Console.ReadLine());

            Sign(operand);
            Divider(operand);
            Number(operand);

            Console.ReadKey();
        }
    }
}
//Напишите метод, который будет определять: 
//1) является ли введенное число положительным или отрицательным. 
//2) Является ли оно простым(используйте технику перебора значений). 
//(Простое число — это натуральное число, которое делится на 1 и само на себя.
//Чтобы определить простое число или нет, следует найти все его целые делители. 
//Если делителей больше 2 -х, значит оно не простое .) 
//3) Делится ли на 2, 5, 3, 6, 9 без остатка.

