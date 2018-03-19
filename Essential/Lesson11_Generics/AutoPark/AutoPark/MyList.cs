namespace AutoPark
{
    public interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }

    internal class MyList<T> : IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a)
        {
            var tempArray = new T[array.Length + 1];
            for (var i = 0; i < array.Length; i++) tempArray[i] = array[i];

            tempArray[array.Length] = a;
            array = tempArray;
        }

        public T this[int index] => array[index];

        public int Count => array.Length;

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for (var i = 0; i < array.Length; i++)
                if ((int) (object) array[i] == (int) (object) item)
                    return true;

            return false;
        }

        public override string ToString()
        {
            string stroka = null;
            for (var i = 0; i < array.Length; i++) stroka += array[i] + " ";

            return "Размероность массива " + array.Length + " Элемент массива:" + stroka;
        }
    }
}