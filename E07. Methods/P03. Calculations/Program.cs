namespace Calculations
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int firstInputNumber = int.Parse(Console.ReadLine());
            int secondInputNumber = int.Parse(Console.ReadLine());
            if (inputString.Equals("add"))
            {
                AddNumbers(firstInputNumber, secondInputNumber);
            }
            if (inputString.Equals("subtract"))
            {
                SubtractNumbers(firstInputNumber, secondInputNumber);
            }
            if (inputString.Equals("multiply"))
            {
                MultiplyNumbers(firstInputNumber, secondInputNumber);
            }
            if (inputString.Equals("divide"))
            {
                DivideNumbers(firstInputNumber, secondInputNumber);
            }
            Console.Read();
        }
        private static void AddNumbers(int firstInputNumber, int secondInputNumber)
        {
            int sum = firstInputNumber + secondInputNumber;
            Console.WriteLine(sum);
        }
        private static void SubtractNumbers(int firstInputNumber, int secondInputNumber)
        {
            int subtractNum = firstInputNumber - secondInputNumber;
            Console.WriteLine(subtractNum);
        }
        private static void MultiplyNumbers(int firstInputNumber, int secondInputNumber)
        {
            int multiplyNumbers = firstInputNumber * secondInputNumber;
            Console.WriteLine(multiplyNumbers);
        }
        private static void DivideNumbers(int firstInputNumber, int secondInputNumber)
        {
            int DivideNumbers = firstInputNumber / secondInputNumber;
            Console.WriteLine(DivideNumbers);
        }
    }
}
