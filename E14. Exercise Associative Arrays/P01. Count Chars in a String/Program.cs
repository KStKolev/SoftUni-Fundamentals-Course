namespace CountCharsInAString
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            CountChars(countChars);
        }

        private static void CountChars(Dictionary<char, int> countChars)
        {
            char[] inputSymbols = Console.ReadLine()
                            .ToCharArray();
            foreach (char currentSymbol in inputSymbols)
            {
                if (currentSymbol.Equals(' '))
                {
                    continue;
                }
                if (!countChars.ContainsKey(currentSymbol))
                {
                    countChars.Add(currentSymbol, 0);
                }
                countChars[currentSymbol]++;
            }
            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.Read();
        }
    }
}
