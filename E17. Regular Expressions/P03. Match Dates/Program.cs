namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"(?<day>\d{2})([\.|\-|/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            MatchDates(pattern);
        }

        private static void MatchDates(string pattern)
        {
            string inputDates = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection validDates = regex.Matches(inputDates);
            foreach (Match currentDate in validDates)
            {
                Console.WriteLine($"Day: {currentDate.Groups["day"]}, Month: {currentDate.Groups["month"]}" +
                    $", Year: {currentDate.Groups["year"]}");
            }
            Console.Read();
        }
    }
}
