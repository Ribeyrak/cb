using System;


namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player instance = new Player();

            instance.Play();
            instance.Pause();
            instance.Record();
            instance.Stop();

            Console.ReadKey();
        }
    }
}
//Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода 
//void Play() / void Pause() / void Stop ( ) и void Record ( ) / void Pause ( ) / void Stop ( ) соответственно. 
//Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
//Написать программу, которая выполняет проигрывание и запись.
