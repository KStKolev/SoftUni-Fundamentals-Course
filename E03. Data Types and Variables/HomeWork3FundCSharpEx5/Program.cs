namespace SpecialNumbers
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
               int sum = i;
               int thirdNumber = 0;
                while (sum > 0)
                {
                    thirdNumber += sum % 10;
                    sum /= 10;
                }
                if (thirdNumber == 5 || thirdNumber == 7 || thirdNumber == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else 
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
