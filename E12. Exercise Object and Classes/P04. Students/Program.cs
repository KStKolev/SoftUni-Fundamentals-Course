namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfLoop = int.Parse(Console.ReadLine());
            AddAndPrintStudents(numberOfLoop);
        }

        private static void AddAndPrintStudents(int numberOfLoop)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfLoop; i++)
            {
                string[] inputArray = Console.ReadLine().Split();
                string firstName = inputArray[0];
                string lastName = inputArray[1];
                double grades = double.Parse(inputArray[2]);
                Student student = new Student(firstName, lastName, grades);
                students.Add(student);
            }
            foreach (var item in students.OrderByDescending(g => g.Grades))
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grades)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grades = grades;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grades { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grades:F2}";
        }
    }
}
