using System.Collections.Generic;
namespace HandsOnGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nos = new List<int>() { 12, 23, 34, 45, 45, 56 }; //collection initializer
            List<string> list = new List<string>();
            //add items
            list.Add("Rose");
            list.Add("Lilly");
            list.Add("Jasmine");
            list.Add("Tulips");
            Console.WriteLine("Size: "+list.Count); //return size of the list
            list.Add("Marigold");
            Console.WriteLine("Size: " + list.Count);
            //access item fro list
            Console.WriteLine("Flower: " + list[2]);
            //remove item
            list.Remove("Tulips");
            //access all items
            foreach(var  item in list)
                Console.WriteLine(item);
            //sort items
            list.Sort();
            //reverse items
            list.Reverse();
        }
    }
}
