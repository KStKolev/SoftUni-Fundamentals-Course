namespace CalculateRectangleArea
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int area = RectangleArea(sideA, sideB);
            Console.WriteLine(area);
            Console.Read();
        }
        private static int RectangleArea(int sideA, int sideB)
        {
            return sideA * sideB;
        }
    }
}
