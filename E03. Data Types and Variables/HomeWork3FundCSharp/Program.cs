namespace ConvertMetersToKilometers
{
        using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometers = meters / 1000d;
            Console.WriteLine($"{kilometers:F2}");
            Console.Read();
        }
    }
}
