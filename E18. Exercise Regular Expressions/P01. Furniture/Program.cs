namespace Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputText = string.Empty;
            string pattern = @">>(?<furnitureName>[A-Za-z]+)<<(?<price>[\d]+(\.\d+)?)!(?<quantity>\d+)";
            inputText = FurniturePriceAndNamePrint(pattern);
        }

        private static string FurniturePriceAndNamePrint(string pattern)
        {
            string inputText;
            List<string> furnitures = new List<string>();
            double moneySpent = 0;
            Regex regex = new Regex(pattern);
            while ((inputText = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(inputText);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    furnitures.Add(furnitureName);
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    moneySpent += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var currentFurniture in furnitures)
            {
                Console.WriteLine(currentFurniture);
            }
            Console.WriteLine($"Total money spend: {moneySpent:F2}");
            Console.Read();
            return inputText;
        }
    }
}
