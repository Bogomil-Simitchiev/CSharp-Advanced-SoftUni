using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ImplementingStack
{
    public class StartUp
    {

        public static void Main(string[] args)
        {

            MyList list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Swap(0, 4);
            bool isThere = list.Contains(56);
           list.Print();
            Console.WriteLine(isThere);

            MyStack<string> stack = new MyStack<string>();

            stack.Push("az");
            stack.Push("ti");
            stack.Push("toi");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Count);


        }

    }

}