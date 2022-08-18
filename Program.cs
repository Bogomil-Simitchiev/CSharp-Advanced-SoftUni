using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SoftUni2022
{

    public class Program
    {
        public static void Main()
        {
            //we read the input
            string input = Console.ReadLine();
            Stack<char> stackOfType = new Stack<char>();
            bool isBalanced = false;

            // check if length of the input is even
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                //take current character at current index from the input
                char currentChar = input[i];
                if (currentChar=='{'||currentChar=='['||currentChar=='(')
                {
                    stackOfType.Push(currentChar);
                    //push the character in the stack
                }
                else if (currentChar=='}'||currentChar==']'||currentChar==')')
                {
                    char open = stackOfType.Pop();
                    //take open symbol from the stack
                    if (open=='{'&&currentChar=='}')
                    {
                        isBalanced = true;
                    }
                    else if (open=='['&&currentChar==']')
                    {
                        isBalanced = true;

                    }
                    else if (open=='('&&currentChar==')')
                    {
                        isBalanced = true;

                    }
                    else
                    {
                        isBalanced = false;
                        break;
                        //find that some pairs are not open and closed and break the loop
                    }

                }              

            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
        
    }
}

