namespace StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputCommand = string.Empty;
            List<Box> allBoxes = new List<Box>();
            while ((inputCommand = Console.ReadLine()) != "end")
            {
                string[] boxInfo = inputCommand.Split();
                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQuantity = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);
                Items item = new Items(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                allBoxes.Add(box);
            }
            foreach (var currentBox in allBoxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForABox:F2}");
            }
            Console.Read();
        }

        public class Box
        {
            public Box(string serialNumber, Items item, int itemQuantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = itemQuantity;
            }
            public string SerialNumber { get; set; }
            public Items Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForABox
            {
                get
                {
                    return ItemQuantity * Item.Price;
                }
            }
        }
        public class Items
        {
            public Items(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
