namespace Lesson11HomeWork.Task_1
{
    internal class GenericArrayClass<T>
    {
        private T[] myArray = new T[10];
        private int count = 0;

        
        public T[] MyArray
        {
            get { return myArray; }
            set { myArray = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void Add( T item ) 
        {
            try
            {
                MyArray[Count] = item;
                Count++;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Массив перезаписан!!!!! " + ex.Message);
                Count = 0;
                MyArray[Count] = item;
            }
        }
        public T GetElement(int i) 
        {
            return MyArray[i];
        }


        public int ReturnCount()
        {
            return Count;
        }
    }
}