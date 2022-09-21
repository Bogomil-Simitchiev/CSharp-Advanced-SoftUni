using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            int count = 0;
            List<char> listPear = new List<char>()
            {
                'p','e','a','r'
            };
            List<char> listFlour = new List<char>()
            {
                'f','l','o','u','r'
            };
            List<char> listPork = new List<char>()
            {
                'p','o','r','k'
            };
            List<char> listOlive = new List<char>()
            {
                'o','l','i','v','e'
            };

            bool isTherePear=false;
            bool isThereFlour = false;
            bool isTherePork = false;
            bool isThereOlive = false;



            //e a u o
            //p r l x f         
            char[] vowels = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            char[] consonants = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            Queue<char> queue = new Queue<char>(vowels);
            Stack<char> stack = new Stack<char>(consonants);


            while (stack.Count>0)
            {

                char queueEl = queue.Dequeue();
                char stackEl = stack.Pop();
                if (listPear.Contains(queueEl))
                {
                   listPear.Remove(queueEl);

                }
                if (listFlour.Contains(queueEl))
                {
                    listFlour.Remove(queueEl);
                }
                if (listPork.Contains(queueEl))
                {
                    listPork.Remove(queueEl);
                }
                if (listOlive.Contains(queueEl))
                {
                    listOlive.Remove(queueEl);
                }





                if (listPear.Contains(stackEl))
                {
                    listPear.Remove(stackEl);

                }
                if (listFlour.Contains(stackEl))
                {
                    listFlour.Remove(stackEl);
                }
                if (listPork.Contains(stackEl))
                {
                    listPork.Remove(stackEl);
                }
                if (listOlive.Contains(stackEl))
                {
                    listOlive.Remove(stackEl);
                }


                if (listPear.Count==0 && isTherePear==false)
                {
                    count++;
                   
                    isTherePear=true;
                }
                if (listFlour.Count==0&& isThereFlour==false)
                {
                    count++;
                   
                    isThereFlour=true;
                }
                if (listPork.Count==0&& isTherePork==false)
                {
                    count++;
                   
                    isTherePork=true;
                }
                if (listOlive.Count==0 && isThereOlive==false)
                {
                    count++;
                    
                    isThereOlive=true;
                }

                queue.Enqueue(queueEl);
            }
            Console.WriteLine($"Words found: {count}");
            if (listPear.Count==0)
            {
                Console.WriteLine("pear");
            }
            if (listFlour.Count==0)
            {
                Console.WriteLine("flour");
            }
            if (listPork.Count==0)
            {
                Console.WriteLine("pork");
            }
            if (listOlive.Count==0)
            {
                Console.WriteLine("olive");
            }

        }
    }
}