namespace GenericLikeList
{
    internal interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        bool Contains(T item);
    }
}