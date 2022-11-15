namespace MathOperations
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstInputNumber = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());
            int secondInputNumber = int.Parse(Console.ReadLine());
            if (mathOperator.Equals('+'))
            {
                int addSum = AddNumbers(firstInputNumber, secondInputNumber);
                Console.WriteLine(addSum);
            }
            else if (mathOperator.Equals('-'))
            {
                int subtractSum = SubtractNumbers(firstInputNumber, secondInputNumber);
                Console.WriteLine(subtractSum);
            }
            else if (mathOperator.Equals('*'))
            {
                int multiplySum = MultiplyNumbers(firstInputNumber, secondInputNumber);
                Console.WriteLine(multiplySum);
            }
            else if (mathOperator.Equals('/'))
            {
                int DivideSum = DivideNumbers(firstInputNumber, secondInputNumber);
                Console.WriteLine(DivideSum);
            }
            Console.Read();
        }
        private static int AddNumbers(int firstInputNumber, int secondInputNumber)
        {
            return firstInputNumber + secondInputNumber;
        }
        private static int SubtractNumbers(int firstInputNumber, int secondInputNumber)
        {
            return firstInputNumber - secondInputNumber;
        }
        private static int MultiplyNumbers(int firstInputNumber, int secondInputNumber)
        {
            return firstInputNumber * secondInputNumber;
        }
        private static int DivideNumbers(int firstInputNumber, int secondInputNumber)
        {
            return firstInputNumber / secondInputNumber;
        }
    }
}
