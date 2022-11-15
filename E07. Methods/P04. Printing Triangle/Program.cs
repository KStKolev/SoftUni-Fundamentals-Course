namespace PrintingTriangle
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            Triangle(inputNumber);
            Console.Read();
        }
        private static void Triangle(int inputNumber)
        {
            for (int i = 1; i <= inputNumber; i++)
            {
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
            for (int i = inputNumber - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
