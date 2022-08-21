using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            for (int i = 0; i < n; i++)
            {
                pascal[i] = new long[i+1];
                pascal[i][0] = 1;
                pascal[i][pascal[i].Length-1] = 1;
                for (int j = 1; j < pascal[i].Length-1; j++)
                {
                    pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }
            }
            foreach (var item in pascal)
            {
                Console.WriteLine(String.Join(" ",item));
            }

        }
    }
}