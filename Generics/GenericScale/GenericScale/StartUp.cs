using GenericScale;
using System;

namespace MyApp 
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<int> masiv = new EqualityScale<int>(1,1);

            Console.WriteLine(masiv.AreEqual());
        }
    }
}