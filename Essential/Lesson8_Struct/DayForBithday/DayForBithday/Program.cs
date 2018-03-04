using System;

namespace DayForBithday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день своего рождения:" );
            DateTime _bithday = Convert.ToDateTime(Console.ReadLine());
            DateTime _now = DateTime.Now;
            
            DateTime _thisYear = new DateTime(_now.Year, _bithday.Month, _bithday.Day);
            TimeSpan _wait;

            if (_thisYear < _now)
            {
                _thisYear = new DateTime(_now.Year + 1, _bithday.Month, _bithday.Day);
                _wait = _thisYear - _now;
            }
            else
            {
                _wait = _thisYear - _now;
            }

            Console.WriteLine("До вашего дня рождения осталось {0 } дней", _wait.Days);
            Console.WriteLine("С наступающим! :)");

            Console.ReadKey();
        }
    }
}
