namespace GreaterOfTwoValues
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            if (inputType.Equals("string"))
            {
                string inputFirstString = Console.ReadLine();
                string inputSecondString = Console.ReadLine();
                string stringValue = GetMax(inputFirstString, inputSecondString);
                Console.WriteLine(stringValue);
            }
            if (inputType.Equals("int"))
            {
                int inputFirstNumber = int.Parse(Console.ReadLine());
                int inputSecondNumber = int.Parse(Console.ReadLine());
                GetMax(inputFirstNumber, inputSecondNumber);
            }
            if (inputType.Equals("char"))
            {
                char inputFirstChar = char.Parse(Console.ReadLine());
                char inputSecondChar = char.Parse(Console.ReadLine());
                GetMax(inputFirstChar, inputSecondChar);
            }
            Console.Read();
        }
        public static string GetMax(string inputFirstString, string inputSecondString)
        {
            int result = inputFirstString.CompareTo(inputSecondString);
            if (result > 0)
            {
                return inputFirstString;
            }
            else
            {
                return inputSecondString;
            }
        }
        private static void GetMax(int inputFirstNumber, int inputSecondNumber)
        {
            if (inputFirstNumber > inputSecondNumber)
            {
                Console.WriteLine(inputFirstNumber);
            }
            else
            {
                Console.WriteLine(inputSecondNumber);
            }
        }
        private static void GetMax(char inputFirstChar, char inputSecondChar)
        {
            if ((int)inputFirstChar > (int)inputSecondChar)
            {
                Console.WriteLine(inputFirstChar);
            }
            else
            {
                Console.WriteLine(inputSecondChar);
            }
        }
    }
}
