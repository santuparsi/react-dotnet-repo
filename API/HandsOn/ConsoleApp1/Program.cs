namespace ConsoleApp1
{
    class Car
    {
        public string make;
        public string model;

        public Car(string make, string model)
        {
            this.make = make;
            this.model = model;
        }
        public void Details()
        {
            Console.WriteLine($"Make:{make} Model:{model}");
        }
    }
    class Garage
    {
        public Car car;
        //public Garage()
        //{
        //    car = new Car();
        //}
        //create car object using DI
        public Garage(Car car)
        {
            this.car = car;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Garage garage = new Garage(new Car("Hundai", "i10"));
        }
    }
}
