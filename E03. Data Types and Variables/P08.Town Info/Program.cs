namespace TownInfo
{
        using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            int townPopulation = int.Parse(Console.ReadLine());
            short townArea = short.Parse(Console.ReadLine());
            Console.WriteLine($"Town {townName} has population of {townPopulation} and area {townArea} square km.");
        }
    }
}
