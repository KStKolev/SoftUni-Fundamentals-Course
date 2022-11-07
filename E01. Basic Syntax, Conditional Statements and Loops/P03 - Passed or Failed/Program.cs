using System;

namespace PassedOrFailed
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double studentGrade = double.Parse(Console.ReadLine());
            if (studentGrade > 2.99)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
            Console.Read();
        }
    }
}
