﻿using System;

namespace BoxOfT 
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);

            box.Remove();
            box.Remove();
            

        }
    }
}
