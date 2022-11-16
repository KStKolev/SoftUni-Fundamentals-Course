namespace MiddleCharacters
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            PrintMiddleCharacter(stringInput);
            Console.Read();
        }
        private static void PrintMiddleCharacter(string stringInput)
        {
            int arrayLenght = stringInput.Length;
            string result = string.Empty;
            if (arrayLenght % 2 == 0)
            {
                result = stringInput[stringInput.Length / 2 - 1] + stringInput[stringInput.Length / 2].ToString();
            }
            else
            {
                result = stringInput[stringInput.Length / 2].ToString();
            }
            Console.WriteLine(result);
        }
    }
}
