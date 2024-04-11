using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Std { get; set; }
        public char Section { get; set; }
    }
    internal class Demo1
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1,Name="Rachan",Age=10,Std="4",Section='A'},
                 new Student() { Id = 2,Name="Ram",Age=11,Std="5",Section='B'},
                  new Student() { Id = 3,Name="Rahim",Age=12,Std="6",Section='A'},
                   new Student() { Id = 4,Name="Robert",Age=10,Std="4",Section='B'},
                    new Student() { Id = 5,Name="Krishna",Age=11,Std="5",Section='A'},
                     new Student() { Id = 6,Name="Arjun",Age=12,Std="6",Section='B'},
                      new Student() { Id = 7,Name="Monica",Age=10,Std="4",Section='A'},
                       new Student() { Id = 8,Name="Suren",Age=11,Std="5",Section='B'},
                        new Student() { Id = 9,Name="Jaya",Age=12,Std="6",Section='A'},
                         new Student() { Id = 10,Name="Kaira",Age=10,Std="4",Section='B'},
            };
            //fetch students with age 10
            List<Student> l1=students.Where(n=>n.Age==10).ToList();
            //fetch students with their std 4
            Student[] l2 = students.Where(n => n.Std == "4").ToArray();
            //sort with Name
            l2 = students.Where(n => n.Std == "5").OrderBy(n => n.Name).ToArray();
            //sort with Name descending order
            l2 = students.Where(n => n.Std == "5").OrderByDescending(n => n.Name).ToArray();
            // fetch stundets with std 5 and section 'A'
            l2 = students.Where(s => s.Std == "5" && s.Section == 'A').ToArray();

            foreach (var item in l2)
            {
                Console.WriteLine($"Id:{item.Id} Name:{item.Name} Age:{item.Age}");
            }
            Console.WriteLine();
            //get studnet details of Id=4
            //SingleOrDefault() return null when expression not return any records
            Student ?obj = students.SingleOrDefault(s => s.Id == 14);
            if (obj != null)
            {
                Console.WriteLine($"Id:{obj.Id} Name:{obj.Name} Age:{obj.Age}");
            }
            else
                Console.WriteLine("Invalid Id");

        }
    }
}
