using GenericsExercises;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace GenericsExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();
            string[] thirdLine = Console.ReadLine().Split();

            bool IsDrunk = secondLine[2] == "drunk";


            Threeuple<string, string, string> first = new Threeuple<string, string, string>($"{firstLine[0]} {firstLine[1]}", firstLine[2], String.Join(" ", firstLine.Skip(3)));
            Threeuple<string, int, bool> second = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]),IsDrunk);

            Threeuple<string, double, string> third = new Threeuple<string, double, string>(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);

            Console.WriteLine(first.Get());
            Console.WriteLine(second.Get());
            Console.WriteLine(third.Get());


        }
    }
}
