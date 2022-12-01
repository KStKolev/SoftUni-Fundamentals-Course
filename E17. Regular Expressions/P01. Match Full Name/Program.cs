namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchFullName(pattern);
        }

        private static void MatchFullName(string pattern)
        {
            Regex regex = new Regex(pattern);
            string inputNames = Console.ReadLine();
            MatchCollection validNames = regex.Matches(inputNames);
            foreach (Match item in validNames)
            {
                Console.Write(item.Value + " ");
            }
            Console.Read();
        }
    }
}
