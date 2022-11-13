namespace Zig_ZagArrays
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int[] firstArray = new int[inputNumber];
            int[] secondArray = new int[inputNumber];
            int count = 0;
            for (int i = 0; i < inputNumber; i++)
            {
                int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] += secondInput[count];
                    secondArray[i] += secondInput[count + 1];
                }
                else if (i % 2 != 0)
                {
                    secondArray[i] += secondInput[count];
                    firstArray[i] += secondInput[count + 1];
                }
            }
            foreach (var item in firstArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            foreach (var item in secondArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
