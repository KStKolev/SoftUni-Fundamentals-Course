namespace FactorialDivision
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double firstInputDigit = double.Parse(Console.ReadLine());
            double secondInputDigit = double.Parse(Console.ReadLine());

            FirstFactorial(firstInputDigit);
            SecondFactorial(secondInputDigit);

            Console.WriteLine($"{FinalResult(firstInputDigit, secondInputDigit):F2}");
        }
        private static double FirstFactorial(double firstInputDigit)
        {
            double current = 1;

            if (firstInputDigit >= 1)
            {
                for (double num = firstInputDigit; num >= 1; num--)
                {
                    current = num * current;
                }
            }
            return current;
        }
        private static double SecondFactorial(double secondInputDigit)
        {
            double digit = 1;

            if (secondInputDigit >= 1)
            {

                for (double num = secondInputDigit; num >= 1; num--)
                {
                    digit = num * digit;
                }
            }
            return digit;
        }
        private static double FinalResult(double firstInputDigit, double secondInputDigit)
        {
            double calculation = FirstFactorial(firstInputDigit) / SecondFactorial(secondInputDigit);
            return calculation;
        }

    }
}