using ImplementingLinkedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            DoublyLinkedList list = new DoublyLinkedList();
            list.AddLast(1);
            list.AddFirst(2);
            list.AddLast(1);
            list.AddLast(1);
            list.AddLast(1);
            list.RemoveLast();
            Console.WriteLine(list.Count);
            Console.WriteLine(String.Join(", ", list.ToArray()));
            list.ForEach(x => Console.WriteLine("-"+x));
        }
    }
}