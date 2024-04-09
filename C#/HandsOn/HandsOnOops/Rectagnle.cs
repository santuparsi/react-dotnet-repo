using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    internal class Rectangle
    {
        int l, w;
        //default construnctor
        public Rectangle()
        {
            l = 12;
            w = 23;
        }
        //Parameter constructor
        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        //copy constructor
        public Rectangle(Rectangle ob)
        {
            l = ob.l;
            w = ob.w;
        }
        public void Area()
        {
            Console.WriteLine("Area= " + (l * w));
        }
        static void Main()
        {
            Rectangle r = new Rectangle();
            Rectangle r1=new Rectangle(2,3);
            Rectangle r2 = new Rectangle(r1); //r1 object data is copy to r2
            Rectangle r3 = new Rectangle(r);  //r object data is copy to r2
            r.Area();
            r1.Area();
            r2.Area();
            r3.Area();
        }
    }
}
