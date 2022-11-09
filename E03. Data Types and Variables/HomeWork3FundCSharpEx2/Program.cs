namespace PoundsToDollars
{
        using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            double britishPound = double.Parse(Console.ReadLine());
            double usDollar = britishPound * 1.31;
            Console.WriteLine($"{usDollar:F3}");
        }
    }
}
