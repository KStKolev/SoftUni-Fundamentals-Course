namespace SignOfIntegerNumbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            CheckNumSign(inputNumber);
        }
        private static void CheckNumSign(int inputNumber)
        {
            if (inputNumber > 0)
            {
                Console.WriteLine($"The number {inputNumber} is positive. ");
            }
            else if (inputNumber < 0)
            {
                Console.WriteLine($"The number {inputNumber} is negative. ");
            }
            else if (inputNumber == 0)
            {
                Console.WriteLine($"The number {inputNumber} is zero. ");
            }
        }
    }
}
