namespace SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            SoftUniBarIncome();
        }

        private static void SoftUniBarIncome()
        {
            string inputText = string.Empty;
            string pattern = @"^[^\%\|\.\$]*?\%(?<customer>[A-Z][a-z]+)\%[^\%\|\.\$]*?\<(?<product>\w+)\>[^\%\|\.\$]*?\|[^\%\|\.\$]*?(?<count>[0-9]+)[^\%\|\.\$]*?\|[^\%\|\.\$]*?(?<price>\d+(\.\d+)?)[^\%\|\.\$]*?\$$";
            Regex regex = new Regex(pattern);
            double totalIncome = 0;
            while ((inputText = Console.ReadLine()) != "end of shift")
            {
                string customer = string.Empty;
                string product = string.Empty;
                int count = 0;
                double price = 0;
                Match match = regex.Match(inputText);
                if (match.Success)
                {
                    customer = match.Groups["customer"].Value;
                    product = match.Groups["product"].Value;
                    count = int.Parse(match.Groups["count"].Value);
                    price = double.Parse(match.Groups["price"].Value);
                    double currentPrice = count * price;
                    totalIncome += currentPrice;
                    Console.WriteLine($"{customer}: {product} - {currentPrice:F2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
            Console.Read();
        }
    }
}
