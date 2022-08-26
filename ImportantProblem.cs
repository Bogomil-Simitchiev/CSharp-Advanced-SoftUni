using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            int[,] matrix = new int[input[0], input[1]];

  

            for (int i = 0; i < input[0]; i++)
            {
                string[] inputHere = Console.ReadLine().Split(", ");
                for (int j = 0; j < input[1]; j++)
                {
                    matrix[i, j] = int.Parse(inputHere[j]);
                   
                }
            }
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;

            int max = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum>max)
                    {
                        max = sum;
                        first = matrix[i, j];
                        second = matrix[i, j+1];
                        third = matrix[i+1, j];
                        fourth = matrix[i+1, j+1];


                    }
                }
            }
            Console.WriteLine(first+" "+second);
            Console.WriteLine(third+" "+fourth);
            Console.WriteLine(max);

        }
    }
}