namespace Substring
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string deletedWord = Console.ReadLine();
            string inputWord = Console.ReadLine();
            while (inputWord.Contains(deletedWord))
            {
                int firstIndexOfDeletedWord = inputWord.IndexOf(deletedWord);
                inputWord = inputWord.Remove(firstIndexOfDeletedWord, deletedWord.Length);
            }
            Console.WriteLine(inputWord);
            Console.Read();
        }
    }
}
