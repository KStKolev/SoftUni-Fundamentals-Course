namespace RefactorSpecialNumbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            for (int input = 1; input <= firstNumber; input++)
            {
                bool isSpecialNum = false;
                int secondNumber = input;
                int thirdUsedNumber = 0;
                while (secondNumber > 0)
                {
                    thirdUsedNumber += secondNumber % 10;
                    secondNumber /= 10;
                }
                isSpecialNum = (thirdUsedNumber == 5) || (thirdUsedNumber == 7) || (thirdUsedNumber == 11);
                Console.WriteLine("{0} -> {1}", input, isSpecialNum);
            }
        }
    }
}
