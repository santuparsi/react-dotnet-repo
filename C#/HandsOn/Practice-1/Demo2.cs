using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    internal class Demo2
    {
        static void Main()
        {
            //arrys
            //datatype []array_name=new datatype[size]
            int[] a = new int[4];
            //assign value
            a[0] = 98;
            a[1] = 34;
            a[2] = 56;
            a[3] = 56;
            Console.WriteLine(a[3]);
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            foreach (int i in a)
                Console.WriteLine(i);
        }
    }
}
