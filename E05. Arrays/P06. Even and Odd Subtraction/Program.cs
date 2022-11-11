namespace EvenAndOddSubtraction
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] % 2 == 0)
                {
                    evenSum += inputNumbers[i];
                }
                else
                {
                    oddSum += inputNumbers[i];
                }
                result = evenSum - oddSum;
            }
            Console.WriteLine(result);
        }
    }
}
