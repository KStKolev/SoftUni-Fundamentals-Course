namespace CaesarChiper
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            PrintNewWord(inputText);
        }

        private static void PrintNewWord(string inputText)
        {
            int[] digitsFromText = new int[inputText.Length];
            int index = 0;
            foreach (var currentSymbol in inputText)
            {
                digitsFromText[index] = currentSymbol + 3;
                index++;
            }
            char[] symbolsFromDigits = new char[digitsFromText.Length];
            index = 0;
            foreach (var currentDigit in digitsFromText)
            {
                symbolsFromDigits[index] = (char)currentDigit;
                index++;
            }
            foreach (var symbols in symbolsFromDigits)
            {
                Console.Write(symbols);
            }
            Console.Read();
        }
    }
}
