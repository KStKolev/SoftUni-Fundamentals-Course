namespace DigitsLettersAndOthers
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherSymbols = new StringBuilder();
            foreach (char ch in inputText)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    otherSymbols.Append(ch);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(otherSymbols);
            Console.Read();
        }
    }
}
