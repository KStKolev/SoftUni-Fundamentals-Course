namespace BigFactorial
{
    using System;
    using System.Numerics;
    public class Program
    {
        public static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());
            BigInteger inputNumber = 1;
            for (int i = 1; i <= factorial; i++)
            {
                inputNumber *= i;
            }
            Console.WriteLine(inputNumber);
            Console.Read();
        }
    }
}
