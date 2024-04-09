namespace HandsOnOops
{
    class Student
    {//class-memebers
        //variables(class-variable)
        //methods
        //constructors
        //properties
        //desctructors
        public int id;
        public string name;
        public int age;
        string std; //private
        public void Details() //show details of student
        {
            Console.WriteLine($"Id:{id} Name:{name} Age:{age}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate student object
            Student obj=new Student();
            obj.id = 344;
            obj.name = "Rohan";
            obj.age = 12;
            obj.Details();
            Student obj2= new Student();
            obj2.id = 989;
            obj2.name = "Raj";
            obj2.age = 11;
            obj2.Details();
            Student obj1 = new Student() { id=678,name="virat",age=10}; //object initializer
            //array of students
            Student[] students = new Student[5];
            //assing students
            students[0] = obj;
            students[1] = obj2;
            students[2] = obj1;
            students[3] = new Student() { id = 344, name = "Ram", age = 11 };
           students[4] = new Student() { id = 7789, name = "Suren", age = 11 };
            //access each object from array
            foreach(Student student in students)
            {
                student.Details();
            }

        }
    }
}
