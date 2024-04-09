namespace HandsOnInheritance
{
    class A //base class
    {
        public int k;
        public int l;
        public void Foo()
        {
            Console.WriteLine($"k={k} l={l}");
        }
    }
    //derived class
    class B:A
    {
        public int j;
        public void M()
        {
            Console.WriteLine($"k={k} l={l} j={j}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj=new B();
            obj.l = 10; //A
            obj.j=18;
            obj.k = 100; //A
            obj.Foo(); //A
            obj.M();
        }
    }
}
