namespace MultiplyEvensByOdds
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplyOfEvenAndOddSum = GetMultipleOfEvenAndOdds(inputNumber);
            Console.WriteLine(multiplyOfEvenAndOddSum);
            Console.Read();
        }
        private static int GetSumOfEvenDigits(int inputNumber)
        {
            int evenSum = 0;
            if (inputNumber < 0)
            {
                inputNumber = Math.Abs(inputNumber);
            }
            while (inputNumber > 0)
            {
                int evenLocate = inputNumber % 10;
                inputNumber /= 10;
                if (evenLocate % 2 == 0)
                {
                    evenSum += evenLocate;
                }
            }
            return evenSum;
        }
        private static int GetSumOfOddDigits(int inputNumber)
        {
            int oddSum = 0;
            if (inputNumber < 0)
            {
                inputNumber = Math.Abs(inputNumber);
            }
            while (inputNumber > 0)
            {
                int evenLocate = inputNumber % 10;
                inputNumber /= 10;
                if (evenLocate % 2 != 0)
                {
                    oddSum += evenLocate;
                }
            }
            return oddSum;
        }
        private static int GetMultipleOfEvenAndOdds(int inputNumber)
        {
            return GetSumOfOddDigits(inputNumber) * GetSumOfEvenDigits(inputNumber);
        }
    }
}
