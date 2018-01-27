using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForBank
{
    class Program
    {
        static void Kredit(ref int sum)
        {
            if (sum == 700)
                Console.WriteLine("Кредит погашен");
            else if (sum >= 700)
                Console.WriteLine("Клинет переплатил {0}", (sum - 700));
            else
                Console.WriteLine("Долг клиента составляет {0} грн.", (700 - sum));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите сумму внесенную клиентом: ");
            int sum = Convert.ToInt32(Console.ReadLine());

            Kredit(ref sum);

            Console.ReadKey();
        }
    }
}
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли клиент кредит или нет. 
//Допустим, ежемесячная сумма платежа должна составлять 100 грн. Клиент должен выполнить 7 платежей, но может платить реже большими суммами. 
//Т.е. , может двумя платежами по 300 и 400 грн.Закрыть весь долг.
//Создайте метод, который будет в качестве аргумента принимать сумму платежа, 
//введенную экономистом банка.Метод выводит на экран и нформацию о состоянии кредита 
//(сумма задолженности, сумма переплаты , сообщение об отсутствии долга).
