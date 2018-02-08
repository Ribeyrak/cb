using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportInfo
{
    class Vehicle
    {
        int price, speed, data;

        protected int Price
        {
            get { return price; }
        }

        protected int Speed
        {
            get { return speed; }
        }

        public int Data
        {
            get { return data; }
        }
    
        public Vehicle(int price, int speed, int data)
        {
            this.price = price;
            this.speed = speed;
            this.data = data;
        }

    }

    class Plane : Vehicle
    {
        public Plane(int price, int speed, int data) : base(price, speed, data) { }

        private int high;
        public int High
        {
            get { return high; }
            set { high = value; }
        }
    }

    class Car : Vehicle
    {
        public Car(int price, int speed, int data)
           : base(price, speed, data)
        {

        }
    }

    class Ship : Vehicle
    {
        public Ship(int price, int speed, int data) : base(price, speed, data)
        {

        }

        private int passanger;
        public int Passanger
        {
            get { return passanger; }
            set { passanger = value; }
        }

        private string port;
        public string Port
        {
            get { return port;}
            set { port = value; }
        }

    }
}
