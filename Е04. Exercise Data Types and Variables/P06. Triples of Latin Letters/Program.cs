namespace TriplesOfLatinLetters
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int thirdInput = 0; thirdInput < numbers; thirdInput++)
            {
                for (int secondInput = 0; secondInput < numbers; secondInput++)
                {
                    for (int firstInput = 0; firstInput < numbers; firstInput++)
                    {
                        char firstSymbol = (char)('a' + firstInput);
                        char secondSymbol = (char)('a' + secondInput);
                        char thirdSymbol = (char)('a' + thirdInput);
                        Console.Write($"{thirdSymbol}{secondSymbol}{firstSymbol}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
