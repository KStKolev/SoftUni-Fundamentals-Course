namespace TextFilter
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string inputWords = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                string replacement = new string( '*', bannedWords[i].Length);
                while (inputWords.Contains(bannedWords[i]))
                {
                    inputWords = inputWords.Replace(bannedWords[i], replacement);
                }
            }
            Console.WriteLine(inputWords);
            Console.Read();
        }
    }
}
