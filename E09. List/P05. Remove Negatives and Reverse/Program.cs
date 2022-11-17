namespace RemoveNegativesAndReverse

{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] < 0)
                {
                    inputNumbers.RemoveAt(i);
                    i = -1;
                }
            }
            if (inputNumbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            inputNumbers.Reverse();
            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
