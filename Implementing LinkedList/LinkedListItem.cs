using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class LinkedListItem
    {
        public LinkedListItem(int value)
        {
            Value = value;
        }
        public LinkedListItem Previous { get; set; }
        public LinkedListItem Next { get; set; }
        public int Value { get; set; }
    }
}
