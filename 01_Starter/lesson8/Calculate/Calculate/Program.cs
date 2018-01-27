using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Calculate(ref int operand1,ref int operand2,ref int operand3)
        {
            operand1 /= 5;
            operand2 /= 5;
            operand3 /= 5;

        }

        static void Main(string[] args)
        {
            int operand1 = 15, operand2 = 20, operand3 = 25;
            Console.WriteLine("Числа {0} {1} {2}", operand1, operand2, operand3);

            Calculate(ref operand1,ref operand2,ref operand3);
            Console.WriteLine("Числа {0} {1} {2}", operand1, operand2, operand3);

            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Создайте метод с именем Calculate, который принимает в качестве параметров три целочисленных значения и возвращает значение каждого аргумента деленного на 5. 