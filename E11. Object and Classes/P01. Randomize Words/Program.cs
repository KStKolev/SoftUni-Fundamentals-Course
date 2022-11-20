namespace RandomizeWords
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine()
                .Split();
            Random random = new Random();
            for (int i = 0; i < inputText.Length; i++)
            {
                string saveWord = inputText[i];
                int randomindex = random.Next(0, inputText.Length);
                inputText[i] = inputText[randomindex];
                inputText[randomindex] = saveWord;
            }
            foreach (var item in inputText)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
