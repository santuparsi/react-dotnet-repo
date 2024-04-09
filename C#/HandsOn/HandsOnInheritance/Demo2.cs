using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class M
    {
        string name;
        //public M()
        //{
        //    Console.WriteLine("Class M Crated");
        //}
        public M(string name)
        {
            this.name = name;

        }
        public void Greet()
        {
            Console.WriteLine("Hello " + name);
        }
    }
    class N:M
    {
       
        public N():base("Hari") //base calls the parent constuctor
        {
            Console.WriteLine("Class N Created");
        }
        public N(string n):base(n)
        {
            
        }
    }
    internal class Demo2
    {
        static void Main()
        {
            N obj = new N();
            obj.Greet();
            N obj1 = new N("Virat");
            obj1.Greet();
            N obj2 = new N("Gourav");
            obj2.Greet();
        }
    }
}
