namespace TransportInfo
{
    class Vehicle
    {
        double price, speed, data;

        public double Price
        {
            get { return price; }
        }

        public double Speed
        {
            get { return speed; }
        }

        public double Data
        {
            get { return data; }
        }
    
        public Vehicle(double price, double speed, double data)
        {
            this.price = price;
            this.speed = speed;
            this.data = data;
        }

    }

    class Plane : Vehicle
    {
        public Plane(double price, double speed, double data) : base(price, speed, data) { }

        private double high;
        public double High
        {
            get { return high; }
            set { high = value; }
        }
    }

    class Car : Vehicle
    {
        public Car(double price, double speed, double data)
           : base(price, speed, data)
        {

        }
    }

    class Ship : Vehicle
    {
        public Ship(double price, double speed, double data) : base(price, speed, data)
        {

        }

        private double passenger;
        public double Passenger
        {
            get { return passenger; }
            set { passenger = value; }
        }

        private string port;
        public string Port
        {
            get { return port;}
            set { port = value; }
        }

    }
}
