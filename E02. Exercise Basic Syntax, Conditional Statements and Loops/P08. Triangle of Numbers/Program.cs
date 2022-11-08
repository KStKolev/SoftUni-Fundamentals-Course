namespace TriangleOfNumbers
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int column = 1; column <= n; column++)
            {
                for (int row = 1; row <= column; row++)
                {
                    Console.Write($"{column} ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

