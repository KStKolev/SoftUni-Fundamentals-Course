namespace CountRealNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, int> digitValues = new SortedDictionary<string, int>();
            string[] numberArray = Console.ReadLine()
                .Split()
                .ToArray();
            foreach (var currentNumber in numberArray)
            {
                if (!digitValues.ContainsKey(currentNumber))
                {
                    digitValues.Add(currentNumber, 0);
                }
                digitValues[currentNumber]++;
            }
            foreach (var currentDigit in digitValues)
            {
                Console.WriteLine($"{currentDigit.Key} -> {currentDigit.Value}");
            }
            Console.Read();
        }
    }
}
