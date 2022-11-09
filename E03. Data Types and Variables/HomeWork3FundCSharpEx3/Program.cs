namespace ExactSumOfRealNumbers
{
        using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= n; i++)
            {
                decimal sumNumbers = decimal.Parse(Console.ReadLine());
                sum += sumNumbers;
            }
            Console.WriteLine(sum);
        }
    }
}
