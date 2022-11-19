namespace SumOfOddNumbers
{
   using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int oddnumbers = 1;
            int sumOddNumber = 0;
            int count = 0;
            while (count < numbers)
            {
                Console.WriteLine(oddnumbers);
                sumOddNumber += oddnumbers;
                oddnumbers += 2;
                count++;
            }
            Console.WriteLine($"Sum: {sumOddNumber}");
            Console.Read();
        }
    }
}
