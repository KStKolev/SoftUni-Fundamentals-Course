namespace PalindromeIntegers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = string.Empty;
            IsPalindromeDigit(inputText);
            Console.Read();
        }
        private static void IsPalindromeDigit(string inputText)
        {
            while ((inputText = Console.ReadLine()) != "END")
            {
                int inputNumber = int.Parse(inputText);
                if (inputNumber < 0)
                {
                    break;
                }
                string saveFirstInput = string.Empty;
                string saveSecondInput = string.Empty;
                for (int i = 0; i < inputText.Length; i++)
                {
                    saveFirstInput += inputText[i];
                }
                for (int i = inputText.Length - 1; i >= 0; i--)
                {
                    saveSecondInput += inputText[i];
                }
                if (saveSecondInput == saveFirstInput)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
