namespace SmallestOfThreeNumbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            ComareNumbers();
            Console.Read();
        }
        private static void ComareNumbers()
        {
            int BiggestNumber = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < BiggestNumber)
                {
                    BiggestNumber = numbers;
                }
            }
            Console.WriteLine(BiggestNumber);
        }
    }
}
