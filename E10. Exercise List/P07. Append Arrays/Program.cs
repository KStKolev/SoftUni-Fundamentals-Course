namespace AppendArrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();
            List<int> numbers = new List<int>();
            foreach (var s in inputList)
            {
                numbers.AddRange(s.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
            Console.Read();
        }
    }
}
