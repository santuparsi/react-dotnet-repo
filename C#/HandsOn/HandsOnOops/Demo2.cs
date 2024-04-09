using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    internal class Demo2
    {
        public string Greet(string name)
        {
            return "Hello " + name;
        }
        public bool IsEven(int no)
        {
            if(no%2==0)
                return true;
            else
                return false;
        }
        public string[] GetFlowers()
        {
            string[] flowers = new string[3] { "Rose", "Lilly", "Jasmie" };
            return flowers;
        }
        public static int Square(int no)
        {
            int result = no * no;
            return result;
        }
        static void Main()
        {
            var a = 309;
            var b = 34.45;
            var c = "Hello";
            var ob1 = new Demo2();
            Demo2 demo = new Demo2();
            int result=Demo2.Square(12);
            Console.WriteLine(result);
            Console.WriteLine(demo.Greet("Virat"));
            Console.WriteLine(demo.IsEven(2) ? "Even" : "Odd");
          string[]r= demo.GetFlowers();
            foreach(var k in r) Console.WriteLine(k);
            foreach (var k in demo.GetFlowers()) Console.WriteLine(k);

        }

    }
}
