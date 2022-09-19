using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        
       private List<T> internaList = new List<T>();
       public void Add(T element)
       {
            internaList.Add(element);
       }
        public int Count { get { return internaList.Count; } }

        public T Remove()
        {
            if (Count<=0)
            {
                Console.WriteLine("Box is empty!");
               
            }
            T element = internaList[internaList.Count - 1];
            internaList.RemoveAt(internaList.Count-1);
            return element;
        }
       
    }
}
