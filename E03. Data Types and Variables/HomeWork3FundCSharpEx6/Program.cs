namespace ReversedChars
{
        using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());
            Console.WriteLine($"{thirdSymbol} {secondSymbol} {firstSymbol}");
        }
    }
}
