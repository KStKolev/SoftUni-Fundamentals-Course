namespace CardsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> firstInputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondInputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (firstInputNumbers.Count > 0 && secondInputNumbers.Count > 0)
            {
                if (firstInputNumbers[0] > secondInputNumbers[0])
                {
                    firstInputNumbers.Add(secondInputNumbers[0]);
                    firstInputNumbers.Add(firstInputNumbers[0]);
                    firstInputNumbers.RemoveAt(0);
                    secondInputNumbers.RemoveAt(0);
                }
                else if (secondInputNumbers[0] > firstInputNumbers[0])
                {
                    secondInputNumbers.Add(firstInputNumbers[0]);
                    secondInputNumbers.Add(secondInputNumbers[0]);
                    secondInputNumbers.RemoveAt(0);
                    firstInputNumbers.RemoveAt(0);
                }
                else if (firstInputNumbers[0] == secondInputNumbers[0])
                {
                    secondInputNumbers.RemoveAt(0);
                    firstInputNumbers.RemoveAt(0);
                }
            }
            if (firstInputNumbers.Count > 0)
            {
                for (int i = 0; i < firstInputNumbers.Count; i++)
                {
                    sum += firstInputNumbers[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondInputNumbers.Count > 0)
            {
                for (int i = 0; i < secondInputNumbers.Count; i++)
                {
                    sum += secondInputNumbers[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            Console.Read();
        }
    }
}
