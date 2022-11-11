namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputSymbols = Console.ReadLine()
                .Split()
                .ToArray();
            for (int i = inputSymbols.Length - 1; i >= 0; i--)
            {
                Console.Write($"{inputSymbols[i]} ");
            }
        }
    }
}
