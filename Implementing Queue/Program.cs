using ImplementingQueue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
           MyQueue queue = new MyQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Clear();

            queue.Enqueue(3);
            queue.Enqueue(3);
            queue.Enqueue(3);

            queue.Dequeue();

            bool isThere = queue.Contains(3);


            queue.Print();

            Console.WriteLine(isThere);
        }
    }
}