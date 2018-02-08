using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    class Program
    {
        static void Main()
        {
            Ship ship = new Ship(9000, 120, 2000) { Passenger = 28, Port = "Одесса" };
            
            Console.WriteLine("Цена корабля {0}, скорость {1}, год выпуска {2}, количество пасажиров {3}, порт приписки {4}", ship.Price, ship.Speed, ship.Data, ship.Passenger, ship.Port);

            Car car = new Car(6000, 160, 2016);
            Console.WriteLine("Цена автомобиля {0}$,скорость {1}, год выпуска {2}", car.Price, car.Speed,car.Data);

            // Delay.
            Console.ReadKey();
        }
    }
}
//Создать класс Vehicle.В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship.Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.