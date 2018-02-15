using System;

namespace Player
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Проигрывание музыки");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка");
        }

        public void Record()
        {
            Console.WriteLine("Запись звука");
        }
    }
}
