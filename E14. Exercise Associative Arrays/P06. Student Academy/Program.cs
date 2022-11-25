namespace StudentAcademy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            int pairOfRows = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> averageGrade = new Dictionary<string, List<double>>();
            AverageGrades(pairOfRows, averageGrade);
        }

        private static void AverageGrades(int pairOfRows, Dictionary<string, List<double>> averageGrade)
        {
            for (int i = 0; i < pairOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!averageGrade.ContainsKey(studentName))
                {
                    averageGrade.Add(studentName, new List<double>() { grade, 1 });
                }
                else
                {
                    averageGrade[studentName][0] += grade;
                    averageGrade[studentName][1]++;
                }
            }
            foreach (var currentStudent in averageGrade.Where(x => x.Value[0] / x.Value[1] >= 4.50))
            {
                Console.WriteLine($"{currentStudent.Key} -> {(currentStudent.Value[0] / currentStudent.Value[1]):F2}");
            }
            Console.Read();
        }
    }
}
