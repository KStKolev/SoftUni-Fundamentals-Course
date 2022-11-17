namespace GaussTrick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int inputNumbersCount = inputNumbers.Count;
            for (int i = 0; i < inputNumbersCount / 2 ; i++)
            {
                inputNumbers[i] = inputNumbers[i] + inputNumbers[inputNumbers.Count - 1];
                inputNumbers.RemoveAt(inputNumbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
            Console.Read();
        }
    }
}
