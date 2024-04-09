using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    internal class Demo1
    {
        public void Message()
        {
            Console.WriteLine("Hello World!!");
        }
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Add(int a,int b=9)
        {
            Console.WriteLine("Sum= "+(a+b));
        }
        public void Sum(int[]a)
        {
            int k = 0;
            foreach(var n in a)
            {
                k = k + n;
                
            }
            Console.WriteLine("Sum= " + k);
        }
        static void Main()
        {
            Demo1 demo = new Demo1();
            demo.Message();
            demo.Greet("Virat");
            demo.Add(2, 3);
            demo.Add(3);
            demo.Sum(new int[] { 23, 34, 45, 45, 45 });
        }
    }
}
