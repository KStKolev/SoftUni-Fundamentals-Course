namespace Students
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            string commands = string.Empty;
            List<Students> students = new List<Students>();
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandArray = commands.Split();
                string firstName = commandArray[0];
                string lastName = commandArray[1];
                int age = int.Parse(commandArray[2]);
                string homeTown = commandArray[3];
                Students student = new Students(firstName,
                    lastName,
                    age,
                    homeTown);
                students.Add(student);
            }
            string desiredTown = Console.ReadLine();
            foreach (var currentStudent in students)
            {
                if (desiredTown.Equals(currentStudent.HomeTown))
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
            Console.Read();
        }

        public class Students
        {
            public Students(string firstName, string lastName, int age, string homeTown)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                HomeTown = homeTown;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
