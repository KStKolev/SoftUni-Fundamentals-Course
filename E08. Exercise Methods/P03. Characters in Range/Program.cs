namespace CharactersInRange
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            char firstCharInput = char.Parse(Console.ReadLine());
            char secondCharInput = char.Parse(Console.ReadLine());
            int firstIntInput = (int)firstCharInput;
            int secondIntInput = (int)secondCharInput;
            if (firstIntInput > secondIntInput)
            {
                CharBetweenInputChar(firstIntInput, secondIntInput);
            }
            else if (secondIntInput > firstIntInput)
            {
                SecondCharBetweenInputChar(firstIntInput, secondIntInput);
            }
            Console.Read();
        }
        private static void CharBetweenInputChar(int firstIntInput, int secondIntInput)
        {
            for (int i = secondIntInput + 1; i < firstIntInput; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
        private static void SecondCharBetweenInputChar(int firstIntInput, int secondIntInput)
        {
            for (int i = firstIntInput + 1; i < secondIntInput; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
