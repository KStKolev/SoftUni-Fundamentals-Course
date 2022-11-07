using System;

namespace EvenNumber
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int evenNumbers = 1;
            while (evenNumbers % 2 != 0)
            {
                evenNumbers = int.Parse(Console.ReadLine());
                if (evenNumbers % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(evenNumbers)}");
                    break;
                }
                Console.WriteLine("Please write an even number.");
            }
            Console.Read();
        }
    }
}
