using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    internal class Calculate
    {
        //method overloading and static polymorphism
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Main()
        {
            Calculate calc = new Calculate();
            calc.Add(3, 4);
            calc.Add(2, 3, 4);
            calc.Add(23.3, 34.4);
        }
    }
}
