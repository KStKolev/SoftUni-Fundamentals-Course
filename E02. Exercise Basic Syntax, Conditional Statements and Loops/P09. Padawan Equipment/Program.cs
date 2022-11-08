namespace PadawanEquipment
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine()) * studentCount;
            double beltsPrice = double.Parse(Console.ReadLine());
            double lightsaberCount = studentCount + (studentCount * 0.10);
            lightsaberCount = Math.Ceiling(lightsaberCount);
            lightsaberPrice *= lightsaberCount;
            int beltsCount = studentCount - (studentCount / 6);
            beltsPrice *= beltsCount;
            double totalPrice = lightsaberPrice + robePrice + beltsPrice;
            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else if (amountOfMoney < totalPrice)
            {
                double neededMoney = totalPrice - amountOfMoney;
                Console.WriteLine($"John will need {neededMoney:F2}lv more.");
            }
            Console.Read();
        }
    }
}

