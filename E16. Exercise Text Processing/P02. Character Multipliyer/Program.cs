namespace CharacterMultipliyer
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] twoWords = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            PrintSumOfCharacters(twoWords);
        }

        private static void PrintSumOfCharacters(string[] twoWords)
        {
            int sumOfTheCharsMultiplication = 0;
            string firstWord = twoWords[0];
            string secondWord = twoWords[1];
            int count = -1;
            for (int i = 0; i < firstWord.Length; i++)
            {
                count++;
                if (count >= secondWord.Length)
                {
                    sumOfTheCharsMultiplication += firstWord[i];
                    continue;
                }
                for (int k = count; k <= i; k++)
                {
                    sumOfTheCharsMultiplication += firstWord[i] * secondWord[k];
                }
            }
            if (count < secondWord.Length - 1)
            {
                count++;
                for (int i = count; i < secondWord.Length; i++)
                {
                    sumOfTheCharsMultiplication += secondWord[i];
                }
            }
            Console.WriteLine(sumOfTheCharsMultiplication);
            Console.Read();
        }
    }
}
