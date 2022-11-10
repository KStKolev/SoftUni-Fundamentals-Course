namespace SpiceMustFlow
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int gatheringDays = 0;
            long gatheredSpice = 0;
            while (startingYield >= 100)
            {
                gatheredSpice += startingYield - 26;
                startingYield -= 10;
                gatheringDays++;
            }
            gatheredSpice -= 26;
            Console.WriteLine(gatheringDays);
            Console.WriteLine(gatheredSpice);
        }
    }
}
