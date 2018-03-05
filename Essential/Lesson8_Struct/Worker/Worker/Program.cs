using System;

namespace Worker
{
    public enum Position
    {
        Trainee = 40,
        Seller = 120,
        Manager = 160,
        Director = 180
    }

    public class Accauntant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            if ((int) worker > hours)
                return true;
            else
                return false;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Выбирите должность для расчета:\nСтажер - 1, Продавец - 2, Менеджер - 3, Директор - 4");
            var worker = Console.ReadLine();
            Console.WriteLine("Введите кол-во отработаных часов");
            var hours = Console.ReadLine();

            Accauntant.AskForBonus();

            Console.ReadKey();
        }
    }
}
