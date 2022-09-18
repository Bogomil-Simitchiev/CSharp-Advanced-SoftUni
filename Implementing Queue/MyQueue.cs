using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueue
{
    public class MyQueue
    {
        private const int Capacity = 3;
        private int[] items;

        public MyQueue()
        {
            items = new int[Capacity];
        }
        public int Count { get; private set; }

        public void Enqueue(int element)
        {
            if (items.Length==Count)
            {
                int[] newArr = new int[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newArr[i] = items[i];
                }
                items = newArr;
            }

            items[Count++] = element;
            
        }
        public int Dequeue()
        {
            if (Count==0)
            {
                Console.WriteLine("Queue is empty!");
                return 0;
            }
            int element = items[0];
            int[] newArra = new int[items.Length-1];

            for (int i = 0; i < items.Length-1; i++)
            {
                newArra[i] = items[i + 1];
            }
            items=newArra;
            Count--;
            return element;
        }
        public bool Contains(int element)
        {
            foreach (var item in items)
            {
                if (item==element)
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            Count = 0;
            items = new int[2];

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
