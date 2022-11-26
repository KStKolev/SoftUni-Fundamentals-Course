namespace ReverseStrings
{
    using System;
    using System.Text;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputWords = string.Empty;
            while ((inputWords = Console.ReadLine()) != "end")
            {
                StringBuilder newWord = new StringBuilder();
                char[] symbolsFromWord = inputWords.ToCharArray();
                for (int i = inputWords.Length -1; i >= 0; i--)
                {
                    newWord.Append(symbolsFromWord[i]);
                }
                Console.WriteLine($"{inputWords} = {newWord}");
            }
            Console.Read();
        }
    }
}
