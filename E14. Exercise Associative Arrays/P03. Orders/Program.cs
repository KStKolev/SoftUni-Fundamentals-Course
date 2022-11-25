namespace Orders
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> productOrders = new Dictionary<string, List<decimal>>();
            OrdersForProducts(productOrders);
        }

        private static void OrdersForProducts(Dictionary<string, List<decimal>> productOrders)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arrayCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = arrayCommand[0];
                decimal price = decimal.Parse(arrayCommand[1]);
                int quantity = int.Parse(arrayCommand[2]);
                if (!productOrders.ContainsKey(product))
                {
                    productOrders.Add(product, new List<decimal>() { price, quantity });
                }
                else
                {
                    productOrders[product][0] = price;
                    productOrders[product][1] += quantity;
                }
            }
            foreach (var currentProduct in productOrders)
            {
                Console.WriteLine($"{currentProduct.Key} -> {currentProduct.Value[0] * currentProduct.Value[1]:F2}");
            }
            Console.Read();
        }
    }
}
