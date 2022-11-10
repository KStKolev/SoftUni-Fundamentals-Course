namespace IntegerOperations
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long firstSum = (long)firstNumber + secondNumber;
            long secondDivide = firstSum / thirdNumber;
            long thirdMultiply = secondDivide * fourthNumber;
            Console.WriteLine(thirdMultiply);
        }
    }
}
