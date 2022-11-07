using System;

namespace Passed
{
   public class Program
    {
       public static void Main(string[] args)
        {
            float studentGrade = float.Parse(Console.ReadLine());
            if (studentGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            Console.Read();
        }
    }
}
