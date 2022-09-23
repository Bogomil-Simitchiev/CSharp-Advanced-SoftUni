using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercises
{
    public class Threeuple<Item1, Item2, Item3>
    {
        public Threeuple(Item1 item1 , Item2 item2 , Item3 item3)
        {
            FirstItem=item1;
            secondItem=item2;
            thirdItem=item3;
        }

        public Item1 FirstItem { get; set; }
        public Item2 secondItem { get; set; }
        public Item3 thirdItem { get; set; }

        public string Get()
        {
            return $"{FirstItem} -> {secondItem} -> {thirdItem}";
        }
    }
}
