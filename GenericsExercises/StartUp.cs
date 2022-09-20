using GenericsExercises;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GenericsExercises 
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int text = int.Parse(Console.ReadLine());
                box.Add(text);
            }
            Console.WriteLine(box);
        }
    }
}
