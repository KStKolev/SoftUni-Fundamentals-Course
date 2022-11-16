namespace VowelsCount
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            VowelsCharacter(inputString);
            Console.Read();
        }
        private static void VowelsCharacter(string inputString)
        {
            char[] vowels = new char[] { 'A', 'a', 'o', 'O', 'U', 'u', 'e', 'E', 'i', 'I' };
            int CountVowels = 0;
            foreach (char letter in inputString)
            {
                if (vowels.Contains(letter))
                {
                    CountVowels++;
                }
            }
            Console.WriteLine(CountVowels);
        }
    }
}
