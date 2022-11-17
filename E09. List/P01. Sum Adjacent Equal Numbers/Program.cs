namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> inputNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (i + 1 == inputNumbers.Count)
                {
                    break;
                }
                if (inputNumbers[i] == inputNumbers[i + 1])
                {
                    inputNumbers[i] += inputNumbers[i];
                    inputNumbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", inputNumbers));
            Console.Read();
        }
    }
}
