using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    internal class Employee
    {
        public virtual void Allowance()
        {
            Console.WriteLine("Car Allowance");
            Console.WriteLine("Lunch Allowace");
        }
    }
    class Manager:Employee
    {
        public override void Allowance() //extending allowance functionality in Manager class
        {
            base.Allowance();
            Console.WriteLine("Dinner Allowance");
            Console.WriteLine("Travel Allowance");
        }
        public void HandleProjects() { }
    }
    class HR:Employee
    {
        public override void Allowance() //redifine allowance functionality in HR class
        {
            Console.WriteLine("Travel Allowance");
            Console.WriteLine("Phone Allowance");
        }
    }
    class Test
    {
        static void Main()
        {
            Employee emp = null;
            while(true)
            {
                Console.WriteLine("1.Programmer\n2.Manager\n3.HR");
                Console.WriteLine("Enter Employee type");
                int type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        emp = new Employee();
                        emp.Allowance();
                        break;
                    case 2:
                        emp = new Manager();
                        emp.Allowance();
                       
                        break;
                    case 3:
                        emp = new HR();
                        emp.Allowance();
                        break;
                }
            }

        }
    }
}
