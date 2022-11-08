namespace RageExpenses
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double headsetCount = lostGames / 2;
            double mouseCount = lostGames / 3;
            double keyboardCount = lostGames / 6;
            double displayCount = lostGames / 12;
            headsetPrice *= headsetCount;
            mousePrice *= mouseCount;
            keyboardPrice *= keyboardCount;
            displayPrice *= displayCount;
            double expenses = headsetPrice + mousePrice + keyboardPrice + displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
            Console.Read();
        }
    }
}

