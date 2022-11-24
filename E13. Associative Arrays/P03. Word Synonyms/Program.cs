namespace WordSynonyms
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            var collectionOfWords = new Dictionary<string, List<string>>();
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!collectionOfWords.ContainsKey(word))
                {
                    collectionOfWords.Add(word, new List<string>());
                }
                collectionOfWords[word].Add(synonym);
            }
            foreach (var currentWord in collectionOfWords)
            {
                Console.WriteLine($"{currentWord.Key} - {string.Join(", ", currentWord.Value)}");
            }
            Console.Read();
        }
    }
}
