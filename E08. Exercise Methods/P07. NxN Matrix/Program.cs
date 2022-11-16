namespace NxNMatrix
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            MultiplyInputNumber(inputNumber);
            Console.Read();
        }
        private static void MultiplyInputNumber(int inputNumber)
        {
            for (int i = inputNumber; i > 0; i--)
            {
                for (int j = 1; j <= inputNumber; j++)
                {
                    Console.Write($"{inputNumber} ");
                }
                Console.WriteLine();
            }
        }
    }
}
