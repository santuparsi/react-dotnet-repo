using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class Demo3
    {
        static void Main()
        {
            Stack<string> flowers= new Stack<string>();
            //add items
            flowers.Push("Rose");
            flowers.Push("Lilly");
            flowers.Push("Tulips");
            Console.WriteLine("Access item: " + flowers.Peek()); //retruns last item
            Console.WriteLine();
            foreach(var k in flowers)
                Console.WriteLine(k);
            flowers.Pop(); //last item removed

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Rose");
            queue.Enqueue("Lilly");
            queue.Enqueue("Tulips");
            Console.WriteLine("Access item: " + queue.Peek()); //retruns last item
            Console.WriteLine();
            foreach (var k in queue)
                Console.WriteLine(k);
            queue.Dequeue(); //last item removed

        }
    }
}
