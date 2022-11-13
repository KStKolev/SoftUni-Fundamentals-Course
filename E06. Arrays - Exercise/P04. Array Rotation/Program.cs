namespace ArrayRotation
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] firstInputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int inputRotationCycleNumber = int.Parse(Console.ReadLine());
            int firstNumberInArray = 0;
            for (int i = 1; i <= inputRotationCycleNumber; i++)
            {
                int lastIndexOfArray = firstInputArray.Length - 2;
                int helpNumber = 0;
                firstNumberInArray = firstInputArray[0];
                while (lastIndexOfArray >= helpNumber)
                {
                    firstInputArray[helpNumber] = firstInputArray[helpNumber + 1];
                    helpNumber++;
                }
                firstInputArray[firstInputArray.Length - 1] = firstNumberInArray;
            }
            foreach (var item in firstInputArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
