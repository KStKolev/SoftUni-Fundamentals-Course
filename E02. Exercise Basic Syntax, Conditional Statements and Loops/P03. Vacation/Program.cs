namespace Vacation
{
    using System;
    
   public class Program
    {
       public static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double studentPrice = 0;
            double businessPrice = 0;
            double regularPrice = 0;
            double totalPrice = 0;
            if (dayOfTheWeek.Equals("Friday"))
            {
                studentPrice = 8.45;
                businessPrice = 10.90;
                regularPrice = 15;
            }
            else if (dayOfTheWeek.Equals("Saturday"))
            {
                studentPrice = 9.80;
                businessPrice = 15.60;
                regularPrice = 20;
            }
           else if (dayOfTheWeek.Equals("Sunday"))
            {
                studentPrice = 10.46;
                businessPrice = 16;
                regularPrice = 22.50;
            }
            if (typeOfTheGroup.Equals("Students"))
            {
                totalPrice = studentPrice * countOfPeople;
                if (countOfPeople >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
           else if (typeOfTheGroup.Equals("Business"))
            {
                if (countOfPeople >= 100)
                {
                    countOfPeople -= 10;
                    totalPrice = businessPrice * countOfPeople;
                }
            }
           else if (typeOfTheGroup.Equals("Regular"))
            {
                totalPrice = regularPrice * countOfPeople;
                if (countOfPeople > 10 && countOfPeople < 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}

