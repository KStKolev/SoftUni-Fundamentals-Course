namespace EqualSum
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int index = i;
                if (index + 1 > inputNumbers.Length - 1)
                {
                    break;
                }
                while (inputNumbers[i] > inputNumbers[index + 1])
                {
                    if (index + 1 == inputNumbers.Length - 1)
                    {
                        Console.Write($"{inputNumbers[i]} ");
                    }
                    index++;
                    if (index >= inputNumbers.Length - 1)
                    {
                        break;
                    }
                }
            }
            Console.Write($"{inputNumbers[inputNumbers.Length - 1]}");
        }
    }
}
