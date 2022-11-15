namespace MathPower
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            double poweredNumber = BasePowered();
            Console.WriteLine(poweredNumber);
            Console.Read();
        }
        private static double BasePowered()
        {
            double baseInput = double.Parse(Console.ReadLine());
            double powerInput = double.Parse(Console.ReadLine());
            return Math.Pow(baseInput, powerInput);
        }
    }
}
