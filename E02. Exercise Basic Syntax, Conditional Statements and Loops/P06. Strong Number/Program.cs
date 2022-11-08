namespace HomeWork2FundCSharpEx6
{
using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int usedNumber = number;
            int lastNumber = 0;
            int sumOfFactorial = 0;
            while (usedNumber > 0)
            {
                int factorialNumber = 1;
                lastNumber = usedNumber % 10;
                usedNumber /= 10;
                for (int i = 2; i <= lastNumber; i++)
                {
                    factorialNumber *= i;
                }
                sumOfFactorial += factorialNumber;
            }
            if (sumOfFactorial == number)
            {
                Console.WriteLine("yes");
            }
            else if (sumOfFactorial != number)
            {
                Console.WriteLine("no");
            }
        }
    }
}

