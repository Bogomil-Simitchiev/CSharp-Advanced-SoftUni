﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age): this()
        {
            Age = age;
        }
        public Person(string name,int age)
        {
            Age = age;
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
