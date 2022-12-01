namespace MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"\+359([-, ])2\1\d{3}\1\d{4}\b";
            MatchPhoneNumber(pattern);
        }

        private static void MatchPhoneNumber(string pattern)
        {
            string inputNumber = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection validNumbers = regex.Matches(inputNumber);
            string[] result = validNumbers.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", result));
            Console.Read();
        }
    }
}
