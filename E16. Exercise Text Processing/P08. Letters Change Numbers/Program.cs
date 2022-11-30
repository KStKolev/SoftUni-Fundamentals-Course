namespace T08._Letters_Change_Numbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arrayinput = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            LettersChangeNumbers(arrayinput);
        }
        private static void LettersChangeNumbers(string[] arrayinput)
        {
            double sum = 0;
            foreach (string item in arrayinput)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];
                string numAsAString = item[1..^1];
                double numFromString = double.Parse(numAsAString);
                if (char.IsUpper(firstLetter))
                {
                    int postionOfTheLetter = firstLetter - 64;
                    numFromString /= postionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }
                if (char.IsUpper(lastLetter))
                {
                    int positionOfTheLetter = lastLetter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastLetter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
