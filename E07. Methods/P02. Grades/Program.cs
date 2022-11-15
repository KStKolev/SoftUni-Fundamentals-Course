namespace Grades
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            CheckTypeOfGrade(inputNumber);
            Console.Read();
        }
        private static void CheckTypeOfGrade(double inputNumber) 
        {
            if (inputNumber >= 2 && inputNumber <= 2.99)
            {
                Console.WriteLine("Fail");
            }
           else if (inputNumber >= 3 && inputNumber <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (inputNumber >= 3.50 && inputNumber <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (inputNumber >= 4.50 && inputNumber <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (inputNumber >= 5.50 && inputNumber <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
