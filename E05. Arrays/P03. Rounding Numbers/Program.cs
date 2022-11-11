namespace RoundingNumbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] floatingPointNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < floatingPointNumbers.Length; i++)
            {
                Console.WriteLine($"{floatingPointNumbers[i]} => {(int)Math.Round(floatingPointNumbers[i], MidpointRounding.AwayFromZero)}");
            }
            Console.Read();
        }
    }
}
