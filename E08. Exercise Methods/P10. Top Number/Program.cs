namespace TopNumber
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            TopNumber(inputNumber);
            Console.Read();
        }
        private static void TopNumber(int inputNumber)
        {
            string inputText = inputNumber.ToString();
            for (int i = 1; i <= inputNumber; i++)
            {
                int sumOfIndexDigits = 0;
                bool isOddNumber = false;
                string inputString = i.ToString();
                for (int j = 0; j < inputString.Length; j++)
                {
                    string text = inputString[j].ToString();
                    int intInputText = int.Parse(text);
                    sumOfIndexDigits += intInputText;
                    if (intInputText % 2 != 0)
                    {
                        isOddNumber = true;
                    }
                }
                if (sumOfIndexDigits % 8 == 0 && isOddNumber == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
