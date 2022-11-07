using System;

namespace StudentInformation
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentAverageGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {studentName}, Age: {studentAge}, Grade: {studentAverageGrade:F2}");
            Console.Read();
        }
    }
}
