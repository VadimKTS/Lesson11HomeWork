namespace Lesson11HomeWork.Task_2
{
    internal  class GenericClass<T> where T : IComparable<T>
    {
        public T ReturnMax(T item1, T item2, T item3)
        {
            T result = item1;
            if (item1.CompareTo(item2) < 0)
            { result = item2; }

            else if (item2.CompareTo(item3) < 0)
            { result = item3; }

            return result;
        }
    }
}