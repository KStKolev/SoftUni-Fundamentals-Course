namespace MagicSum
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
            int number = int.Parse(Console.ReadLine());
            MagicSum(inputNumbers, number);
        }

        private static void MagicSum(int[] inputNumbers, int number)
        {
            for (int i = 0; i < inputNumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < inputNumbers.Length; j++)
                {
                    if (inputNumbers[i] + inputNumbers[j] == number)
                    {
                        Console.WriteLine($"{inputNumbers[i]} {inputNumbers[j]}");
                    }
                }
            }
        }
    }
}
