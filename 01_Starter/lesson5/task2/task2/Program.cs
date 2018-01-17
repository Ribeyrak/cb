using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte operand = 0x01; //1111 0000
            //byte mask = 0xFD;     //1111 1101 
            //Console.WriteLine("operand = {0:X}", operand);
            //
            //operand = (byte) (operand | mask);
            //Console.WriteLine("operand = {0:X}", operand);
            Console.WriteLine("Введите число:");
            int s = Convert.ToInt32(Console.ReadLine());

            byte operand1 = Console.ReadLine();
            int result;

            if 

            operand1 = 0x00;
            operand2 = 0x02;
            result = operand1 | operand2;

            //Console.WriteLine("{0} ")

            Console.ReadKey();
        }
    }
}
//Известно, что у четных чисел младший бит имеет значение 0 
//Напишите программу, которая будет выполнять проверку чисел на четность.
//Предложите два варианта решения поставленной задачи.