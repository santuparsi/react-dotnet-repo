using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
    internal class Car
    {
        public string make;
        public string model;
        public double price;
       
    }
    class CarRepository
    {
        public Car[] cars = new Car[4];
        int idx = 0;
        public void AddCar(Car car) //Add Car
        {
            if (idx < cars.Length)
            {
                cars[idx] = car; //add car object details to array
                idx++;
            }
            else
            {
                Console.WriteLine("U can't add any Car");
            }

        }
        public Car GetCar(string model)
        {
            foreach (var car in cars)
            {
                if (car != null)

                    if (car.model == model)
                    {
                        return car;
                    }
            }
            
            return null;
        }
        public Car[] GetCars(string make)
        {
           var result=cars.Where(c=>c.make==make).ToArray();
            return result;
        }
    }
    class Test_Car
    {
        static void Main()
        {
            CarRepository carRepository = new CarRepository(); 
            do
            {
                Console.WriteLine("1.AddCar\n2.GetCarByModel\n3.GetCrasByMake\n4.Exit");
                Console.WriteLine("Enter Option");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Car car = new Car();
                            Console.WriteLine("Enter Car Make");
                            car.make = Console.ReadLine();
                            Console.WriteLine("Enter Car Model");
                            car.model = Console.ReadLine();
                            Console.WriteLine("Enter Car Price");
                            car.price = double.Parse(Console.ReadLine());

                            carRepository.AddCar(car);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Car Model");
                            string model = Console.ReadLine();
                            Car car = carRepository.GetCar(model);
                            if (car != null)
                            {
                                Console.WriteLine($"Make:{car.make} Model:{car.model} Price:{car.price}");
                            }
                            else
                                Console.WriteLine("Invalid Car Model");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Car Make");
                            string make = Console.ReadLine();
                            Car[]cars=carRepository.GetCars(make);
                            if (cars.Length>0)
                            {
                                foreach (var car in cars)
                                {
                                    if (car != null)
                                        Console.WriteLine($"Make:{car.make} Model:{car.model} Price:{car.price}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Car Make");
                            }
                           
                        }
                        break;
                    case 4:
                        {
                            Environment.Exit(0); //exit the application
                        }
                        break;


                }
            }while(true);
        }
    }
}
