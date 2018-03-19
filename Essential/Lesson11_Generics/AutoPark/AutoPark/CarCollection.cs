using System;

namespace AutoPark
{
    internal class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }

        public new string this[int index]
        {
            get
            {
                if (index < carName.Count)
                    return carName[index] + " " + carYear[index].Year + " г";
                return "В списке нет машины под таким номером!";
            }
        }

        public int Lenght => carName.Count;

        public void Remove()
        {
            carName.Clear();
            carYear.Clear();
        }

        public override string ToString()
        {
            string stroka = null;
            for (var i = 0; i < carName.Count; i++)
                stroka += "№" + (i + 1) + " " + carName[i] + " " + carYear[i].Year + " г \n";
            if (stroka != null) return stroka;
            return "В парке нет ни одной машины!";
        }
    }
}