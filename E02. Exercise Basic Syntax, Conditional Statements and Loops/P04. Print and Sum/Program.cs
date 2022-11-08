namespace PrintAndSum
{
    using System;
   
    public class Program
    {
       public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int sumOfAllNumbers = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.Write($"{i} ");
                sumOfAllNumbers += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumOfAllNumbers}");
            Console.Read();
        }
    }
}
