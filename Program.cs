using System;

namespace week7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var firstStudent = new Student("John", 25);
            firstStudent.ShowStudentInfo();

            var firstTeacher = new Teacher("Mr.Jake", 45);
            firstTeacher.ShowTeacher();
            
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Greet()
            {
                Console.WriteLine($"Hello my name is {Name}");
            }
            public void ShowAge()
            {
                Console.WriteLine($"I am {Age} years old");
            }
        }

        public class Student : Person
        {
            public Student(string name, int age) : base(name,age)
            {

            }

            public void GoToClasses()
            {
                Console.WriteLine("I am going to class");
            }

            public void ShowStudentInfo()
            {

                Greet();
                ShowAge ();
                GoToClasses();
            }

        }
        public class Teacher : Person
        {
            private string subject = "math";

            public Teacher(string name, int age) : base (name, age)
            {
                Name = name;
                Age = age;

            }
            public void TeacherName()
            {
                Console.WriteLine($"My name is {Name}");
            }
            public void TeacherAge()
            {
                Console.WriteLine($"I am {Age} years old");
            }
        

                public void ShowTeacher()
            {
                TeacherName();
                TeacherAge();
                Explain();
                
            }

            public void Explain()
            {
                Console.WriteLine($"Explanation begins {subject}");
            }
        }



    }
}
