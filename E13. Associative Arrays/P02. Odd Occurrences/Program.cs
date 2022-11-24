namespace OddOccurrences
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> inputCollection = new Dictionary<string, int>();
            string[] inputArray = Console.ReadLine()
                .ToLower()
                .Split();
            foreach (var currentSymbol in inputArray)
            {
                if (!inputCollection.ContainsKey(currentSymbol))
                {
                    inputCollection.Add(currentSymbol, 0);
                }
                inputCollection[currentSymbol]++;
            }
            foreach (var key in inputCollection.Where(x => x.Value % 2 != 0))
            {
                Console.Write($"{key.Key} ");
            }
            Console.Read();
        }
    }
}

