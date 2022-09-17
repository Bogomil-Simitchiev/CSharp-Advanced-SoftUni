using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStack
{
    public class MyStack<T>
    {
        private const int Capacity = 4;
        private T[] elements;

        public MyStack()
        {
            elements= new T[Capacity];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (Count==elements.Length)
            {
                Resize();
            }
            elements[Count++] = element;
        }
        public T Pop()
        {
            if (Count==0)
            {
                throw new InvalidOperationException();
            }

            T element = elements[Count-1];

            Count--;
            if (Count<=elements.Length/4)
            {
                Shrink();
            }
            return element;
        }
        public T Peek()
        {
            if (Count==0)
            {
                throw new InvalidOperationException();
            }
            return elements[Count-1];
        }
        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(elements[i]);
            }
        }
        private void Shrink()
        {
            T[] copyArray = new T[elements.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copyArray[i] = elements[i];
            }
            elements = copyArray;
        }

        private void Resize()
        {
            T[] copyArray = new T[elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                copyArray[i] = elements[i];
            }
            elements = copyArray;
        }
    }
}
