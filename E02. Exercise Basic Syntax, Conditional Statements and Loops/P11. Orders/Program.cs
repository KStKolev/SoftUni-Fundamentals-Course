namespace Orders
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double coffeePrice = 0;
            double totalPrice = 0;
            while (n > 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                coffeePrice = ((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
                totalPrice += coffeePrice;
                n--;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}

