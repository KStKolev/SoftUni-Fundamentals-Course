using System;

namespace TheatrePromotions
{
   public class Program
    {
       public static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int personAge = int.Parse(Console.ReadLine());
            if (personAge >= 0 && personAge <= 18)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    Console.WriteLine("12$");
                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    Console.WriteLine("15$");
                }
                else if (typeOfDay.Equals("Holiday"))
                {
                    Console.WriteLine("5$");
                }
            }
            else if (personAge > 18 && personAge <= 64)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    Console.WriteLine("18$");
                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    Console.WriteLine("20$");
                }
                else if(typeOfDay.Equals("Holiday"))
                {
                    Console.WriteLine("12$");
                }
            }
            else if (personAge > 64 && personAge <= 122)
            {
                if (typeOfDay.Equals("Weekday"))
                {
                    Console.WriteLine("12$");
                }
                else if (typeOfDay.Equals("Weekend"))
                {
                    Console.WriteLine("15$");
                }
                else if (typeOfDay.Equals("Holiday"))
                {
                    Console.WriteLine("10$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            Console.Read();
        }
    }
}
