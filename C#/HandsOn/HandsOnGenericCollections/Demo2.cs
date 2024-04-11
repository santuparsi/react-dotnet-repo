using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo2
    {
        static void Main()
        {
           // Dictionary<int,string> d= new Dictionary<int, string>();
            SortedList<int, string> d = new SortedList<int, string>();
            //add items
            d.Add(423094, "Rohan");
            d.Add(423032, "Tanay");
            d.Add(423098, "Shiva");
            d.Add(423012, "Asish");
            d.Add(423067, "Rishi");
            //fetch item
            Console.WriteLine(d[423067]);
            //remove item
            d.Remove(423098); //key-value remove
            foreach(var k in d.Keys)
            {
                Console.WriteLine($"Id:{k} Name:{d[k]}");
            }
            //remove item
            
        }
    }
}
