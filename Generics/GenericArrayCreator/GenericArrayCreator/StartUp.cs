using GenericArrayCreator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericArrayCreator 
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] array = ArrayCreator<int>.Create(10, 2);
            
        }
    }
}