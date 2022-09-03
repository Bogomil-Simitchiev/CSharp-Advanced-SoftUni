using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int maxRotate = n * n;
            int row = 0;
            int col = 0;
            string tekst = "down";
            for (int i = 1; i <= maxRotate; i++)
            {

                if (tekst == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    tekst = "right";
                    row--;
                    col++;
                }
                if (tekst == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    tekst = "up";
                    col--;
                    row--;
                }
                if (tekst == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    tekst = "left";
                    row++;
                    col--;

                }
                if (tekst == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    tekst = "down";
                    col++;
                    row++;
                }
                matrix[row, col] = i;

                if (tekst == "down")
                {
                    row++;
                }
                if (tekst == "right")
                {
                    col++;
                }
                if (tekst == "up")
                {
                    row--;
                }
                if (tekst == "left")
                {
                    col--;
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)

                    Console.Write("{0,4}", matrix[i, j]);

                Console.WriteLine();
            }


        }
    }
}