namespace WaterOverflow
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPouringWater = int.Parse(Console.ReadLine());
            int waterCapacity = 255;
            while (numberOfPouringWater > 0)
            {
                int amountOfPouringWater = int.Parse(Console.ReadLine());
                if (amountOfPouringWater > waterCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    numberOfPouringWater--;
                    continue;
                }
                waterCapacity -= amountOfPouringWater;
                numberOfPouringWater--;
            }
            Console.WriteLine(255 - waterCapacity);
        }
    }
}
