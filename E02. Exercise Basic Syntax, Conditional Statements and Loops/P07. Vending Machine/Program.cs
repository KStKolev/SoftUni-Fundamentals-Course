namespace VendingMachine
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            string input = string.Empty;
            double accumulateCoins = 0;
            while (input != "Start")
            {
                input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                if (input == "0.1")
                {
                    accumulateCoins += 0.1;
                }
               else if (input == "0.2")
                {
                    accumulateCoins += 0.2;
                }
               else if (input == "0.5")
                {
                    accumulateCoins += 0.5;
                }
               else if (input == "1")
                {
                    accumulateCoins += 1.0;
                }
               else if (input == "2")
                {
                    accumulateCoins += 2.0;
                }
               else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
            }
            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input == "Nuts")
                {
                    if (accumulateCoins >= 2)
                    {
                        accumulateCoins -= 2;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
               else if (input == "Water")
                {
                    if (accumulateCoins >= 0.7)
                    {
                        accumulateCoins -= 0.7;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
               else if (input == "Crisps")
                {
                    if (accumulateCoins >= 1.5)
                    {
                        accumulateCoins -= 1.5;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
               else if (input == "Soda")
                {
                    if (accumulateCoins >= 0.8)
                    {
                        accumulateCoins -= 0.8;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
               else if (input == "Coke")
                {
                    if (accumulateCoins >= 1.0)
                    {
                        accumulateCoins -= 1.0;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {accumulateCoins:F2}");
        }
    }
}
