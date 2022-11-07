using System;

namespace MultiplicationTableVer2
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            for (int i = secondNumber; i <= 10; i++)
            {
                Console.WriteLine($"{firstNumber} X {i} = {firstNumber * i}");
            }
            if (secondNumber > 10)
            {
                Console.WriteLine($"{firstNumber} X {secondNumber} = {firstNumber * secondNumber}");
            }
            Console.Read();
        }
    }
}
