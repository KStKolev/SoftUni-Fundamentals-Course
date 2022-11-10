namespace SumOfChars
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int charNumbers = int.Parse(Console.ReadLine());
            int charSum = 0;
            for (int i = 1; i <= charNumbers; i++)
            {
                char enlishLetters = char.Parse(Console.ReadLine());
                charSum += (int)enlishLetters;
            }
            Console.WriteLine($"The sum equals: {charSum}");
        }
    }
}
