namespace Courses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string command = string.Empty;
            command = PrintAllCourses(courses);
        }

        private static string PrintAllCourses(Dictionary<string, List<string>> courses)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arrayCommand = command.Split(" : ");
                string courseName = arrayCommand[0];
                string studentName = arrayCommand[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);
            }
            foreach (var currentCourse in courses)
            {
                Console.WriteLine($"{currentCourse.Key}: {currentCourse.Value.Count}");
                currentCourse.Value.ForEach(x => Console.WriteLine($"-- {x}"));
            }
            Console.Read();
            return command;
        }
    }
}

