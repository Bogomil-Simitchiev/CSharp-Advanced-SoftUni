using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class DoublyLinkedList
    {
        private LinkedListItem first = null;
        private LinkedListItem last = null;
        public int Count { get; private set; }
        public void AddFirst(int element)
        {
            var newItem = new LinkedListItem(element);
            if (first==null)
            {
                first = newItem;
                last = newItem;

            }
            else
            {
                newItem.Next = first;
                first.Previous = newItem;
                first = newItem;
            }
             Count++;
        }
        public void AddLast(int element)
        {
            var newItem = new LinkedListItem(element);
            if (last == null)
            {
                last = newItem;
                first = newItem;
               

            }
            else
            {
                last.Next = newItem;
                newItem.Previous = last;
                last = newItem;
            }
            Count++;

        }
        public int RemoveFirst()
        {

            if (first==null)
            {
                throw new InvalidOperationException("Linked List is empty!");

            }
            var current = first.Value;
            if (first==last)
            {
                first = null;
                last = null;

            }
            else
            {
                var newFirst = first.Next;
                newFirst.Previous = null;
                first= newFirst;
            }
            Count--;

            return current;
        }
        public int RemoveLast()
        {
            if (last == null)
            {
                throw new InvalidOperationException("Linked List is empty!");

            }
            var current = last.Value;
            if (first == last)
            {
                first = null;
                last = null;

            }
            else
            {
                var newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }
            Count--;

            return current;
        }
        public int[] ToArray()
        {
            var array = new int[Count];
            int index = 0;
            var current = first;
            while (current!=null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }
            return array;
        }
        public void ForEach(Action<int> action)
        {
            var current = first;
            while (current!=null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
    }
}