using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security;
using System.Threading;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                }
            }
           
            char whitePlayer = 'w';
            char blackPlayer = 'b';

            int randomWhitePlaceRow = 0;
            int randomWhitePlaceCol = 0;

            int randomBlackPlaceRow = 0;
            int randomBlackPlaceCol = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i,j]=='w')
                    {
                        randomWhitePlaceRow = i;
                        randomWhitePlaceCol = j;

                    }
                    else if (board[i,j]=='b')
                    {
                        randomBlackPlaceRow = i;
                        randomBlackPlaceCol = j;
                    }
                }
            }

            int count = 0;



            while (true)
            {

                if (count % 2 == 0)
                {
                    if (randomWhitePlaceRow-1>=0&&randomWhitePlaceCol-1>=0)
                    {
                        if ((board[randomWhitePlaceRow - 1, randomWhitePlaceCol - 1] == 'b'))
                        {
                            string position = "";
                            switch (randomBlackPlaceCol)
                            {
                                case 0:
                                    position = "a";
                                    break;
                                case 1:
                                    position = "b";

                                    break;
                                case 2:
                                    position = "c";

                                    break;
                                case 3:
                                    position = "d";

                                    break;
                                case 4:
                                    position = "e";

                                    break;
                                case 5:
                                    position = "f";

                                    break;
                                case 6:
                                    position = "g";

                                    break;
                                case 7:
                                    position = "h";
                                    break;

                            }
                            Console.WriteLine($"Game over! White capture on {position}{8 - randomBlackPlaceRow}.");
                            break;
                        }
                    }
                    if (randomBlackPlaceRow-1>=0&&randomWhitePlaceCol+1<n)
                    {
                        if ((board[randomWhitePlaceRow - 1, randomWhitePlaceCol + 1] == 'b'))
                        {
                            string position = "";
                            switch (randomBlackPlaceCol)
                            {
                                case 0:
                                    position = "a";
                                    break;
                                case 1:
                                    position = "b";

                                    break;
                                case 2:
                                    position = "c";

                                    break;
                                case 3:
                                    position = "d";

                                    break;
                                case 4:
                                    position = "e";

                                    break;
                                case 5:
                                    position = "f";

                                    break;
                                case 6:
                                    position = "g";

                                    break;
                                case 7:
                                    position = "h";
                                    break;

                            }
                            Console.WriteLine($"Game over! White capture on {position}{8 - randomBlackPlaceRow}.");
                            break;
                        }
                    }
                    

                    randomWhitePlaceRow--;
                    board[randomWhitePlaceRow, randomWhitePlaceCol] = 'w';
                    board[randomWhitePlaceRow + 1, randomWhitePlaceCol] = '-';

                    if (randomWhitePlaceRow == 0)
                    {
                        string position = "";
                        switch (randomWhitePlaceCol)
                        {
                            case 0:
                                position = "a";
                                break;
                            case 1:
                                position = "b";

                                break;
                            case 2:
                                position = "c";

                                break;
                            case 3:
                                position = "d";

                                break;
                            case 4:
                                position = "e";

                                break;
                            case 5:
                                position = "f";

                                break;
                            case 6:
                                position = "g";

                                break;
                            case 7:
                                position = "h";
                                break;

                        }
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {position}8.");
                        break;
                    }


                }
                if (count % 2 != 0)
                {
                    if (randomBlackPlaceRow+1<n&&randomBlackPlaceCol-1>=0)
                    {
                        if ((board[randomBlackPlaceRow + 1, randomBlackPlaceCol - 1] == 'w'))
                        {
                            string position = "";
                            switch (randomWhitePlaceCol)
                            {
                                case 0:
                                    position = "a";
                                    break;
                                case 1:
                                    position = "b";

                                    break;
                                case 2:
                                    position = "c";

                                    break;
                                case 3:
                                    position = "d";

                                    break;
                                case 4:
                                    position = "e";

                                    break;
                                case 5:
                                    position = "f";

                                    break;
                                case 6:
                                    position = "g";

                                    break;
                                case 7:
                                    position = "h";
                                    break;

                            }
                            Console.WriteLine($"Game over! Black capture on {position}{8 - randomWhitePlaceRow}.");
                            break;
                        }
                    }

                    if (randomBlackPlaceRow+1<n&&randomBlackPlaceCol+1<n)
                    {
                        if ((board[randomBlackPlaceRow + 1, randomBlackPlaceCol + 1] == 'w'))
                        {
                            string position = "";
                            switch (randomWhitePlaceCol)
                            {
                                case 0:
                                    position = "a";
                                    break;
                                case 1:
                                    position = "b";

                                    break;
                                case 2:
                                    position = "c";

                                    break;
                                case 3:
                                    position = "d";

                                    break;
                                case 4:
                                    position = "e";

                                    break;
                                case 5:
                                    position = "f";

                                    break;
                                case 6:
                                    position = "g";

                                    break;
                                case 7:
                                    position = "h";
                                    break;

                            }
                            Console.WriteLine($"Game over! Black capture on {position}{8 - randomWhitePlaceRow}.");
                            break;
                        }
                    }
                    

                    randomBlackPlaceRow++;
                    board[randomBlackPlaceRow, randomBlackPlaceCol] = 'b';
                    board[randomBlackPlaceRow - 1, randomBlackPlaceCol] = '-';

                    if (randomBlackPlaceRow == 7)
                    {
                        string position = "";
                        switch (randomBlackPlaceCol)
                        {
                            case 0:
                                position = "a";
                                break;
                            case 1:
                                position = "b";

                                break;
                            case 2:
                                position = "c";

                                break;
                            case 3:
                                position = "d";

                                break;
                            case 4:
                                position = "e";

                                break;
                            case 5:
                                position = "f";

                                break;
                            case 6:
                                position = "g";

                                break;
                            case 7:
                                position = "h";
                                break;

                        }
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {position}1.");
                        break;
                    }


                }

                count++;

            }

        }
    }
}