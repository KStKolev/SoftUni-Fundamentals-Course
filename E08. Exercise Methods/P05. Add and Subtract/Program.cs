namespace AddAndSubtract
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstInputNumber = int.Parse(Console.ReadLine());
            int secondInputNumber = int.Parse(Console.ReadLine());
            int thirdInputNumber = int.Parse(Console.ReadLine());
            int sum = SumDigits(firstInputNumber, secondInputNumber);
            int subtractNumber = SubtractDigits(sum, thirdInputNumber);
            Console.WriteLine(subtractNumber);
            Console.Read();
        }
        private static int SumDigits(int firstInputNumber, int secondInputNumber)
        {
            return firstInputNumber + secondInputNumber;
        }
        private static int SubtractDigits(int sum, int thirdInputNumber)
        {
            return sum - thirdInputNumber;
        }
    }
}
