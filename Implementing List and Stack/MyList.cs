using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStack
{
    public class MyList
    {
        private const int Capacity = 2;
        private int[] items;

        public int Count { get; private set; }
        public MyList()
        {
            items=new int[Capacity];
        }
        public int this[int i]
        {
            get {
                if (i<0||i>=Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[i]; }
            set {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                items[i] = value; }
        }
        public void Add(int element)
        {
            if (Count==items.Length)
            {
                int[] newArray = new int[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items= newArray;
            }
            items[Count++] = element;
        }
        public int RemoveAt(int index)
        {
            if (index>=Count || index<0)
            {
                throw new InvalidOperationException();
            }

            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }

            int element = items[index];
            Count--;
            if (Count < items.Length/4)
            {
                int[] tempArr = new int[items.Length / 2];
                for (int i = 0; i < Count; i++)
                {
                    tempArr[i] = items[i];
                }
                items = tempArr;
            }
            return element;
        }
        public bool Contains(int element)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]==element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int first,int second)
        {
            if (first<0||first>=Count||second<0||second>=Count)
            {
                throw new IndexOutOfRangeException();
            }
            int tempEl = items[first];
            items[first]= items[second];
            items[second]= tempEl;
        }
        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write(items[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
