namespace CenturiesToMinutes
{
        using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            short centuries = sbyte.Parse(Console.ReadLine());
            int years = centuries * 100;
            double leapYear = years * 365.2422;
            int days = (int)leapYear;
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
