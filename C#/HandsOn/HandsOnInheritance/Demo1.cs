using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    class X
    {
        public int i;
        private int j; //not acccessable in inherited class
        protected int k;
        internal int m;
    }
    class Y : X
    {
        public void f()
        {
            i = 10;
            k = 67; //protected data access in derived class
            m = 90;
           
        }
    }
    internal class Demo1
    {
       static void Main()
        {
            Y obj=new Y();
            obj.i = 10; //access public data
            obj.m = 78; //access internal data
        }
    }
    
}
