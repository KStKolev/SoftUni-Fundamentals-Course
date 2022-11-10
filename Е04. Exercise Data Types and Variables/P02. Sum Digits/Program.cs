namespace SumDigits
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputDigit = int.Parse(Console.ReadLine());
            int sumDigit = 0;
            while (inputDigit > 0)
            {
                sumDigit += inputDigit % 10;
                inputDigit /= 10;
            }
            Console.WriteLine(sumDigit);
        }
    }
}
