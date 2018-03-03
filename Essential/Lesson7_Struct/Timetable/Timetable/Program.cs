using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
    struct Train
    {
        private string _destination;
        private int _trainNumber;
        private int _departureTime;
        public Train(string destination, int trainNumber, int departureTime)
        {
            _destination = destination;
            _trainNumber = trainNumber;
            _departureTime = departureTime;
        }

        public string Destination
        {
            get { return _destination; }
        }

        public int TrainNumber
        {
            get { return _trainNumber; }
        }

        public int DepartureTime
        {
            get { return _departureTime; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
