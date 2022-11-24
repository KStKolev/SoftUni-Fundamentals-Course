namespace WordFilter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] textArray = Console.ReadLine()
                .Split(" ")
                .Where(x => x.Length % 2 == 0)
                .ToArray();
            foreach (var currentWord in textArray)
            {
                Console.WriteLine(currentWord);
            }
            Console.Read();
        }
    }
}
