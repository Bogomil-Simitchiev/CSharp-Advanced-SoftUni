namespace GenericArrayCreator
{
    public static class ArrayCreator<T>
    {
        public static T[] Create(int length,T item)
        {
            T[] array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }
            return array;
        }

    }
}
