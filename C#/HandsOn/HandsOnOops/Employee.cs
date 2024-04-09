using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOops
{
     class Employee
    {
       //instance variable
        public int employee_id;
        public string employee_name;
        //static variable
        public static string organisation;
        public static string project;
        public void Details()
        {
            Console.WriteLine($"Id:{employee_id} Name:{employee_name} " +
                $"Org:{organisation} Project:{project}");
        }
        static void Main()
        {
            Employee.organisation = "Dexian";
            Employee.project = "HealthCare";
            Employee e1 = new Employee() { employee_id = 34289, employee_name = "Rajan" };
            Employee e2 = new Employee() { employee_id = 345454, employee_name = "Pavan" };
            Employee e3 = new Employee() { employee_id = 332342, employee_name = "Rohan" };
            e1.Details();
            e2.Details();
            e3.Details();
            Console.WriteLine();
            Employee.organisation = "IBM";
            Employee.project = "EComm";
            Employee e4 = new Employee() { employee_id = 34289, employee_name = "Rajan" };
            Employee e5 = new Employee() { employee_id = 345454, employee_name = "Pavan" };
            e4.Details();
            e5.Details();
        }
    }
}
