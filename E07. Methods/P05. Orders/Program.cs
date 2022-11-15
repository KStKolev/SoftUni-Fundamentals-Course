namespace Orders
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            GenerateOrderPrice(inputString, quantity);
            Console.Read();
        }
        private static void GenerateOrderPrice(string inputString, int quantity)
        {
            double price = 0;
            switch (inputString)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            double sum = price * quantity;
            Console.WriteLine($"{sum:F2}");
        }
    }
}
