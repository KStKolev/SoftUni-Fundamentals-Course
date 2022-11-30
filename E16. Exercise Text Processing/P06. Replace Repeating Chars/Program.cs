namespace ReplaceRepeatingChars
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            PrintDifferentSymbols(inputText);
        }

        private static void PrintDifferentSymbols(string inputText)
        {
            char firstSymbol = inputText[0];
            Console.Write(firstSymbol);
            for (int i = 1; i < inputText.Length; i++)
            {
                char nextSymbol = inputText[i];
                if (nextSymbol != firstSymbol)
                {
                    Console.Write(nextSymbol);
                    firstSymbol = nextSymbol;
                }
            }
            Console.Read();
        }
    }
}
