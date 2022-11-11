namespace EqualArrays
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int index = 0;
            for (int i = 0; i < firstInput.Length; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    sum += firstInput[i];
                }
                else if (firstInput[i] != secondInput[i])
                {
                    index = i;
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
