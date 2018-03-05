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
        public void AskForBonus(string worker, int hours)
        {
            if ((int) Position.worker > hours)
                Console.WriteLine("Выдать премию");
            else
                Console.WriteLine("Превмию не выдавать");
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

            Accauntant.AskForBonus(worker, hours);

            //Accauntant work = new Accauntant();
            //if (work.AskForBonus(Position.))


            Console.ReadKey();
        }
    }
}